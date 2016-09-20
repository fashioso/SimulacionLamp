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
            int day = fecha.DayOfYear;
            int dayHour = fecha.TimeOfDay.Hours;
            double x;
            int h = 12;
            double y;
            double delta;
            x = 2 * Math.PI * (day - 1 - (h - 12) / 24) / 365;

            //Ecuacion de la declinacion solar
            delta = (0.006918 - 0.399912 * Math.Cos(x) + 0.070257 * Math.Sin(x) - 0.006758 * Math.Cos(2 * x)
            + 0.000907 * Math.Sin(2 * x) - 0.002697 * Math.Cos(3 * x) + 0.001480 * Math.Sin(3 * x)) * 180 / Math.PI;

            //Ecuacion Tiempo
            y = 229.18 * (0.00075 + 0.001868 * Math.Cos(x) - 0.032077 * Math.Sin(x) - 0.014615 * Math.Cos(2 * x) - 0.040849 * Math.Sin(2 * x));

            double time_offset = (y - 4 * (-110.942100) + 60 * (3.8)) / 60;

            _maxTemperatura = maxr.Next(Convert.ToInt16(minTemps[month - 1]), Convert.ToInt16(maxTemps[month - 1]));
            _minTemperatura = minr.Next(Convert.ToInt16(minTemps[month - 1]), Convert.ToInt16(minTemps[month - 1]));

            
            _fechaD = fecha;
            _horasLuz = time_offset;
            _horasObscuro = 24 - _horasLuz;
            
        }


    }

    
}
