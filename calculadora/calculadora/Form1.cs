using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        string salida = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salida += "1";
            lblSalida.Text = salida;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            salida += "2";
            lblSalida.Text = salida;
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            salida += "+";
            lblSalida.Text = salida;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (salida.Contains("+"))
            {
                string[] array = salida.Split('+');
                double numero1 = Double.Parse(array[0]);
                double numero2 = Double.Parse(array[1]);
                double resultado = numero1 + numero2;
                lblSalida.Text = ""+resultado;
            }
            if (salida.Contains("-"))
            {
                string[] array = salida.Split('-');
                double numero1 = Double.Parse(array[0]);
                double numero2 = Double.Parse(array[1]);
                double resultado = numero1 - numero2;
                lblSalida.Text = "" + resultado;
            }
            if (salida.Contains("x"))
            {
                string[] array = salida.Split('x');
                double numero1 = Double.Parse(array[0]);
                double numero2 = Double.Parse(array[1]);
                double resultado = numero1 * numero2;
                lblSalida.Text = "" + resultado;

            }
            if (salida.Contains("/"))
            {
                string[] array = salida.Split('/');
                double numero1 = Double.Parse(array[0]);
                double numero2 = Double.Parse(array[1]);
                double resultado = numero1 / numero2;
                lblSalida.Text = "" + resultado;
            }
            salida = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblSalida.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            salida += "8";
            lblSalida.Text = salida;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            salida += "3";
            lblSalida.Text = salida;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            salida += "4";
            lblSalida.Text = salida;

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            salida += "5";
            lblSalida.Text = salida;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            salida += "6";
            lblSalida.Text = salida;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            salida += "7";
            lblSalida.Text = salida;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            salida += "9";
            lblSalida.Text = salida;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            salida += "0";
            lblSalida.Text = salida;
        }

        private void lblSalida_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            salida += " -";
            lblSalida.Text = salida;
        }

        private void btnmultipli_Click(object sender, EventArgs e)
        {
            salida += " x";
            lblSalida.Text = salida;
        }

        private void btndivi_Click(object sender, EventArgs e)
        {
            salida += " /";
            lblSalida.Text = salida;
        }
    }
}
