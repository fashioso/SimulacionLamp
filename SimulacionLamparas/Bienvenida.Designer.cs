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
            this.txtYearQty = new System.Windows.Forms.TextBox();
            this.lblYears = new System.Windows.Forms.Label();
            this.lblLampQty = new System.Windows.Forms.Label();
            this.txtLampQty = new System.Windows.Forms.TextBox();
            this.btnRunSimulation = new System.Windows.Forms.Button();
            this.rchResults = new System.Windows.Forms.RichTextBox();
            this.txtResults = new System.Windows.Forms.Label();
            this.initDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblInitDate = new System.Windows.Forms.Label();
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
            this.btnRunSimulation.Location = new System.Drawing.Point(675, 409);
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
            this.rchResults.Size = new System.Drawing.Size(718, 275);
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
            // Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 444);
            this.Controls.Add(this.lblInitDate);
            this.Controls.Add(this.initDatePicker);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.rchResults);
            this.Controls.Add(this.btnRunSimulation);
            this.Controls.Add(this.lblLampQty);
            this.Controls.Add(this.txtLampQty);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.txtYearQty);
            this.Name = "Bienvenida";
            this.Text = "Simulacion-Bienvenido";
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
    }
}

