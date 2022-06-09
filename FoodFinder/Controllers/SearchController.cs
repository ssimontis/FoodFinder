using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodFinder.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SearchController : ControllerBase {
    private readonly ILogger<SearchController> _logger;

    public SearchController(ILogger<SearchController> logger)
    {
      _logger = logger;
    }
  }
}
