using Microsoft.AspNetCore.Mvc;

namespace Horarios.Controllers
{
    public class ConsultarHorarios : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
