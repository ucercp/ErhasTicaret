using Microsoft.AspNetCore.Mvc;

namespace ErhasTicaret.Web.Controllers
{
    public class ProductListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
