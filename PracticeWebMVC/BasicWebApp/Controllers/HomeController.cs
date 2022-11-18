namespace BasicWebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index([FromServices] Services.IInterest counter)
    {
            return View("Finance"); 
    }

    [HttpPost]
    public IActionResult Interest(double p, double r, int n,[FromServices] Services.IInterest counter)
    {
        double interest = counter.SimpleInterest(p, r, n);
        ViewBag.Interest = interest;

        return View("Result");
    }
}

