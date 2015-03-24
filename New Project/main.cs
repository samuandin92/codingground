using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatitoFluent2
{
    class Program
    {
        static void Main(string[] args)
        {
            GatoFluent gataFiera = new GatoFluent();

            gataFiera.nombreGato("Misifus")
                       .NoVidas(7)
                       .cantidadPeso(20);

            Console.WriteLine(gataFiera.gatito.nombreGato+" tiene "+
                                  gataFiera.gatito.vidas+" vidas y pesa "+
                                       gataFiera.gatito.peso+" lbs");
        }
    }
}
