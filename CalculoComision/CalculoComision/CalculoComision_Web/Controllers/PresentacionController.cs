using Microsoft.AspNetCore.Mvc;

namespace CalculoComision_Web.Controllers
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
