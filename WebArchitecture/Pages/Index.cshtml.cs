using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Web.Services;
using Web.Services.Model;

namespace Web.Pages
{
    //[AddHeader("CacheKey", "HomePage")]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IDistributedCache _distributedCache;
        public readonly IHomeService _homeService;
        public HomeQueryData Data { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IDistributedCache distributedCache, IHomeService homeService)
        {
            _logger = logger;
            _distributedCache = distributedCache;
            _homeService = homeService;
        }

        public async Task OnGetAsync()
        {
            Data = null;//new HomeQueryData();
           // Data = await _homeService.Get();
        }
    }
}