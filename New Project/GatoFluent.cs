using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatitoFluent2
{
    class GatoFluent
    {
        public Gato gatito = new Gato();
        
        public GatoFluent nombreGato(string Nombre)
        {
            gatito.nombreGato = Nombre;
            return this;
        }
        public GatoFluent NoVidas(int vidas)
        {
            gatito.vidas = vidas;
            return this;
        }
        public void cantidadPeso(int peso)
        {
            gatito.peso = peso;
        }

        public Gato getGato() { return this.gatito; }

    }
}
