using Microsoft.AspNetCore.Mvc;

namespace Horarios.Controllers
{
    public class ReservarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
