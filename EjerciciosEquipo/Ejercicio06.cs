using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosEquipo
{
    public partial class Ejercicio06 : Form
    {
        public Ejercicio06()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] vector = textBox1.Text.Split(',');
            int suma = 0;
            for(int i = 0; i < vector.Length; i++)
            {
                int valor = int.Parse(vector[i]);
                suma = suma + valor;
            }
            textBox2.Text = suma+ "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
