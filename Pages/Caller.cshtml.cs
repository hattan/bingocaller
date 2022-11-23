using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BingoCaller.Pages
{
    public class CallerModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<IndexModel> _logger;
        public bool LoggedIn { get; set; }

        public CallerModel(ILogger<IndexModel> logger,IConfiguration configuration)
        {
            _logger = logger;
            _configuration=configuration;
            LoggedIn=false;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            string expectedUserName = _configuration["Login:Username"];
            string expectedPassword = _configuration["Login:Password"];

            var username = Request.Form["username"];
            var password = Request.Form["password"];

            // Not the best way to do this :D
            if (username.ToString().ToLower().Trim() == expectedUserName && password.ToString().ToLower() == expectedPassword)
            {
                LoggedIn = true;
            }
        }
    }
}