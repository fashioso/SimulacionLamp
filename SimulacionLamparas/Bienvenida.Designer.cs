namespace SimulacionLamparas
{
    partial class Bienvenida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtYearQty = new System.Windows.Forms.TextBox();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblLampQty = new System.Windows.Forms.Label();
            this.txtLampQty = new System.Windows.Forms.TextBox();
            this.btnRunSimulation = new System.Windows.Forms.Button();
            this.rchResults = new System.Windows.Forms.RichTextBox();
            this.txtResults = new System.Windows.Forms.Label();
            this.initDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblInitDate = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYearQty
            // 
            this.txtYearQty.Location = new System.Drawing.Point(32, 47);
            this.txtYearQty.Name = "txtYearQty";
            this.txtYearQty.Size = new System.Drawing.Size(114, 20);
            this.txtYearQty.TabIndex = 0;
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(29, 31);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(75, 13);
            this.lblYears.TabIndex = 1;
            this.lblYears.Text = "Años a simular";
            // 
            // lblLampQty
            // 
            this.lblLampQty.AutoSize = true;
            this.lblLampQty.Location = new System.Drawing.Point(162, 31);
            this.lblLampQty.Name = "lblLampQty";
            this.lblLampQty.Size = new System.Drawing.Size(109, 13);
            this.lblLampQty.TabIndex = 3;
            this.lblLampQty.Text = "Cantidad de lamparas";
            // 
            // txtLampQty
            // 
            this.txtLampQty.Location = new System.Drawing.Point(165, 47);
            this.txtLampQty.Name = "txtLampQty";
            this.txtLampQty.Size = new System.Drawing.Size(114, 20);
            this.txtLampQty.TabIndex = 2;
            // 
            // btnRunSimulation
            // 
            this.btnRunSimulation.Location = new System.Drawing.Point(859, 198);
            this.btnRunSimulation.Name = "btnRunSimulation";
            this.btnRunSimulation.Size = new System.Drawing.Size(75, 23);
            this.btnRunSimulation.TabIndex = 4;
            this.btnRunSimulation.Text = "Correr";
            this.btnRunSimulation.UseVisualStyleBackColor = true;
            this.btnRunSimulation.Click += new System.EventHandler(this.btnRunSimulation_Click);
            // 
            // rchResults
            // 
            this.rchResults.Location = new System.Drawing.Point(32, 104);
            this.rchResults.Name = "rchResults";
            this.rchResults.Size = new System.Drawing.Size(783, 159);
            this.rchResults.TabIndex = 5;
            this.rchResults.Text = "";
            // 
            // txtResults
            // 
            this.txtResults.AutoSize = true;
            this.txtResults.Location = new System.Drawing.Point(29, 88);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(60, 13);
            this.txtResults.TabIndex = 6;
            this.txtResults.Text = "Resultados";
            // 
            // initDatePicker
            // 
            this.initDatePicker.Location = new System.Drawing.Point(315, 47);
            this.initDatePicker.Name = "initDatePicker";
            this.initDatePicker.Size = new System.Drawing.Size(200, 20);
            this.initDatePicker.TabIndex = 7;
            // 
            // lblInitDate
            // 
            this.lblInitDate.AutoSize = true;
            this.lblInitDate.Location = new System.Drawing.Point(312, 31);
            this.lblInitDate.Name = "lblInitDate";
            this.lblInitDate.Size = new System.Drawing.Size(67, 13);
            this.lblInitDate.TabIndex = 8;
            this.lblInitDate.Text = "Fecha Inicial";
            // 
            // time
            // 
            this.time.Enabled = true;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(570, 542);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(52, 28);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(431, 629);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(52, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(307, 564);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(419, 477);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(156, 692);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(156, 577);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 268);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 540);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 120;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(859, 228);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 842);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblInitDate);
            this.Controls.Add(this.initDatePicker);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.rchResults);
            this.Controls.Add(this.btnRunSimulation);
            this.Controls.Add(this.lblLampQty);
            this.Controls.Add(this.txtLampQty);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.txtYearQty);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Bienvenida";
            this.Text = "Simulacion-Bienvenido";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYearQty;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblLampQty;
        private System.Windows.Forms.TextBox txtLampQty;
        private System.Windows.Forms.Button btnRunSimulation;
        private System.Windows.Forms.RichTextBox rchResults;
        private System.Windows.Forms.Label txtResults;
        private System.Windows.Forms.DateTimePicker initDatePicker;
        private System.Windows.Forms.Label lblInitDate;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClear;
    }
}

