using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionLamparas
{

    class Handler
    {

        int years = 0;
        DateTime initdate;
        int lamparas = 0;
        DateTime fechaFinal;
        Dia[] diasSimular;
        double numDiasSimular;

        Sitio itn = new Sitio();

        Dia actualDay ;

        public Handler(int years, int lamparas, DateTime fecha, RichTextBox rchResults)
        {
            fechaFinal = fecha.AddYears(years);
            initdate = fecha;
            numDiasSimular = (fechaFinal - fecha).TotalDays;
            diasSimular = new Dia[Convert.ToInt16(numDiasSimular)];

            itn.Nombre = "Instituto Tecnologico de Nogales";
            itn.CantidadLampras = lamparas;

            rchResults.AppendText(Environment.NewLine + "Nombre: " + itn.Nombre);

            for (int dia = 0; dia < numDiasSimular; dia++)
            {
           
                diasSimular[dia] = new Dia(fecha); //, menor, mayor);
                rchResults.AppendText(Environment.NewLine + "Dia " + diasSimular[dia].FechaD.ToShortDateString() + " con Horas de Luz" + diasSimular[dia].HorasLuz.ToString() + " MinTemperature = " + diasSimular[dia].MinTemperatura + " Max Temp = " + diasSimular[dia].MaxTemperatura);
                fecha = fecha.AddDays(1);
                //diasSimular[dia].
                //System.Console.Write("Es el dia " + dia.ToString());


            }


        }


    }
}
