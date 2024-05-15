using RegistroVentas_Entidades;

namespace RegistroVentas_Logica
{
    public class VentasService : IVentaService
    {
        private IList<Venta> ventaList = new List<Venta>() { 
            new Venta() {IdVenta=1, Cliente = "Metagoles S.A", CantidadVendida= 250, PrecioUnitario = 20, TotalVenta = 5000 },
            new Venta() {IdVenta=2, Cliente = "MediaLunas SRL", CantidadVendida= 100, PrecioUnitario = 10, TotalVenta = 1000 },
            new Venta() {IdVenta=3, Cliente = "Teclieando S.A", CantidadVendida= 20, PrecioUnitario = 200, TotalVenta = 4000 },
        };  
        public IList<Venta> GetVentas()
        {
            return ventaList;
        }

        public void AddVenta(Venta venta)
        {
            venta.TotalVenta = venta.CantidadVendida * venta.PrecioUnitario;
            venta.IdVenta = ventaList.Max(x => x.IdVenta) + 1;
            ventaList.Add(venta);
        }

    }
}
