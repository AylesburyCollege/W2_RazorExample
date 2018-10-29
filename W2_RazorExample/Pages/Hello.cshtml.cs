using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;

namespace W2_RazorExample.Pages
{
    public class HelloModel : PageModel
    {
        public String name;

        public void OnGet()
        {

        }

        public void OnPost()
        {
            this.name = Request.Form["name"];
        }
    }
}