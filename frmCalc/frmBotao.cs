using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCalc
{
    public partial class frmBotao : Form
    {
        public frmBotao()
        {
            InitializeComponent();
        }

        private void txtPrimeiroNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSegundoNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            decimal a, b;

            a = decimal.Parse(txtPrimeiroNumero.Text);
            b = decimal.Parse(txtSegundoNumero.Text);
            lblResultado.Text = (a + b).ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            decimal a, b;

            a = decimal.Parse(txtPrimeiroNumero.Text);
            b = decimal.Parse(txtSegundoNumero.Text);
            lblResultado.Text = (a * b).ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            decimal a, b;

            a = decimal.Parse(txtPrimeiroNumero.Text);
            b = decimal.Parse(txtSegundoNumero.Text);
            lblResultado.Text = (a - b).ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            decimal a, b;

            a = decimal.Parse(txtPrimeiroNumero.Text);
            b = decimal.Parse(txtSegundoNumero.Text);
            lblResultado.Text = (a / b).ToString();
        }

        private void btnComparacao_Click(object sender, EventArgs e)
        {
            decimal a, b;

            a = decimal.Parse(txtPrimeiroNumero.Text);
            b = decimal.Parse(txtSegundoNumero.Text);

            if (a > b)
            {
                lblResultado.Text = (a + " é maior que " + b).ToString();
            }
            else if(a < b)
            {
                lblResultado.Text = (a + " é menor que " + b).ToString();
            }
            else if (a == b)
            {
                lblResultado.Text = (a + " é igual a " + b).ToString();
            }
        }

        private void btnParImpar_Click(object sender, EventArgs e)
        {
            decimal a, b , r;

            a = decimal.Parse(txtPrimeiroNumero.Text);
            b = decimal.Parse(txtSegundoNumero.Text);
            r = a + b;           

            if (r % 2 == 0)
            {
                lblResultado.Text = (r + " é um numero par").ToString();
               
            }
            else
            {
                lblResultado.Text = (r + " é um numero impar").ToString();
               
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            txtPrimeiroNumero.Text = "";
            txtSegundoNumero.Text = "";
        }
    }
}
