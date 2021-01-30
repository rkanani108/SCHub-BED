using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using Web.Services;
using Web.Services.Model.Temple;

namespace Web.Pages.Search
{
    public class TempleModel : PageModel
    {
        private readonly ILogger<CareersModel> _logger;
      
        public readonly ITempleService _templeService;
        public TempleModel(ILogger<CareersModel> logger, ITempleService templeService)
        {
            _logger = logger;
        
            _templeService = templeService;
        }

        public QueryTempleData Result { get; set; }
        public async Task OnGetAsync()
            {
            Result = await _templeService.GetResult();
        }
    }
}
