using Microsoft.AspNetCore.Mvc;
using Windsor.Services;

namespace Windsor.Controllers;

public class HomeController : Controller
{
    public IActionResult Index([FromServices] INameService service)
    {
        var name = service.GetName();

        return View((object)name);
    }
}
