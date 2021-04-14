using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosEquipo
{
    public partial class Ejercicio07 : Form
    {
        public Ejercicio07()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] vector = textBox1.Text.Split(",");
            int multiplicar=1;
            int mult = 0;
            for ( int i=0; i< vector.Length; i++)
            {
                mult = int.Parse(vector[i]);
                multiplicar = multiplicar * mult;
            }
            textBox2.Text = multiplicar + " ";

        }
    }
}
