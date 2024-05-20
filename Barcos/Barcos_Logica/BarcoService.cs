using Barcos_Entidades;

namespace Barcos_Logica
{
    public class BarcoService : IBarcoService
    {
        private List<Barco> barcoList = new List<Barco>();

        public List<Barco> GetBarcos()
        {
            return this.barcoList;
        }

        public void Registrar(Barco barco)
        {
            barco.Tasa = this.ObtenerTasa(barco.Antiguedad, barco.TripulacionMaxima);
            barco.IdBarco = barcoList.Count > 0 ? barcoList.Max(x => x.IdBarco) + 1 : 1;
         
            barcoList.Add(barco);
        }

        private double ObtenerTasa(int antiguedad, int tripulacionMaxima) 
        {
            return (antiguedad * 0.10) + (tripulacionMaxima / 2);
        }
    }
}
