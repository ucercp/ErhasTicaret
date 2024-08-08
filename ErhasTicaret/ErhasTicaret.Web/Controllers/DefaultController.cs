using Microsoft.AspNetCore.Mvc;

namespace ErhasTicaret.Web.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
