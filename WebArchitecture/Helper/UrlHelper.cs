using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Configuration;
using System;

namespace Web.Helper
{
    public static class UrlHelper
    {
        public static string cdn(string url)
        {
            var isCndResolve = Startup.StaticConfig.GetValue<bool>("cdnResolve");
            if (!isCndResolve)
                return url;
            var local = AppContext.Current.Request.GetDisplayUrl().TrimEnd('/');
            if (local.Contains("localhost") && !url.Contains("http"))
            {
                return url;
            }

            var cdnRoot = Startup.StaticConfig.GetValue<string>("cdnUrl");

            if (string.IsNullOrEmpty(cdnRoot) || !isCndResolve)
                return url;

            if (url.StartsWith("~"))
                url = url.Substring(1);

            if (cdnRoot.EndsWith("/"))
                cdnRoot = cdnRoot.Substring(0, cdnRoot.Length - 1);

            if (url.Contains("http") || url.Contains("https"))
            {
                Uri baseUri = new Uri(url);
                url = baseUri.Host;
                url = url + baseUri.AbsolutePath;
            }
            else
            {
                var localDomain = AppContext.Current.Request.GetDisplayUrl().TrimEnd('/');
                url = localDomain + url;
                Uri baseUri = new Uri(url);
                url = baseUri.Host;
                url = url + baseUri.AbsolutePath;
            }

            if (!url.StartsWith("/"))
                url = "/" + url;

            return cdnRoot + url;
        }
    }

    //    public static MvcHtmlString DebugReleaseString(this HtmlHelper html, string debugString, string releaseString)
    //    {
    //        string toReturn = debugString;
    //        #if !DEBUG
    //            if (!string.IsNullOrEmpty(releaseString))
    //                toReturn = releaseString;
    //        #endif
    //        return MvcHtmlString.Create("");
    //

    //}
}