using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionLamparas
{

    class Dia
    {
        static int horas = 24;
        int estacion;

        double[] maxTemps = { 18, 20, 22, 26, 31, 35, 35, 33, 33, 28, 23, 18 }; 
        double[] minTemps = { -2, -1, 1, 4, 8, 13, 18, 18, 14, 7, 1, -3 };


        DateTime _fechaD;
        public DateTime FechaD
        {
            get { return this._fechaD; }
            set { this._fechaD = value; }
        }

        double _minTemperatura;
        public double MinTemperatura
        {
            get { return this._minTemperatura; }
            set { this._minTemperatura = value; }
        }

        double _maxTemperatura;
        public double MaxTemperatura
        {
            get { return this._maxTemperatura; }
            set { this._maxTemperatura = value; }
        }

        double _horasObscuro;
        public double HorasObscuro
        {
            get { return this._horasObscuro; }
            set { _horasObscuro = value; }
        }

        double _horasLuz;
        public double HorasLuz
        {
            get { return this._horasObscuro; }
            set { _horasLuz = value; }
        }
        

        public Dia(DateTime fecha) //, double menor, double mayor)
        {
            Random maxr = new Random();
            Random minr = new Random();
            int month = fecha.Month;

            
                _maxTemperatura = maxr.Next(Convert.ToInt16(minTemps[month - 1]), Convert.ToInt16(maxTemps[month - 1]));
                _minTemperatura = minr.Next(Convert.ToInt16(minTemps[month - 1]), Convert.ToInt16(minTemps[month - 1]));
            


            _fechaD = fecha;
            _horasLuz = 12.5;
            _horasObscuro = 24 - 12.5;

            


        }


    }

    
}
