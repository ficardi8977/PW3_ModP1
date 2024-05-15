using Microsoft.AspNetCore.Mvc;

namespace RegistroVentas_Web.Controllers
{
    public class PresentacionController : Controller
    {
        public PresentacionController()
        {
        }

        public IActionResult Bienvenido()
        {
            return View();
        }
    }
}
