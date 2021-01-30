using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Web.Services;
using Web.Services.Model.About;

namespace Web.Pages
{
    public class AboutusModel : PageModel
    {
        private readonly ILogger<AboutusModel> _logger;
        private readonly IDistributedCache _distributedCache;
        public readonly IHomeService _homeService;
        public QueryAboutPageContentFlatData Result { get; set; }

        public AboutusModel(ILogger<AboutusModel> logger, IDistributedCache distributedCache, IHomeService homeService)
        {
            _logger = logger;
            _distributedCache = distributedCache;
            _homeService = homeService;
        }

        public async Task OnGetAsync()
        {
            Result = await _homeService.GetAbout();
        }
    }
}