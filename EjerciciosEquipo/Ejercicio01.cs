using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosEquipo
{
    public partial class Ejercicio01 : Form
    {
        public Ejercicio01()
        {
            InitializeComponent();
        }

        private void Factorial_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            int resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado = i * resultado;
            }
            textBox2.Text = resultado.ToString();
        }
    }
}
