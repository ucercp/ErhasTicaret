using Microsoft.AspNetCore.Mvc;

namespace ErhasTicaret.Web.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
