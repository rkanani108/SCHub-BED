using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Web.Services;
using Web.Services.Model.Contact;

namespace Web.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ILogger<ContactModel> _logger;
        private readonly IDistributedCache _distributedCache;
        public readonly IHomeService _homeService;
        public QueryContactContentFlatData Result { get; set; }

        public ContactModel(ILogger<ContactModel> logger, IDistributedCache distributedCache, IHomeService homeService)
        {
            _logger = logger;
            _distributedCache = distributedCache;
            _homeService = homeService;
        }

        public async Task OnGetAsync()
        {
            Result = await _homeService.GetContact();
        }
    }
}