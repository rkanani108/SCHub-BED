using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using Web.Services;
using Web.Services.Model;

namespace Web.Components
{
    public class FooterBase : ComponentBase
    {
        protected QueryFooterContentFlatData Result { get; set; }

        [Inject]
        protected IHomeService homeService { get; set; }

        public FooterBase()
        {
        }

        protected override async Task OnInitializedAsync()
        {
            Result = await homeService.GetFooter();
        }
    }
}