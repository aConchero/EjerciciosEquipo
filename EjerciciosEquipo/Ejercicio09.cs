using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosEquipo
{
    public partial class Ejercicio09 : Form
    {
        public Ejercicio09()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] vector = textBox1.Text.Split(",");
            int menor = int.Parse(vector[0]);
            int num = 0;
            for (int i = 1; i < vector.Length; i++)
            {
                num = int.Parse(vector[i]);
                if (num < menor)
                {
                    menor = num;
                }
            }
            textBox2.Text = menor + " ";
        }
    }
}
