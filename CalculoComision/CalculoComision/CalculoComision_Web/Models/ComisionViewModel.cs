using CalculoComision_Entidades;
using System.ComponentModel.DataAnnotations;

namespace CalculoComision_Web.Models
{
    public class ComisionViewModel
    {
        /*
         * - Cliente: Hasta 50 caracteres. Campo requerido
            - Cantidad Vendida: Numérico, Campo Obligatorio. La cantidad vendida debe ser mayor a 1 y menor a 300. -
              Precio unitario: Numérico, campo obligatorio. El precio unitario debe ser mayor o igual a 10 y menor a 1000.
         * */

        public int IdCalculoComision { get; set; }


        [Required(ErrorMessage = "el capital es requerido")]
        public int Capital { get; set; }

        [Required(ErrorMessage = "el plazo es requerido")]
        [Range(1,36,ErrorMessage ="el plazo debe ser mayor a 0 y menor o igual a 36")]
        public int Plazo { get; set; }

        public int ComisionMensual { get; set; }

        public int Impuesto { get; set; }

        public int Incentivo { get; set; }


        public int Ganancia { get; set; }

        public ComisionViewModel() 
        { 
        }
        public ComisionViewModel(Comision comision)
        {
            this.IdCalculoComision = comision.IdCalculoComision;
            this.Capital = comision.Capital;
            this.Plazo = comision.Plazo;
            this.ComisionMensual = comision.ComisionMensual;
            this.Impuesto = comision.Impuesto;
            this.Incentivo = comision.Incentivo;
            this.Ganancia = comision.Ganancia;
        }
        public static IList<ComisionViewModel> MapeoAModelo(IList<Comision> comisiones) 
        {
            return comisiones.Select(x => new ComisionViewModel(x)).ToList();
        }

        public static Comision MapeoAEntidad(ComisionViewModel comisionViewModel)
        {
            return new Comision()
            {
                IdCalculoComision = comisionViewModel.IdCalculoComision,
                Capital = comisionViewModel.Capital,
                Plazo = comisionViewModel.Plazo,
                ComisionMensual = comisionViewModel.ComisionMensual,
                Impuesto = comisionViewModel.Impuesto,
                Incentivo = comisionViewModel.Incentivo,
                Ganancia = comisionViewModel.Ganancia
            };
        }
    }
}
