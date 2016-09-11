using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionLamparas
{
    public partial class Bienvenida : Form
    {
        Handler hand;

        public Bienvenida()
        {
            InitializeComponent();

            initDatePicker.MinDate = System.DateTime.Now;
        }

        private void btnRunSimulation_Click(object sender, EventArgs e)
        {
            try
            {
                int yearsQty = Convert.ToInt16(txtYearQty.Text);
                int lampQty = Convert.ToInt16(txtLampQty.Text);
                DateTime initDate = initDatePicker.Value;

                if (yearsQty > 0)
                {
                    hand = new Handler(yearsQty, lampQty, initDate, rchResults);
                }
                else
                {
                    MessageBox.Show("Favor de simular 1 o mas años", "Simulacion");
                }

            }
            catch (Exception error)
            {

                MessageBox.Show("Favor de introducir numeros \n " + error.ToString(), "Error");
            }

            
        }
    }
}
