using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaixaPersonalizavel.Application.Connection;
using CaixaPersonalizavel.Application.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CaixaPersonalizavel.Application.UserControls
{
    public partial class FrmSemVariacao : UserControl
    {
        private BsonDocument Filter;
        private IMongoDatabase _database;
        private IMongoCollection<BsonDocument> collection;
        public List<BsonDocument> DataList;

        public FrmSemVariacao()
        {
            InitializeComponent();            
            _database = Database.MongoConnection().GetDatabase("DigisatServer");
            collection = _database.GetCollection<BsonDocument>("ProdutosServicos");
        }

        private void txtPesquisa_Enter(object sender, EventArgs e)
        {
            txtPesquisa.Text = "";
        }

        private void txtPesquisa_Leave(object sender, EventArgs e)
        {
            txtPesquisa.Text = "Digite a descrição, código de barras do produto ou código interno.";
        }

        private void txtPesquisa_Load(object sender, EventArgs e)
        {
            txtPesquisa.Text = "Digite a descrição, código de barras do produto ou código interno.";
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            btnPesquisa.Enabled = false;
                
            Filter = new BsonDocument().Add("InformacoesPesquisa", new BsonRegularExpression($".*{txtPesquisa.Text}.*", "i"));
            var result = Task.Factory.StartNew(() => collection.Find(Filter).ToList());           

            result.ContinueWith(x =>
            {
                DataList = x.Result;

                foreach (var obj in x.Result)
                {
                    ListViewItem lvItem = new ListViewItem(new String[] { obj["_id"].ToString(), obj["Descricao"].ToString(), obj["CodigoBarras"].ToString() });
                    lvItem.Tag = obj;

                    lvProdutos.Items.Add(lvItem);
                }                                

                btnPesquisa.Enabled = true;
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void lvProdutos_Click(object sender, EventArgs e)
        {
            if (lvProdutos.SelectedItems.Count > 0)
            {
                ListViewItem item = lvProdutos.SelectedItems[0];

                switch (MessageBox.Show("O produto tem desconto ou acréscimo?", "Caixa Personalizável Informa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
                {
                    case DialogResult.Yes:
                        ValorDescontoPorcentagem();
                        break;
                    case DialogResult.No:

                        break;
                }
            }
        }

        private void ValorDescontoPorcentagem()
        {
            var frmDesconto = new FrmValorDesconto();

            frmDesconto.Show();
            this.Hide();
        }           
    }
}
