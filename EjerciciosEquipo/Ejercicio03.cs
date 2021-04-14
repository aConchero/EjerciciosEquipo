using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosEquipo
{
    public partial class Ejercicio03 : Form
    {
        public Ejercicio03()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dividendo = int.Parse(textBox1.Text);
            int divisor = int.Parse(textBox2.Text);
            int cociente = 0;
            int a = dividendo;
            while (a>=divisor) {
                a = a - divisor;
                cociente = cociente + 1;
            }
            textBox3.Text = cociente+"";
        }
    }
}
