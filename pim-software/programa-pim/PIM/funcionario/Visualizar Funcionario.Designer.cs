namespace PIM
{
    partial class Visualizar_Funcionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DataGridViewFuncionario = new System.Windows.Forms.DataGridView();
            this.Tbxcodigopesquisa = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TbxCPFpesquisa = new System.Windows.Forms.MaskedTextBox();
            this.tbxnomepesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFuncionario)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnRemover
            // 
            this.BtnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemover.BackColor = System.Drawing.Color.Transparent;
            this.BtnRemover.BackgroundImage = global::PIM.Properties.Resources.BtnRemover;
            this.BtnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRemover.FlatAppearance.BorderSize = 0;
            this.BtnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemover.Location = new System.Drawing.Point(751, 507);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(228, 112);
            this.BtnRemover.TabIndex = 14;
            this.BtnRemover.UseVisualStyleBackColor = false;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdicionar.BackgroundImage = global::PIM.Properties.Resources.BtnAdicionar1;
            this.BtnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdicionar.FlatAppearance.BorderSize = 0;
            this.BtnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionar.Location = new System.Drawing.Point(751, 237);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(228, 112);
            this.BtnAdicionar.TabIndex = 12;
            this.BtnAdicionar.UseVisualStyleBackColor = false;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::PIM.Properties.Resources.PanelLista;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.DataGridViewFuncionario);
            this.panel4.Location = new System.Drawing.Point(26, 237);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 458);
            this.panel4.TabIndex = 11;
            // 
            // DataGridViewFuncionario
            // 
            this.DataGridViewFuncionario.AllowUserToAddRows = false;
            this.DataGridViewFuncionario.AllowUserToDeleteRows = false;
            this.DataGridViewFuncionario.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewFuncionario.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewFuncionario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewFuncionario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewFuncionario.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewFuncionario.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGridViewFuncionario.Location = new System.Drawing.Point(14, 3);
            this.DataGridViewFuncionario.Name = "DataGridViewFuncionario";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewFuncionario.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewFuncionario.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.DataGridViewFuncionario.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.DataGridViewFuncionario.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DataGridViewFuncionario.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridViewFuncionario.Size = new System.Drawing.Size(658, 452);
            this.DataGridViewFuncionario.TabIndex = 1;
            this.DataGridViewFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewFuncionario_CellContentClick);
            // 
            // Tbxcodigopesquisa
            // 
            this.Tbxcodigopesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbxcodigopesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbxcodigopesquisa.Location = new System.Drawing.Point(9, 10);
            this.Tbxcodigopesquisa.Name = "Tbxcodigopesquisa";
            this.Tbxcodigopesquisa.Size = new System.Drawing.Size(124, 24);
            this.Tbxcodigopesquisa.TabIndex = 1;
            this.Tbxcodigopesquisa.TextChanged += new System.EventHandler(this.Tbxcodigopesquisa_TextChanged);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnEditar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.BackgroundImage = global::PIM.Properties.Resources.BtnEditar;
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Location = new System.Drawing.Point(751, 371);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(228, 112);
            this.BtnEditar.TabIndex = 13;
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(164, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome:";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackgroundImage = global::PIM.Properties.Resources.TbxCidade;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.TbxCPFpesquisa);
            this.panel6.Location = new System.Drawing.Point(473, 54);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(211, 48);
            this.panel6.TabIndex = 4;
            // 
            // TbxCPFpesquisa
            // 
            this.TbxCPFpesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxCPFpesquisa.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxCPFpesquisa.Location = new System.Drawing.Point(2, 9);
            this.TbxCPFpesquisa.Mask = "000.000.000-00";
            this.TbxCPFpesquisa.Name = "TbxCPFpesquisa";
            this.TbxCPFpesquisa.Size = new System.Drawing.Size(203, 33);
            this.TbxCPFpesquisa.TabIndex = 15;
            this.TbxCPFpesquisa.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TbxCPFpesquisa_MaskInputRejected);
            // 
            // tbxnomepesquisa
            // 
            this.tbxnomepesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxnomepesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxnomepesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxnomepesquisa.Location = new System.Drawing.Point(6, 11);
            this.tbxnomepesquisa.Name = "tbxnomepesquisa";
            this.tbxnomepesquisa.Size = new System.Drawing.Size(279, 24);
            this.tbxnomepesquisa.TabIndex = 2;
            this.tbxnomepesquisa.TextChanged += new System.EventHandler(this.tbxnomepesquisa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Codigo:";
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::PIM.Properties.Resources.TbxCidade;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.Tbxcodigopesquisa);
            this.panel8.Location = new System.Drawing.Point(11, 56);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(145, 44);
            this.panel8.TabIndex = 6;
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPesquisa.BackgroundImage = global::PIM.Properties.Resources.BtnPesquisar;
            this.BtnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPesquisa.FlatAppearance.BorderSize = 0;
            this.BtnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisa.Location = new System.Drawing.Point(694, 14);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(229, 88);
            this.BtnPesquisa.TabIndex = 0;
            this.BtnPesquisa.UseVisualStyleBackColor = true;
            this.BtnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(470, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "CPF:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::PIM.Properties.Resources.PanelPesquisarBase12;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.BtnPesquisa);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(28, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(948, 112);
            this.panel3.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackgroundImage = global::PIM.Properties.Resources.TbxNome;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.tbxnomepesquisa);
            this.panel7.Location = new System.Drawing.Point(165, 55);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(297, 46);
            this.panel7.TabIndex = 5;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::PIM.Properties.Resources.Panel;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 86);
            this.panel1.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BackgroundImage = global::PIM.Properties.Resources.LOGO__1_;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Location = new System.Drawing.Point(28, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(245, 113);
            this.panel9.TabIndex = 18;
            // 
            // Visualizar_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PIM.Properties.Resources.Background1;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Visualizar_Funcionario";
            this.Text = "Visualizar_Funcionario";
            this.Load += new System.EventHandler(this.Visualizar_Funcionario_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewFuncionario)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Tbxcodigopesquisa;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbxnomepesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button BtnPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataGridViewFuncionario;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.MaskedTextBox TbxCPFpesquisa;
    }
}