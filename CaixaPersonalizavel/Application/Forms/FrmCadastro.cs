using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaPersonalizavel.Application.Forms
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FrmCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((Keys)e.KeyChar)
            {
                case Keys.Escape:
                    var frmPrincipal = new FrmPrincipal();
                    frmPrincipal.Show();

                    this.Hide();
                    break;
                case Keys.F4:
                    Environment.Exit(0);
                    break;
            }
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();

            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
