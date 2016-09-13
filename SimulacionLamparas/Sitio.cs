using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionLamparas
{
    class Sitio
    {
        static double _metrosCuadrados = 121957.56;

        private int _cantidadLamparas;
        public int CantidadLampras
        {
            get { return _cantidadLamparas; }
            set { _cantidadLamparas = value; }
        }

        
        public double MetrosCuadrardos
        {
            get { return _metrosCuadrados; }
           
        }

        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }

        }

        private double _consumo;
        public double Consumo
        {
            get { return _consumo; }
            set { _consumo = value; }
        }

        public Sitio()
        {

        }

    }
}
