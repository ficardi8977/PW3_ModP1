using Microsoft.AspNetCore.Mvc;
using PrimerParcial.Models;
using System.Diagnostics;

namespace PrimerParcial.Controllers
{
    public class PrincipalController : Controller
    { 

        public IActionResult Inicio()
        {
            return View();
        }
    }
}
