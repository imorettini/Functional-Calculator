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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void tsmBotoes_Click(object sender, EventArgs e)

        {
            if (Application.OpenForms["frmBotao"] == null)
            {
                frmBotao calculadora = new frmBotao();
                calculadora.MdiParent = this;
                calculadora.Show();
            }
        }
          private void tsmRadial_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRadial"] == null)
            {
                frmRadial calculadora = new frmRadial();
                calculadora.MdiParent = this;
                calculadora.Show();
            }
        }

        private void tradicionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmTradicional"] == null)
            {
                frmTradicional calculadora = new frmTradicional();
                calculadora.MdiParent = this;
                calculadora.Show();
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
