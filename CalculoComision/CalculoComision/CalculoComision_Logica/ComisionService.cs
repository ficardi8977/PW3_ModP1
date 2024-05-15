using CalculoComision_Entidades;

namespace CalculoComision_Logica
{
    public class ComisionService : IComisionService
    {
        private IList<Comision> comisionList = new List<Comision>();

        public IList<Comision> GetComisiones()
        {
            return comisionList;
        }

        public void Calcular(Comision comision)
        {

            calcularPorPlazo(comision);

            comision.Ganancia = (comision.Capital * comision.Plazo * comision.ComisionMensual / 100) + comision.Incentivo - comision.Impuesto;

            comision.IdCalculoComision = comisionList.Count() > 0 ? comisionList.Max(x => x.IdCalculoComision) + 1 : 1;

            comisionList.Add(comision);
        }
        private void calcularPorPlazo(Comision comision) 
        {
            switch (comision.Plazo)
            {
                case < 5:
                    comision.ComisionMensual = 5;
                    break;
                case < 18:
                    comision.ComisionMensual = 7;
                    comision.Incentivo = 1000;
                    break;
                case < 36:
                    comision.ComisionMensual = 10;
                    comision.Impuesto = 1000;
                    break;
            }
         }
    }
}
