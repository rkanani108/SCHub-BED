using System.Threading.Tasks;
using Web.Services;
using Web.Services.Model;
using Web.Services.Model.Temple;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using HttpPostAttribute = Microsoft.AspNetCore.Mvc.HttpPostAttribute;
using FromBodyAttribute = Microsoft.AspNetCore.Mvc.FromBodyAttribute;

namespace Web.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempleController : ControllerBase
    {
        private readonly ITempleService templeService;

        public TempleController(ITempleService templeService)
        {
            this.templeService = templeService;
        }

        [HttpPost]
        [Route("GetTemples")]
        public async Task<IActionResult> GetTemples([FromBody] Pagination param)
        {
            QueryTempleData resultModel = new QueryTempleData();

            resultModel = await templeService.GetResult(param.top, param.skip);
            return Ok(resultModel);
        }
    }
}
