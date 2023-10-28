using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMCcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura;
            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);

            double resultado = peso / (altura * altura);
            txtIMC.Text= resultado.ToString();

            if (resultado <= 18.5)
            {
                lblTabela.Text = "Abaixo do peso";
            }
            else if (resultado >= 18.6 && resultado <= 24.9)
            {
                lblTabela.Text = "Peso ideal";
            }
            else if (resultado >= 25 && resultado <= 29.9)
            {
                lblTabela.Text = "Levemente acima do peso";
            }
            else if (resultado >= 30 && resultado <= 34.9)
            {
                lblTabela.Text = "Obesidade grau 1";
            }
            else if (resultado >= 35 && resultado <= 39.9)
            {
                lblTabela.Text = "Obesidade grau 2 (severa)";
            }
            else if (resultado >= 40)
            {
                lblTabela.Text = "Obesidade grau 3 (mórbida)";
            }
            else
            {
                
            }



        }
    }
}
