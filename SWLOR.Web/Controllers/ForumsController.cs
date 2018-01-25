using Microsoft.AspNetCore.Mvc;

namespace SWLOR.Web.Controllers
{
    public class ForumsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}