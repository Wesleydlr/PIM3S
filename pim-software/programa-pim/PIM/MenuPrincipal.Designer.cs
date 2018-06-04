namespace PIM
{
    partial class MenuPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.BtnFuncionarios = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnRealizarVenda = new System.Windows.Forms.Button();
            this.BtnRelatoriodeVendas = new System.Windows.Forms.Button();
            this.BtnRelatorioGanhos = new System.Windows.Forms.Button();
            this.BtnRelatorioGastos = new System.Windows.Forms.Button();
            this.BtnAjuda = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::PIM.Properties.Resources.Panel;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 86);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::PIM.Properties.Resources.LOGO__1_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(28, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 113);
            this.panel3.TabIndex = 18;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackgroundImage = global::PIM.Properties.Resources.BtnSair1;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Location = new System.Drawing.Point(792, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(176, 62);
            this.btnSair.TabIndex = 1;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // BtnFuncionarios
            // 
            this.BtnFuncionarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.BtnFuncionarios.BackgroundImage = global::PIM.Properties.Resources.btnFuncionarios;
            this.BtnFuncionarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFuncionarios.FlatAppearance.BorderSize = 0;
            this.BtnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFuncionarios.Location = new System.Drawing.Point(31, 127);
            this.BtnFuncionarios.Name = "BtnFuncionarios";
            this.BtnFuncionarios.Size = new System.Drawing.Size(312, 121);
            this.BtnFuncionarios.TabIndex = 1;
            this.BtnFuncionarios.UseVisualStyleBackColor = false;
            this.BtnFuncionarios.Click += new System.EventHandler(this.BtnFuncionarios_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFornecedores.BackColor = System.Drawing.Color.Transparent;
            this.btnFornecedores.BackgroundImage = global::PIM.Properties.Resources.btnFornecedores;
            this.btnFornecedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFornecedores.FlatAppearance.BorderSize = 0;
            this.btnFornecedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedores.Location = new System.Drawing.Point(354, 128);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(316, 121);
            this.btnFornecedores.TabIndex = 2;
            this.btnFornecedores.UseVisualStyleBackColor = false;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackgroundImage = global::PIM.Properties.Resources.btnClientes;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Location = new System.Drawing.Point(681, 128);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(310, 121);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEstoque.BackColor = System.Drawing.Color.Transparent;
            this.btnEstoque.BackgroundImage = global::PIM.Properties.Resources.btnClientes;
            this.btnEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Image = global::PIM.Properties.Resources.BtnEstoque;
            this.btnEstoque.Location = new System.Drawing.Point(30, 294);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(310, 121);
            this.btnEstoque.TabIndex = 4;
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnRealizarVenda
            // 
            this.btnRealizarVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRealizarVenda.BackColor = System.Drawing.Color.Transparent;
            this.btnRealizarVenda.BackgroundImage = global::PIM.Properties.Resources.btnClientes;
            this.btnRealizarVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRealizarVenda.FlatAppearance.BorderSize = 0;
            this.btnRealizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarVenda.Image = global::PIM.Properties.Resources.BtnVendas;
            this.btnRealizarVenda.Location = new System.Drawing.Point(680, 295);
            this.btnRealizarVenda.Name = "btnRealizarVenda";
            this.btnRealizarVenda.Size = new System.Drawing.Size(309, 121);
            this.btnRealizarVenda.TabIndex = 5;
            this.btnRealizarVenda.UseVisualStyleBackColor = false;
            this.btnRealizarVenda.Click += new System.EventHandler(this.btnRealizarVenda_Click);
            // 
            // BtnRelatoriodeVendas
            // 
            this.BtnRelatoriodeVendas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRelatoriodeVendas.BackColor = System.Drawing.Color.Transparent;
            this.BtnRelatoriodeVendas.BackgroundImage = global::PIM.Properties.Resources.btnClientes;
            this.BtnRelatoriodeVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRelatoriodeVendas.FlatAppearance.BorderSize = 0;
            this.BtnRelatoriodeVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelatoriodeVendas.Image = global::PIM.Properties.Resources.BtnRelatorioVendas;
            this.BtnRelatoriodeVendas.Location = new System.Drawing.Point(31, 463);
            this.BtnRelatoriodeVendas.Name = "BtnRelatoriodeVendas";
            this.BtnRelatoriodeVendas.Size = new System.Drawing.Size(310, 121);
            this.BtnRelatoriodeVendas.TabIndex = 6;
            this.BtnRelatoriodeVendas.UseVisualStyleBackColor = false;
            this.BtnRelatoriodeVendas.Click += new System.EventHandler(this.BtnRelatoriodeVendas_Click);
            // 
            // BtnRelatorioGanhos
            // 
            this.BtnRelatorioGanhos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRelatorioGanhos.BackColor = System.Drawing.Color.Transparent;
            this.BtnRelatorioGanhos.BackgroundImage = global::PIM.Properties.Resources.btnClientes;
            this.BtnRelatorioGanhos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRelatorioGanhos.FlatAppearance.BorderSize = 0;
            this.BtnRelatorioGanhos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelatorioGanhos.Image = global::PIM.Properties.Resources.BtnRelatorioGanhos;
            this.BtnRelatorioGanhos.Location = new System.Drawing.Point(355, 463);
            this.BtnRelatorioGanhos.Name = "BtnRelatorioGanhos";
            this.BtnRelatorioGanhos.Size = new System.Drawing.Size(310, 121);
            this.BtnRelatorioGanhos.TabIndex = 7;
            this.BtnRelatorioGanhos.UseVisualStyleBackColor = false;
            // 
            // BtnRelatorioGastos
            // 
            this.BtnRelatorioGastos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRelatorioGastos.BackColor = System.Drawing.Color.Transparent;
            this.BtnRelatorioGastos.BackgroundImage = global::PIM.Properties.Resources.btnClientes;
            this.BtnRelatorioGastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRelatorioGastos.FlatAppearance.BorderSize = 0;
            this.BtnRelatorioGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelatorioGastos.Image = global::PIM.Properties.Resources.BtnRelatorioGastos;
            this.BtnRelatorioGastos.Location = new System.Drawing.Point(679, 463);
            this.BtnRelatorioGastos.Name = "BtnRelatorioGastos";
            this.BtnRelatorioGastos.Size = new System.Drawing.Size(310, 121);
            this.BtnRelatorioGastos.TabIndex = 8;
            this.BtnRelatorioGastos.UseVisualStyleBackColor = false;
            // 
            // BtnAjuda
            // 
            this.BtnAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAjuda.BackColor = System.Drawing.Color.Transparent;
            this.BtnAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAjuda.FlatAppearance.BorderSize = 0;
            this.BtnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAjuda.Image = global::PIM.Properties.Resources.btnAjuda;
            this.BtnAjuda.Location = new System.Drawing.Point(931, 649);
            this.BtnAjuda.Name = "BtnAjuda";
            this.BtnAjuda.Size = new System.Drawing.Size(61, 61);
            this.BtnAjuda.TabIndex = 9;
            this.BtnAjuda.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::PIM.Properties.Resources.LOGO__1_;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(382, 308);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 113);
            this.panel5.TabIndex = 18;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::PIM.Properties.Resources.Fundo;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.BtnAjuda);
            this.Controls.Add(this.BtnRelatorioGastos);
            this.Controls.Add(this.BtnRelatorioGanhos);
            this.Controls.Add(this.BtnRelatoriodeVendas);
            this.Controls.Add(this.btnRealizarVenda);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnFornecedores);
            this.Controls.Add(this.BtnFuncionarios);
            this.Controls.Add(this.panel1);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button BtnFuncionarios;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnRealizarVenda;
        private System.Windows.Forms.Button BtnRelatoriodeVendas;
        private System.Windows.Forms.Button BtnRelatorioGanhos;
        private System.Windows.Forms.Button BtnRelatorioGastos;
        private System.Windows.Forms.Button BtnAjuda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
    }
}

