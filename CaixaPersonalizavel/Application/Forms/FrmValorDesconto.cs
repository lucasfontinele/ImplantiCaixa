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
    public partial class FrmValorDesconto : Form
    {
        public FrmValorDesconto()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Existem mais produtos a serem cadastrados?", "Caixa Personalizável Informa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
            {
                case DialogResult.Yes:
                    CadastroProdutos();
                    break;
                case DialogResult.No:

                    break;
            }
        }

        private void CadastroProdutos()
        {
            var frmPrincipal = new FrmPrincipal();
           
            frmPrincipal.CadastroProduto();
            this.Hide();
        }
    }
}
