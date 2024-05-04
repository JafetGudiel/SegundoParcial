namespace CuotasDePrestamo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Monto = new System.Windows.Forms.TextBox();
            this.Plazos = new System.Windows.Forms.TextBox();
            this.Interes = new System.Windows.Forms.TextBox();
            this.Cuota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.MostrarIntereses = new System.Windows.Forms.TextBox();
            this.TotalPagar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Century", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(191, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuotas de un Prestamo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el interes mensual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(43, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto del prestamo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(12, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de plazos a pagar";
            // 
            // Monto
            // 
            this.Monto.BackColor = System.Drawing.SystemColors.InfoText;
            this.Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monto.ForeColor = System.Drawing.Color.Cyan;
            this.Monto.Location = new System.Drawing.Point(416, 95);
            this.Monto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(165, 41);
            this.Monto.TabIndex = 4;
            // 
            // Plazos
            // 
            this.Plazos.BackColor = System.Drawing.SystemColors.InfoText;
            this.Plazos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plazos.ForeColor = System.Drawing.Color.Cyan;
            this.Plazos.Location = new System.Drawing.Point(416, 196);
            this.Plazos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Plazos.Name = "Plazos";
            this.Plazos.Size = new System.Drawing.Size(165, 41);
            this.Plazos.TabIndex = 5;
            // 
            // Interes
            // 
            this.Interes.BackColor = System.Drawing.SystemColors.InfoText;
            this.Interes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interes.ForeColor = System.Drawing.Color.Cyan;
            this.Interes.Location = new System.Drawing.Point(416, 145);
            this.Interes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Interes.Name = "Interes";
            this.Interes.Size = new System.Drawing.Size(165, 41);
            this.Interes.TabIndex = 6;
            // 
            // Cuota
            // 
            this.Cuota.BackColor = System.Drawing.SystemColors.InfoText;
            this.Cuota.Enabled = false;
            this.Cuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cuota.ForeColor = System.Drawing.Color.Cyan;
            this.Cuota.Location = new System.Drawing.Point(49, 374);
            this.Cuota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cuota.Name = "Cuota";
            this.Cuota.Size = new System.Drawing.Size(165, 41);
            this.Cuota.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(28, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cuota Mensual";
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcular.ForeColor = System.Drawing.Color.Cyan;
            this.Calcular.Location = new System.Drawing.Point(599, 124);
            this.Calcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(189, 84);
            this.Calcular.TabIndex = 9;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = false;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // MostrarIntereses
            // 
            this.MostrarIntereses.BackColor = System.Drawing.SystemColors.InfoText;
            this.MostrarIntereses.Enabled = false;
            this.MostrarIntereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarIntereses.ForeColor = System.Drawing.Color.Cyan;
            this.MostrarIntereses.Location = new System.Drawing.Point(318, 374);
            this.MostrarIntereses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MostrarIntereses.Name = "MostrarIntereses";
            this.MostrarIntereses.Size = new System.Drawing.Size(165, 41);
            this.MostrarIntereses.TabIndex = 10;
            // 
            // TotalPagar
            // 
            this.TotalPagar.BackColor = System.Drawing.SystemColors.InfoText;
            this.TotalPagar.Enabled = false;
            this.TotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPagar.ForeColor = System.Drawing.Color.Cyan;
            this.TotalPagar.Location = new System.Drawing.Point(565, 374);
            this.TotalPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TotalPagar.Name = "TotalPagar";
            this.TotalPagar.Size = new System.Drawing.Size(165, 41);
            this.TotalPagar.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(267, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total de intereses";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Century", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(547, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 33);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total a pagar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalPagar);
            this.Controls.Add(this.MostrarIntereses);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cuota);
            this.Controls.Add(this.Interes);
            this.Controls.Add(this.Plazos);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Monto;
        private System.Windows.Forms.TextBox Plazos;
        private System.Windows.Forms.TextBox Interes;
        private System.Windows.Forms.TextBox Cuota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.TextBox MostrarIntereses;
        private System.Windows.Forms.TextBox TotalPagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

