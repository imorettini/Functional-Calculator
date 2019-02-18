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
    public partial class frmRadial : Form
    {
        public frmRadial()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            decimal a, b, r;

            if (rdbAdicao.Checked)
            {
                a = decimal.Parse(txtPrimeiroNumero.Text);
                b = decimal.Parse(txtSegundoNumero.Text);
                lblResultado.Text = (a + b).ToString();
            }


            if (rdbSubtracao.Checked)
            {
                a = decimal.Parse(txtPrimeiroNumero.Text);
                b = decimal.Parse(txtSegundoNumero.Text);
                lblResultado.Text = (a - b).ToString();
            }

            if (rdbMultiplicacao.Checked)
            {
                a = decimal.Parse(txtPrimeiroNumero.Text);
                b = decimal.Parse(txtSegundoNumero.Text);
                lblResultado.Text = (a * b).ToString();
            }

            if (rdbDivisao.Checked)
            {

                a = decimal.Parse(txtPrimeiroNumero.Text);
                b = decimal.Parse(txtSegundoNumero.Text);
                lblResultado.Text = (a / b).ToString();
            }

            if (rdbComparacao.Checked)
            {
                a = decimal.Parse(txtPrimeiroNumero.Text);
                b = decimal.Parse(txtSegundoNumero.Text);

                if (a > b)
                {
                    lblResultado.Text = (a + " é maior que " + b).ToString();
                }
                else if (a < b)
                {
                    lblResultado.Text = (a + " é menor que " + b).ToString();
                }
                else if (a == b)
                {
                    lblResultado.Text = (a + " é igual a " + b).ToString();
                }

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

        
    
