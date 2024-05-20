using Barcos_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcos_Logica
{
    public  interface IBarcoService
    {
        List<Barco> GetBarcos();

        void Registrar(Barco barco);

    }
}
