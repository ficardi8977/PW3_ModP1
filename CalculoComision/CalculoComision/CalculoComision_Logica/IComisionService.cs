using CalculoComision_Entidades;

namespace CalculoComision_Logica
{
    public interface IComisionService
    {
        IList<Comision> GetComisiones();

        void Calcular(Comision comision);
    }
}
