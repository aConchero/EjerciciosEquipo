using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosEquipo
{
    public partial class Ejercicio10 : Form
    {
        public Ejercicio10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] vector = textBox1.Text.Split(",");
            int mayor = int.Parse(vector[0]);
            int num = 0;
            for (int i = 1; i < vector.Length; i++)
            {
                num = int.Parse(vector[i]);
                if ( num > mayor)
                {
                    mayor = num;
                }    
            }
            textBox2.Text = mayor + " ";
        }
    }
}
