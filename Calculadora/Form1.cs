using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text =  txtResultado.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "3";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "4";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "5";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + ".";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if(operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2); 
            } else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            } else if (operacao == "MULTI") 
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            } else if (operacao == "DIV") 
            
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            txtResultado.Text = "";
            operacao = "SUB";
            lblOperacao.Text = "-";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            txtResultado.Text = "";
            operacao = "MULTI";
            lblOperacao.Text = "x";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            txtResultado.Text = "";
            operacao = "DIV";
            lblOperacao.Text = "/";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor2 = 0;
            valor1 = 0;
            lblOperacao.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            } else
            {
                MessageBox.Show("Informe um valor para efetuar a soma.");
            }

        }
    }
}
