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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int temporal = 0;
            while (b != 0) {
                temporal = b;
                b = a % b;
                a = temporal;

            }
            textBox3.Text = a + "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
