using RegistroVentas_Entidades;
using System.ComponentModel.DataAnnotations;

namespace RegistroVentas_Web.Models
{
    public class VentaViewModel
    {
        /*
         * - Cliente: Hasta 50 caracteres. Campo requerido
            - Cantidad Vendida: Numérico, Campo Obligatorio. La cantidad vendida debe ser mayor a 1 y menor a 300. -
              Precio unitario: Numérico, campo obligatorio. El precio unitario debe ser mayor o igual a 10 y menor a 1000.
         * */

        public int IdVenta { get; set; }

        [Required(ErrorMessage ="el cliente es obligatorio")]
        [MaxLength(50,ErrorMessage ="la cantidad maxima de caracteres es 50")]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "la cantidad vendida es obligatorio")]
        [Range(1,300,ErrorMessage = "la cantidad vendida debe ser mayor a 1 y menor a 300")]
        public int CantidadVendida { get; set; }

        [Required(ErrorMessage = "la cantidad vendida es obligatorio")]
        [Range(9, 1000, ErrorMessage = "El precio unitario debe ser mayor o igual a 10 y menor a 1000")]
        public int PrecioUnitario { get; set; }

        public int TotalVenta { get; set; }

        public VentaViewModel() 
        { 
        }
        public VentaViewModel(Venta venta)
        {
            this.Cliente = venta.Cliente;
            this.CantidadVendida = venta.CantidadVendida;
            this.PrecioUnitario = venta.PrecioUnitario;
            this.TotalVenta = venta.TotalVenta;
            this.IdVenta = venta.IdVenta;
        }
        public static IList<VentaViewModel> ModelToModelView(IList<Venta> ventas) 
        {
            return ventas.Select(x => new VentaViewModel(x)).ToList();
        }

        public Venta ViewModelToModel()
        {
            return new Venta()
            {
                Cliente = this.Cliente,
                PrecioUnitario = this.PrecioUnitario,
                CantidadVendida = this.CantidadVendida,
            };
        }
    }
}
