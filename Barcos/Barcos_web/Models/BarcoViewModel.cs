using Barcos_Entidades;
using System.ComponentModel.DataAnnotations;

namespace Barcos_web.Models
{
    public class BarcoViewModel
    {
        public int IdBarco { get; set; }

        [Required(ErrorMessage ="El campo nombre es obligatorio") ]
        [MaxLength(20,ErrorMessage ="El nombre no puede exceder los 20 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Antiguedad es obligatorio")]
        [Range(1, 199, ErrorMessage = "El rango de antiguedad debe ser mayor a 0 y menor a 200")]
        public int Antiguedad { get; set; }


        [Required(ErrorMessage = "El campo TripulacionMaxima es obligatorio")]
        [Range(1, 499, ErrorMessage = "El rango de la tripulacion maxima debe ser mayor o igual a 1 y menor a 500")]
        public int TripulacionMaxima { get; set; }

        public double Tasa { get; set; }

        public BarcoViewModel() { }

        public BarcoViewModel(Barco barco) 
        {
            this.IdBarco = barco.IdBarco;
            this.Nombre = barco.Nombre; 
            this.TripulacionMaxima = barco.TripulacionMaxima;
            this.Antiguedad = barco.Antiguedad;
            this.Tasa = barco.Tasa;
        }


        // mapeos 
        public static List<BarcoViewModel> MapToModel(List<Barco> barcos)
        {
            return barcos.Select(x => new BarcoViewModel(x)).ToList();
        }

        public static Barco MapToEntity(BarcoViewModel barcoModel)
        {
            return new Barco()
            {
                IdBarco = barcoModel.IdBarco,
                Nombre = barcoModel.Nombre,
                TripulacionMaxima = barcoModel.TripulacionMaxima,
                Antiguedad = barcoModel.Antiguedad,
                Tasa = barcoModel.Tasa,
            };
        }    
        
        

    }
}
