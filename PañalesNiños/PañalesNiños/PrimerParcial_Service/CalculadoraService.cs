using PrimerParcial_Model;

namespace PrimerParcial_Service
{
    public class CalculadoraService : ICalculadoraService
    {
        /*private List<Pañal> calculadoraList = new List<Pañal>()
            {
                new Pañal{ Nombre="Emma", Edad = 2, Peso = 2, Tamaño = "RN"},
                new Pañal{ Nombre="Ciro", Edad = 2, Peso = 11, Tamaño = "G"},
                new Pañal { Nombre = "Pedro", Edad = 2, Peso = 15, Tamaño = "XG" }
            };
        */
        private List<Pañal> calculadoraList = new List<Pañal>();

        public void Calcular(Pañal calculadora)
        {
            switch (calculadora.Peso)
            {
                case <=3:
                    calculadora.Tamaño =  "RN";
                    break;
                case < 5:
                    calculadora.Tamaño = "XS";
                    break;
                case < 7:
                    calculadora.Tamaño = "S";
                    break;
                case < 9:
                    calculadora.Tamaño = "M";
                    break;
                case < 12:
                    calculadora.Tamaño = "G";
                    break;
                case <= 15:
                    calculadora.Tamaño = "XG";
                    break;
                default:
                    calculadora.Tamaño = "XXG";
                    break;
            }
            this.calculadoraList.Add(calculadora);
        }

        public List<Pañal> ObtenerResultados()
        {
            return this.calculadoraList;
        }
    }
}
