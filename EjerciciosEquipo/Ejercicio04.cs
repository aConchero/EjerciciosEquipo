using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosEquipo
{
    public partial class Ejercicio04 : Form
    {
        public Ejercicio04()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string resultado = "";
            for (int i = 0; i < texto.Length; i++)
            {
                resultado = texto[i] + resultado;
            }
            textBox2.Text = resultado;
        }
    }
}
