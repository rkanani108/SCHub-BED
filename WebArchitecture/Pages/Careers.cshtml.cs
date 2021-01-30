using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Web.Services;
using Web.Services.Model.Careers;

namespace Web.Pages
{
    public class CareersModel : PageModel
    {
        private readonly ILogger<CareersModel> _logger;
        private readonly IDistributedCache _distributedCache;
        public readonly IHomeService _homeService;
        public QueryCareersContentFlatData Result { get; set; }

        public CareersModel(ILogger<CareersModel> logger, IDistributedCache distributedCache, IHomeService homeService)
        {
            _logger = logger;
            _distributedCache = distributedCache;
            _homeService = homeService;
        }

        public async Task OnGetAsync()
        {
            Result = await _homeService.GetCareers();
        }
    }
}