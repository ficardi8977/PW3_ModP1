using RegistroVentas_Entidades;

namespace RegistroVentas_Logica
{
    public interface IVentaService
    {
        IList<Venta> GetVentas();

        void AddVenta(Venta venta);

    }
}
