using Microsoft.AspNetCore.Http;

namespace Web.Helper
{
    public static class CacheKeyHelper
    {
        public static string getCacheKey(HttpContext context, string device)
        {
            string key = context.Request.Path + "/" + context.Request.Method + "/" + device;
            key = key.Replace("/", "_").ToLower();
            return key;
        }
    }
}