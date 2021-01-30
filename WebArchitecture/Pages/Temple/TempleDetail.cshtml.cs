using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages.Search
{

    public class Result {

        public string Slug { get; set; }
    }
    public class TempleDetailModel : PageModel
    {

        public Result Result { get; set; }



        public TempleDetailModel()
        {
            
        }
        public string Slug { get; set; }
        public void OnGet(string slug)
        {
            Result = new Result();
            Result.Slug = slug;
        }
    }
}
