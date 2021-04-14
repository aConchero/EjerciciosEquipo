using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosEquipo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejercicio01 ej1 = new Ejercicio01();
            ej1.Show();
            //this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ejercicio02 ej2 = new Ejercicio02();
            ej2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ejercicio03 ej3 = new Ejercicio03();
            ej3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ejercicio04 ej4 = new Ejercicio04();
            ej4.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Ejercicio05 ej5 = new Ejercicio05();
            ej5.Show();
        }

        /* private void button12_Click(object sender, EventArgs e)
         {

         }

         private void button13_Click(object sender, EventArgs e)
         {

         }

         private void button14_Click(object sender, EventArgs e)
         {
             Ejercicio08 ej8 = new Ejercicio08();
             ej8.Show();
         }

         private void button15_Click(object sender, EventArgs e)
         {
             Ejercicio09 ej9 = new Ejercicio09();
             ej9.Show();
         }

         private void button16_Click(object sender, EventArgs e)
         {
             Ejercicio10 ej10 = new Ejercicio10();
             ej10.Show();
         }

         private void button9_Click(object sender, EventArgs e)
         {

         }*/

        private void button12_Click_1(object sender, EventArgs e)
        {
            Ejercicio06 ej6 = new Ejercicio06();
            ej6.Show();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Ejercicio07 ej7 = new Ejercicio07();
            ej7.Show();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            Ejercicio08 ej8 = new Ejercicio08();
            ej8.Show();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            Ejercicio09 ej9 = new Ejercicio09();
            ej9.Show();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            Ejercicio10 ej10 = new Ejercicio10();
            ej10.Show();
        }
    }
}
