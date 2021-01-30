using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using Web.Helper;
using Web.Services;
using Web.Services.Model;

namespace Web.Components
{
    public class HeaderBase : ComponentBase
    {
        public HeaderBase()
        {
        }

        protected HeaderFlatData Result { get; set; }
        protected string PageTitle { get; set; }
        protected string Message { get; set; }

        [Inject]
        protected IHomeService homeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Result = await homeService.GetHeader();
            PageTitle = AppContext.PageTitle;
        }
    }
}