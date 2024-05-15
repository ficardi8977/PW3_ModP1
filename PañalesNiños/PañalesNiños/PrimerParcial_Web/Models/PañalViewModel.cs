using PrimerParcial_Model;
using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Models
{
    public class PañalViewModel
    {
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }

        [Range(0, 5, ErrorMessage = "la edad debe ser entre 0 y 5")]
        public int Edad { get; set; }

        [Range(1, 20, ErrorMessage = "El peso debe ser entre 1 y 20")]
        public float Peso { get; set; }

        public string? Tamaño { get; set; }

        public PañalViewModel()
        {
        }

        public PañalViewModel(Pañal c)
        {
            this.Nombre = c.Nombre;
            this.Edad = c.Edad;
            this.Tamaño = c.Tamaño;
            this.Peso = c.Peso;
        }

        public static List<PañalViewModel> MapToModel(List<Pañal> calculadoras)
        {
            return calculadoras.Select(f => new PañalViewModel(f)).ToList();
        }

        public static Pañal MapToEntidad(PañalViewModel viewModel) 
        {
            return new Pañal()
            {
                Nombre = viewModel.Nombre,
                Edad = viewModel.Edad,
                Peso = viewModel.Peso,
                Tamaño = viewModel.Tamaño
            };
        }
    }
}
