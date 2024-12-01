using System.Diagnostics;
using Horarios.Models;
using Microsoft.AspNetCore.Mvc;

namespace Horarios.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Cargando la vista principal (Index).");
            return View();
        }

        public IActionResult ConsultarHorarios()
        {
            _logger.LogInformation("Redirigiendo a la vista de horarios.");
            return View("Horarios");
        }

        public IActionResult Reservar()
        {
            _logger.LogInformation("Cargando la vista de reservaciones.");
            return View("Reservar");
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Cargando la vista de privacidad.");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
