using Microsoft.AspNetCore.Mvc;
using PrimerParcial.Models;
using PrimerParcial_Model;
using PrimerParcial_Service;

namespace PrimerParcial.Controllers
{
    public class PañalesController : Controller
    {
        private ICalculadoraService calculadoraService;

        public PañalesController(ICalculadoraService calculadoraService)
        {
            this.calculadoraService = calculadoraService;
        }

        [HttpGet]
        public IActionResult Resultados()
        {
            return View(PañalViewModel.MapToModel(this.calculadoraService.ObtenerResultados()));
        }

        [HttpGet]
        public IActionResult Calculadora()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(PañalViewModel request)
        {
            if (!ModelState.IsValid)
            {
                return View("Calculadora");
            }
            this.calculadoraService.Calcular(PañalViewModel.MapToEntidad(request));

            return RedirectToAction("Resultados");

        }
    }
}
