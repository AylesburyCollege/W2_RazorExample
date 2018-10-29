using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace W2_RazorExample.Pages
{
    /// <summary>
    /// Derek Peacock Example Razor Page
    /// </summary>
    public class ConvertModel : PageModel
    {
        public const decimal RATE = 1.2m;
        public string pounds;
        public decimal euros;

        public void OnGet()
        {

        }

        /// <summary>
        /// Get the input in pounds and convert it to euros
        /// </summary>
        public void OnPost()
        {
            pounds = Request.Form["pounds"];
            euros = Convert.ToDecimal(pounds) * RATE;

        }
    }
}