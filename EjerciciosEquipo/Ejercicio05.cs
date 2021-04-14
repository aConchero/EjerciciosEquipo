using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosEquipo
{
    public partial class Ejercicio05 : Form
    {
        public Ejercicio05()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            int resultado = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                resultado = int.Parse(texto[i] + "") + resultado;
            }
            
            textBox2.Text = resultado.ToString();
        }
    }
}
