using HtmlAgilityPack;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Wangkanai.Detection.Services;
using Web.Helper;

namespace Web.Middleware
{
    public class RedisCacheMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IDistributedCache _distributedCache;

        public RedisCacheMiddleware(RequestDelegate next, IDistributedCache distributedCache)
        {
            _next = next;
            _distributedCache = distributedCache;
        }

        public async Task Invoke(HttpContext context, IDetectionService detection)
        {
            var isRedisCacheEnable = Startup.StaticConfig.GetValue<bool>("IsRedisCacheEnable");
            if (isRedisCacheEnable && !context.Request.Path.Value.Contains("/api"))
            {
                string cacheKey = CacheKeyHelper.getCacheKey(context, detection.Device.Type.ToString());
                var isAvailable = _distributedCache.GetString(cacheKey);
                if (!string.IsNullOrEmpty(isAvailable))
                {
                    var watch = new Stopwatch();
                    long responseTime = 0;
                    watch.Start();
                    responseTime = watch.ElapsedMilliseconds;
                    var updatedHtml = CreateDataNode(isAvailable, responseTime);
                    await context.Response.WriteAsync(updatedHtml);
                }
                else
                {
                    var originalBody = context.Response.Body;
                    var memoryStream = new MemoryStream();
                    context.Response.Body = memoryStream;

                    var watch = new Stopwatch();
                    long responseTime = 0;
                    watch.Start();
                    await _next(context);
                    responseTime = watch.ElapsedMilliseconds;
                    memoryStream.Position = 0;
                    var newContent = await new StreamReader(memoryStream).ReadToEndAsync();
                    //set the cache
                    newContent = BasicHtmlMinifier.MinifyHtml(newContent);
                    // newContent = JSMinifier.MinifyJs(newContent);
                    _distributedCache.SetString(cacheKey, newContent);
                    //add responce time
                    var updatedHtml = CreateDataNode(newContent, responseTime);
                    var updatedStream = GenerateStreamFromString(updatedHtml);
                    await updatedStream.CopyToAsync(originalBody);
                    //return updated stream
                    context.Response.Body = originalBody;
                }
            }
            else
            {
                await _next(context);
            }
        }

        public static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        private string CreateDataNode(string originalHtml, long responseTime)
        {
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(originalHtml);
            //   HtmlNode testNode = HtmlNode.CreateNode($"<div style='margin-top:140px'><h2>Inserted using Html Agility Pack: Response Time: {responseTime.ToString()} ms.</h2><div>");
            //   var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");
            //  htmlBody.InsertBefore(testNode, htmlBody.FirstChild);

            string rawHtml = htmlDoc.DocumentNode.OuterHtml; //using this results in a page that displays my inserted HTML correctly, but duplicates the original page content.
                                                             //rawHtml = "some text"; uncommenting this results in a page with the correct format: this text, followed by the original contents of the page
            return rawHtml;
        }

        //https://stackoverflow.com/questions/54697358/how-to-insert-html-into-response-body-using-net-core-middleware
    }
}