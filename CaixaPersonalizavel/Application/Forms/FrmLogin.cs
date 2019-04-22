using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaixaPersonalizavel.Application.Forms;

namespace CaixaPersonalizavel
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            FrmPrincipal frm = new FrmPrincipal();
            frm.Show();            

            this.Hide();
        }
    }
}
