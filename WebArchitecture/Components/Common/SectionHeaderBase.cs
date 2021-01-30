using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Components.Common
{
    public class SectionHeaderBase: ComponentBase
    {
       
        [Parameter] public string Heading { get; set; } = "Header";
        [Parameter]  public string Description { get; set; } = "Description";
        [Parameter]  public string CTAText { get; set; } = "CTAText";
        [Parameter]  public string CTAHref { get; set; } = "CTAHref";


        public SectionHeaderBase()
        {

        }
    }
}
