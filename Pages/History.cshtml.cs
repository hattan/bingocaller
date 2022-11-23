using Microsoft.AspNetCore.Mvc.RazorPages;
using BingoCaller.Data;

namespace BingoCaller.Pages
{
    public class HistoryModel : PageModel
    {
        private readonly ICounter _counter;
        private readonly ILogger<IndexModel> _logger;
        public List<Number> Numbers;

        public HistoryModel(ILogger<IndexModel> logger,IConfiguration configuration,ICounter counter)
        {
            _logger = logger;
            _counter = counter;
            Numbers = _counter.Get();
        }

    }
}