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
        

        public Dia(DateTime fecha)
        {
            _fechaD = fecha;
            _horasLuz = 12.5;
            _horasObscuro = 24 - 12.5;


        }


    }

    
}
