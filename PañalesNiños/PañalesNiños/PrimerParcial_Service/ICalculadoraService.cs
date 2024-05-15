using PrimerParcial_Model;

namespace PrimerParcial_Service
{
    public interface ICalculadoraService
    {
        List<Pañal> ObtenerResultados();

        void Calcular(Pañal calculadora);
    }
}
