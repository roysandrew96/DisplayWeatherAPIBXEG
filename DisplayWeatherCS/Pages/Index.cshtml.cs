using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DisplayWeatherCS.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        HttpClient httpClient = new HttpClient();
        
        var wf = new BxWeatherService(httpClient);
        
        wf.GetForecast();
    }
}