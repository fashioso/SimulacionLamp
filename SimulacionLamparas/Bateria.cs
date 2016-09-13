using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionLamparas
{
    class Bateria
    {
        private double _capacidad;
        public double Capacidad
        {
            get { return _capacidad;  }
            set { _capacidad = value; }
        }

        private double _energiaTotal;
        public double EnergiaTotal
        {
            get { return _energiaTotal; }
            set { _energiaTotal = value; }
        }

    }
}
