using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Web.Services;
using Web.Services.Model.Portfolio;

namespace Web.Pages
{
    public class PortfolioModel : PageModel
    {
        private readonly ILogger<AboutusModel> _logger;
        private readonly IDistributedCache _distributedCache;
        public readonly IHomeService _homeService;
        public QueryPortfolioContentFlatData Result { get; set; }

        public PortfolioModel(ILogger<AboutusModel> logger, IDistributedCache distributedCache, IHomeService homeService)
        {
            _logger = logger;
            _distributedCache = distributedCache;
            _homeService = homeService;
        }

        public async Task OnGetAsync()
        {
            Result = await _homeService.GetPortfolio();
        }
    }
}