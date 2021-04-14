using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosEquipo
{
    public partial class Ejercicio08 : Form
    {
        public Ejercicio08()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(numero1.Text);
            int b = int.Parse(numero2.Text);
            int temporal = 0;             
            while (b != 0) {                 
                temporal = b;                 
                b = a % b;                 
                a = temporal;              
            }             
            resultado.Text = a + "";
            /*
            int a = Math.Max(n1, n2);
            int b = Math.Min(n1, n2);
            int resto;
            do
            {
                resto = b;
                b = a % b;
                a = resto;
            } while (b != 0);

            resultado.Text = "" + a;*/
        }
    }
}
