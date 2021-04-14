using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosEquipo
{
    public partial class Ejercicio02 : Form
    {
        public Ejercicio02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bases = int.Parse(textBox1.Text);
            int exponente = int.Parse(textBox2.Text);
            int potencia;
            potencia = (int)Math.Pow(bases, exponente);
            textBox3.Text = potencia + "";

        }
    }
}
