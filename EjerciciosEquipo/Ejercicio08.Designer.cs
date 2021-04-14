
namespace EjerciciosEquipo
{
    partial class Ejercicio08
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
            this.numero1 = new System.Windows.Forms.TextBox();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(238, 78);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(191, 23);
            this.numero1.TabIndex = 0;
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(238, 129);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(191, 23);
            this.numero2.TabIndex = 1;
            // 
            // resultado
            // 
            this.resultado.Enabled = false;
            this.resultado.Location = new System.Drawing.Point(238, 242);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(191, 23);
            this.resultado.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejercicio08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Name = "Ejercicio08";
            this.Text = "Calcular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button button1;
    }
}