using System;
using System.Windows.Forms;
//Amanda Morettini & Giovane Vitorio
namespace frmCalc
{
    public partial class frmTradicional : Form
    {   
        public frmTradicional()
        {
            InitializeComponent();
            lblVisor.Text = "0";
            
        }
        bool vLimpar = false;
        decimal vNumAnt;
        string vOperacao;
       
        private void btOperacao (object sender, EventArgs e)
        {
            
            vOperacao = ((Button)sender).Text;
            vNumAnt = decimal.Parse(lblVisor.Text);
            vLimpar = true;
        }
        private void btIgual_Click(object sender, EventArgs e)
        {
            decimal vNumAtual = decimal.Parse(lblVisor.Text);
 
            switch (vOperacao)

            {
                case "+":
                    {

                        lblVisor.Text = ( vNumAnt + vNumAtual ).ToString();
                        break;

                    }
                case "-":
                    {
                        lblVisor.Text = (vNumAnt - vNumAtual ).ToString();
                        break;
                    }
                case "*":
                    {
                        lblVisor.Text = ( vNumAnt * vNumAtual).ToString();
                        break;
                    }
                case "/":
                    {
                        if (vNumAtual == 0)
                        {
                            lblVisor.Text = "Não é possível dividir por zero";
                        }

                        else
                        {
                            lblVisor.Text = ( vNumAnt / vNumAtual).ToString();
                        }
                        break;
                    }
            }
}
        private void btNumero(object sender, EventArgs e)
        {
            string vNumero = ((Button)sender).Text;
            if (vLimpar)
            {
                lblVisor.Text = "";
                vLimpar = false;
            }

            if (lblVisor.Text == "0")
                lblVisor.Text = "";

            if (vNumero == "," && lblVisor.Text.IndexOf(',') == -1 || vNumero != ",")
            {
                lblVisor.Text += vNumero;

            }
            
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            lblVisor.Text = "";
            vOperacao = "";
        }


     /*  private void frmTradicional_KeyDown(object sender, KeyEventArgs e)
        {
            Button bot = new Button();

            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                bot.Text = e.KeyCode.ToString().Substring(1, 1);
                btNumero(bot, e);
                return;
            }
            else if ((e.KeyCode == Keys.Oemcomma))
            {
                bot.Text = ",";
                btNumero(bot, e);
                return;
            }

            string t = e.KeyCode.ToString();
            switch (e.KeyCode.ToString())
            {
                case "+": 
                    {
                        bot.Text = "+";
                        btOperacao(bot, e);
                        return;
                    }
                case "-":
                    {
                        bot.Text = "-";
                        btOperacao(bot, e);

                        return;
                    }
                case "*":
                    {
                        bot.Text = "*";
                        btOperacao(bot, e);
                        return;
                    }
                case "/":
                    {
                        bot.Text = "/";
                        btOperacao(bot, e);
                        return;
                    }

            }
           if (e.KeyCode == Keys.Enter)
            {
                btIgual_Click(bot, e);
            }
            if (e.KeyCode == Keys.Clear)
            {
                btIgual_Click(bot, e);
            }
            if (e.KeyCode == Keys.Delete)
            {
                btLimpar_Click(bot, e);
            }
            
        }
        */
        

        private void frmTradicional_Load(object sender, EventArgs e)
        {

        }

        private void btLimparAnterior_Click(object sender, EventArgs e)
        {
            if (lblVisor.Text.Length > 1)
            {
                lblVisor.Text = lblVisor.Text.Remove(lblVisor.Text.Length - 1);
            }
            else
            {
                lblVisor.Text = "";
            }
        }
    }
    }

