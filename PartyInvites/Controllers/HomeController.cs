using Microsoft.AspNetCore.Mvc;


namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = System.DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ?
                "Good Morning" : "Good Afternoon";
            return View("MyView");
        }

        
    }
}
