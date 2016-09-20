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

            Image IMG = Image.FromFile(@"C:\Users\Dav\Desktop\Escuela 2016-2\Simulacion\Proyecto\Programacion\SimulacionLamparas\SimulacionLamp\SimulacionLamparas\Resources\lamp.png");
            pictureBox2.Image = IMG;
            pictureBox3.Image = IMG;
            pictureBox4.Image = IMG;
            pictureBox5.Image = IMG;
            pictureBox6.Image = IMG;
            pictureBox7.Image = IMG;
            
            initDatePicker.MinDate = System.DateTime.Now;
            pictureBox1.Image = Image.FromFile(@"C:\Users\Dav\Desktop\Escuela 2016-2\Simulacion\Proyecto\Programacion\SimulacionLamparas\SimulacionLamp\SimulacionLamparas\Resources\ITN2015-1.png");

        }

        private void btnRunSimulation_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Start();
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
                timer1.Start();
            }
            catch (Exception error)
            {

                MessageBox.Show("Favor de introducir numeros \n " + error.ToString(), "Error");
            }

            
        }
        int opacity = 0;

        public void tmrFadeOut(PictureBox p1, Timer t1)
        {
            if (opacity < 255)
            {
                Image img = p1.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                p1.Image = img;
                opacity++;

            }
            else
            {

                Image img = p1.Image;
                using (Graphics g = Graphics.FromImage(img))
                {
                    Pen pen = new Pen(Color.FromArgb(opacity, 255, 255, 255), img.Width);
                    g.DrawLine(pen, -1, -1, img.Width, img.Height);
                    g.Save();
                }
                p1.Image = img;
                opacity--;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tmrFadeOut(pictureBox2, timer1);
            tmrFadeOut(pictureBox3, timer1);
            tmrFadeOut(pictureBox4, timer1);
            tmrFadeOut(pictureBox5, timer1);
            tmrFadeOut(pictureBox6, timer1);
            tmrFadeOut(pictureBox7, timer1);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Image IMG = Image.FromFile(@"C:\Users\Dav\Desktop\Escuela 2016-2\Simulacion\Proyecto\Programacion\SimulacionLamparas\SimulacionLamp\SimulacionLamparas\Resources\lamp.png");
            pictureBox2.Image = IMG;
            pictureBox3.Image = IMG;
            pictureBox4.Image = IMG;
            pictureBox5.Image = IMG;
            pictureBox6.Image = IMG;
            pictureBox7.Image = IMG;




        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rchResults.Clear();
        }
    }
}
