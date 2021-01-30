using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

namespace Web.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class CacheController : ControllerBase
    {
        private readonly IDistributedCache distributedCache;

        public CacheController(IDistributedCache distributedCache)
        {
            this.distributedCache = distributedCache;
        }

        // GET: api/Cache
        [HttpGet]
        public string Get(string key)
        {
            if (key == "all")
            {
                distributedCache.Remove("__get_desktop");
                distributedCache.Remove("_portfolio_get_desktop");
                distributedCache.Remove("_about_get_desktop");
                distributedCache.Remove("_portfolio_get_desktop");
                distributedCache.Remove("_careers_get_desktop");
                distributedCache.Remove("_contact_get_desktop");

                distributedCache.Remove("__get_mobile");
                distributedCache.Remove("_portfolio_get_mobile");
                distributedCache.Remove("_about_get_mobile");
                distributedCache.Remove("_portfolio_get_mobile");
                distributedCache.Remove("_careers_get_mobile");
                distributedCache.Remove("_contact_get_mobile");
            }
            else if (key == "home")
            {
                distributedCache.Remove("__get_desktop");
                distributedCache.Remove("__get_mobile");
            }
            else if (key == "about")
            {
                distributedCache.Remove("_about_get_desktop");
                distributedCache.Remove("_about_get_mobile");
            }
            else if (key == "portfolio")
            {
                distributedCache.Remove("_portfolio_get_desktop");
                distributedCache.Remove("_portfolio_get_mobile");
            }
            else if (key == "careers")
            {
                distributedCache.Remove("_careers_get_desktop");
                distributedCache.Remove("_careers_get_mobile");
            }
            else if (key == "contact")
            {
                distributedCache.Remove("_contact_get_desktop");
                distributedCache.Remove("_contact_get_mobile");
            }

            return "Cache key is cleared :" + key;
        }

        // POST: api/Cache
        [HttpPost]
        public void Post()
        {
            distributedCache.Remove("_portfolio_get_desktop");
            distributedCache.Remove("_about_get_desktop");
            distributedCache.Remove("_portfolio_get_desktop");
            distributedCache.Remove("_careers_get_desktop");
            distributedCache.Remove("_contact_get_desktop");

            distributedCache.Remove("_portfolio_get_mobile");
            distributedCache.Remove("_about_get_mobile");
            distributedCache.Remove("_portfolio_get_mobile");
            distributedCache.Remove("_careers_get_mobile");
            distributedCache.Remove("_contact_get_mobile");
        }
    }
}