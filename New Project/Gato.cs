using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatitoFluent2
{
    class Gato
    {
        private string _nombreGato;
        public string nombreGato
        {
            get { return _nombreGato; }
            set { _nombreGato = value; }
        }
        private int _vidas;
        public int vidas
        {
            get { return _vidas; }
            set { _vidas = value; }
        }
        private int _peso;
        public int peso
        {
            get { return _peso; }
            set { _peso = value; }
        }
    }
}
