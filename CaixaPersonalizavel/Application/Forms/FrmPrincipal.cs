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
    public partial class FrmPrincipal : Form
    {
        private FrmCadastro frmCadastro;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.frmCadastro = new FrmCadastro();
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            CadastroProduto();
        }

        public void CadastroProduto()
        {
            switch (MessageBox.Show("O produto possui variações?", "Caixa Personalizável Informa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1))
            {
                case DialogResult.Yes:
                    MessageBox.Show("Segue");
                    break;
                case DialogResult.No:
                    frmCadastro.ShowDialog();
                    break;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
