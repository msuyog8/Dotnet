namespace BasicWebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index( [FromServices] Services.IInterest counter)
    {
        //ViewBag.GuestName = id ?? "Visitor";
        counter.SimpleInterest(10,20,30);
       
            return View("Finance"); //renders /Views/Greeter/Welcome.cshtml
        
    }
}

