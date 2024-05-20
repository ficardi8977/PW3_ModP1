using Barcos_Logica;
using Barcos_web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Barcos_web.Controllers
{
    public class BarcosController : Controller
    {

        private IBarcoService barcoService;

        public BarcosController(IBarcoService barcoService)
        {
            this.barcoService = barcoService;   
        }

        [HttpGet]
        public ActionResult RegistrarBarco()
        {
            return View();
        }

        public ActionResult Registrar(BarcoViewModel request)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(RegistrarBarco));
            }
             
            this.barcoService.Registrar(BarcoViewModel.MapToEntity(request));

            return RedirectToAction(nameof(Resultados));
        }

        [HttpGet]
        public ActionResult Resultados()
        {
            return View(BarcoViewModel.MapToModel(this.barcoService.GetBarcos()));
        }
    }
}
