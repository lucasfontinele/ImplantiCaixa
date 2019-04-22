namespace CaixaPersonalizavel.Application.UserControls
{
    partial class FrmSemVariacao
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSemVariacao));
            this.topPanel = new System.Windows.Forms.Panel();
            this.txtPesquisa = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnPesquisa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvProdutos = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigobarras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.btnPesquisa);
            this.topPanel.Controls.Add(this.txtPesquisa);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1328, 100);
            this.topPanel.TabIndex = 1;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.txtPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPesquisa.BackgroundImage")));
            this.txtPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtPesquisa.Icon = ((System.Drawing.Image)(resources.GetObject("txtPesquisa.Icon")));
            this.txtPesquisa.Location = new System.Drawing.Point(453, 29);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(404, 42);
            this.txtPesquisa.TabIndex = 5;
            this.txtPesquisa.text = "";
            this.txtPesquisa.Load += new System.EventHandler(this.txtPesquisa_Load);
            this.txtPesquisa.Enter += new System.EventHandler(this.txtPesquisa_Enter);
            this.txtPesquisa.Leave += new System.EventHandler(this.txtPesquisa_Leave);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisa.BorderRadius = 0;
            this.btnPesquisa.ButtonText = "Pesquisar";
            this.btnPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisa.DisabledColor = System.Drawing.Color.Gray;
            this.btnPesquisa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPesquisa.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.Iconimage")));
            this.btnPesquisa.Iconimage_right = null;
            this.btnPesquisa.Iconimage_right_Selected = null;
            this.btnPesquisa.Iconimage_Selected = null;
            this.btnPesquisa.IconMarginLeft = 0;
            this.btnPesquisa.IconMarginRight = 0;
            this.btnPesquisa.IconRightVisible = true;
            this.btnPesquisa.IconRightZoom = 0D;
            this.btnPesquisa.IconVisible = true;
            this.btnPesquisa.IconZoom = 90D;
            this.btnPesquisa.IsTab = false;
            this.btnPesquisa.Location = new System.Drawing.Point(920, 29);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPesquisa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPesquisa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPesquisa.selected = false;
            this.btnPesquisa.Size = new System.Drawing.Size(206, 42);
            this.btnPesquisa.TabIndex = 2;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisa.Textcolor = System.Drawing.Color.White;
            this.btnPesquisa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvProdutos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1328, 585);
            this.panel1.TabIndex = 2;
            // 
            // lvProdutos
            // 
            this.lvProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.descricao,
            this.codigobarras});
            this.lvProdutos.GridLines = true;
            this.lvProdutos.Location = new System.Drawing.Point(15, 16);
            this.lvProdutos.MultiSelect = false;
            this.lvProdutos.Name = "lvProdutos";
            this.lvProdutos.Size = new System.Drawing.Size(1293, 551);
            this.lvProdutos.TabIndex = 1;
            this.lvProdutos.UseCompatibleStateImageBehavior = false;
            this.lvProdutos.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id";
            this.id.Width = 300;
            // 
            // descricao
            // 
            this.descricao.Text = "Descrição";
            this.descricao.Width = 300;
            // 
            // codigobarras
            // 
            this.codigobarras.Text = "Código de Barras";
            this.codigobarras.Width = 300;
            // 
            // FrmSemVariacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.Name = "FrmSemVariacao";
            this.Size = new System.Drawing.Size(1328, 685);
            this.topPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private Bunifu.Framework.UI.BunifuTextbox txtPesquisa;
        private Bunifu.Framework.UI.BunifuFlatButton btnPesquisa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvProdutos;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader descricao;
        private System.Windows.Forms.ColumnHeader codigobarras;
    }
}
