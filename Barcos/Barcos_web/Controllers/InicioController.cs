using Barcos_web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Barcos_web.Controllers
{
    public class InicioController : Controller
    {

        public InicioController()
        {
        }

        public IActionResult Bienvenida()
        {
            return View();
        }
    }
}
