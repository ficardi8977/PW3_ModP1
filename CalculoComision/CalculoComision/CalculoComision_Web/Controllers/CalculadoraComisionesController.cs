using Microsoft.AspNetCore.Mvc;
using CalculoComision_Logica;
using CalculoComision_Web.Models;

namespace CalculoComision_Web.Controllers
{
    public class CalculadoraComisionesController : Controller
    {
        private IComisionService ComisionService;
        public CalculadoraComisionesController(IComisionService ComisionService) 
        { 
            this.ComisionService = ComisionService;
        }

        [HttpGet]
        public IActionResult Calculadora()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(ComisionViewModel request)
        {
            if (!ModelState.IsValid) 
            {
                return View(nameof(Calculadora));
            }
            
            this.ComisionService.Calcular(ComisionViewModel.MapeoAEntidad(request));

            return RedirectToAction(nameof(Resultados));
        }

        [HttpGet]
        public IActionResult Resultados()
        {
            return View(ComisionViewModel.MapeoAModelo(this.ComisionService.GetComisiones()));
        }
    }
}
