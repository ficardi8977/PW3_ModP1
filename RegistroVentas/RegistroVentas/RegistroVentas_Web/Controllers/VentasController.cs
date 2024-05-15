using Microsoft.AspNetCore.Mvc;
using RegistroVentas_Logica;
using RegistroVentas_Web.Models;

namespace RegistroVentas_Web.Controllers
{
    public class VentasController : Controller
    {
        private IVentaService ventaService;
        public VentasController(IVentaService ventaService) 
        { 
            this.ventaService = ventaService;
        }

        [HttpGet]
        public IActionResult RegistrarVenta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(VentaViewModel request)
        {
            if (!ModelState.IsValid) 
            {
                return View();
            }
            
            this.ventaService.AddVenta(request.ViewModelToModel());

            return RedirectToAction(nameof(Resultados));
        }

        [HttpGet]
        public IActionResult Resultados()
        {
            return View(VentaViewModel.ModelToModelView(this.ventaService.GetVentas()));
        }
    }
}
