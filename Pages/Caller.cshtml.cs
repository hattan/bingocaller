using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace RazorPagesIntro.Pages
{
    public class CallerModel : PageModel
    {
        public bool LoggedIn { get; set; }

        public void OnGet()
        {
           
        }

        public void OnPost()
        {
        var username = Request.Form["username"];
        var password = Request.Form["password"];
        if(username.ToString().ToLower() == "bingo" && password.ToString().ToLower() == "felix"){
            LoggedIn=true;
        }
        }
    }
}