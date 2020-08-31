namespace ConversionEscalasTemperatura
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btnconvertir = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnconvertirkelvin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversión de escalas de temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la temperatura en grados centígrados:";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(585, 92);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 26);
            this.txtvalor.TabIndex = 2;
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(27, 268);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(144, 105);
            this.btnconvertir.TabIndex = 3;
            this.btnconvertir.Text = "Convertir a F";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(22, 376);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(276, 29);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "Resultado en Fahrenheit";
            this.lblresultado.Visible = false;
            // 
            // btnconvertirkelvin
            // 
            this.btnconvertirkelvin.Location = new System.Drawing.Point(27, 143);
            this.btnconvertirkelvin.Name = "btnconvertirkelvin";
            this.btnconvertirkelvin.Size = new System.Drawing.Size(144, 105);
            this.btnconvertirkelvin.TabIndex = 5;
            this.btnconvertirkelvin.Text = "Convertir a K";
            this.btnconvertirkelvin.UseVisualStyleBackColor = true;
            this.btnconvertirkelvin.Click += new System.EventHandler(this.btnconvertirkelvin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.btnconvertirkelvin);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnconvertir);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnconvertirkelvin;
    }
}

