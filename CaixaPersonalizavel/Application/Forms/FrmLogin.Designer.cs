namespace CaixaPersonalizavel
{
    partial class frmLogin
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAcesso = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 298);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(789, 35);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAcesso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 122);
            this.panel1.TabIndex = 2;
            // 
            // btnAcesso
            // 
            this.btnAcesso.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAcesso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAcesso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcesso.BorderRadius = 7;
            this.btnAcesso.ButtonText = "Acessar";
            this.btnAcesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcesso.DisabledColor = System.Drawing.Color.Gray;
            this.btnAcesso.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAcesso.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAcesso.Iconimage")));
            this.btnAcesso.Iconimage_right = null;
            this.btnAcesso.Iconimage_right_Selected = null;
            this.btnAcesso.Iconimage_Selected = null;
            this.btnAcesso.IconMarginLeft = 0;
            this.btnAcesso.IconMarginRight = 0;
            this.btnAcesso.IconRightVisible = true;
            this.btnAcesso.IconRightZoom = 0D;
            this.btnAcesso.IconVisible = true;
            this.btnAcesso.IconZoom = 90D;
            this.btnAcesso.IsTab = false;
            this.btnAcesso.Location = new System.Drawing.Point(271, 47);
            this.btnAcesso.Name = "btnAcesso";
            this.btnAcesso.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAcesso.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAcesso.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAcesso.selected = false;
            this.btnAcesso.Size = new System.Drawing.Size(241, 48);
            this.btnAcesso.TabIndex = 3;
            this.btnAcesso.Text = "Acessar";
            this.btnAcesso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcesso.Textcolor = System.Drawing.Color.White;
            this.btnAcesso.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcesso.Click += new System.EventHandler(this.btnAcesso_Click);
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(271, 175);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(241, 42);
            this.bunifuMaterialTextbox1.TabIndex = 3;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(271, 238);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(241, 42);
            this.bunifuMaterialTextbox2.TabIndex = 4;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(268, 158);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 23);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Usuário";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(268, 221);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(64, 23);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "Senha";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 144);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CaixaPersonalizavel.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(307, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuSeparator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso ~ Caixa Personalizável";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAcesso;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

