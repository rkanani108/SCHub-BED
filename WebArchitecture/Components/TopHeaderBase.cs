using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using Web.Services;
using Web.Services.Model;

namespace Web.Components
{
    public class TopHeaderBase : ComponentBase
    {
        public TopHeaderBase()
        {
        }

        protected TopHeaderFlatData Result { get; set; }

        [Inject]
        protected IHomeService homeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Result = await homeService.GetTopHeader();
        }
    }
}