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

        Dia actualDay ;

        public Handler(int years, int lamparas, DateTime fecha, RichTextBox rchResults)
        {
            fechaFinal = fecha.AddYears(years);
            initdate = fecha;
            numDiasSimular = (fechaFinal - fecha).TotalDays;
            diasSimular = new Dia[Convert.ToInt16(numDiasSimular)];

            for (int dia = 0; dia < numDiasSimular; dia++)
            {

                diasSimular[dia] = new Dia(fecha);
                rchResults.AppendText(Environment.NewLine + "Dia " + diasSimular[dia].FechaD.ToShortDateString() + " con Horas de Luz" + diasSimular[dia].HorasLuz.ToString() );
                fecha = fecha.AddDays(1);

                System.Console.Write("Es el dia " + dia.ToString());


            }


        }


    }
}
