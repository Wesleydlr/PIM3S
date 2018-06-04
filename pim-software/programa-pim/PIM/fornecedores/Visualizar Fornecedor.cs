using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PIM.fornecedores
{
    public partial class Visualizar_Fornecedor : Form
    {
        public Visualizar_Fornecedor()
        {
            InitializeComponent();
        }

        private int id_fornecedor;

        private string nome, cnpj;

        private void label4_Click(object sender, EventArgs e)
        {

        }


        public void alterarnomesDtagridview()
        {
            /*
            DtaGridFornecedor.Columns[0].HeaderText = "ID Fornecedor";
            DtaGridFornecedor.Columns[1].HeaderText = "Empresa/Nome";
            DtaGridFornecedor.Columns[2].HeaderText = "CNPJ";
            DtaGridFornecedor.Columns[3].HeaderText = "Categoria";
            DtaGridFornecedor.Columns[4].HeaderText = "ID Produto";
            DtaGridFornecedor.Columns[5].HeaderText = "E-Mail";
            DtaGridFornecedor.Columns[6].HeaderText = "Rua";
            DtaGridFornecedor.Columns[7].HeaderText = "N°";
            DtaGridFornecedor.Columns[8].HeaderText = "Bairro";
            DtaGridFornecedor.Columns[9].HeaderText = "Cidade";
            DtaGridFornecedor.Columns[10].HeaderText = "Estado";
            DtaGridFornecedor.Columns[11].HeaderText = "CEP da Sede";
            DtaGridFornecedor.Columns[12].HeaderText = "Descrição";
            */
        }



        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Cadastrar_Fornecedor cadastrarFornecedor = new Cadastrar_Fornecedor();
            cadastrarFornecedor.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();
                DAOFornecedor daofornecedor = new DAOFornecedor();
                conn.Open();

                DtaGridFornecedor.DataSource = daofornecedor.PesquisarGeral();
                alterarnomesDtagridview();

                if (tbxnomepesquisa.Text != String.Empty)
                {
                    daofornecedor.PesquisarPorNome(nome);
                    alterarnomesDtagridview();
                }
               
                if(TbxCNPJpesquisa.Text != String.Empty)
                {
                    daofornecedor.PesquisarPorCnpj(cnpj);
                    alterarnomesDtagridview();
                }

                if(Tbxcodigopesquisa.Text != String.Empty)
                {
                    daofornecedor.PesquisarPorID(id_fornecedor);
                    alterarnomesDtagridview();
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro:" + ex.ToString());
            }
        }

        private void DtaGridFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            alterarnomesDtagridview();


        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            DAOFornecedor fornecedor = new DAOFornecedor();
            fornecedor.excluirID(id_fornecedor);

        }

        private void Tbxcodigopesquisa_TextChanged(object sender, EventArgs e)
        {
            id_fornecedor = Convert.ToInt32(Tbxcodigopesquisa.Text);

        }

        private void TbxCNPJpesquisa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DtaGridFornecedor_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TbxCNPJpesquisa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            cnpj = TbxCNPJpesquisa.Mask;
        }

        private void Visualizar_Fornecedor_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DAOFornecedor daofornecedor = new DAOFornecedor();
            conn.Open();

            DtaGridFornecedor.DataSource = daofornecedor.PesquisarGeral();
            alterarnomesDtagridview();
            conn.Close();
        }

        private void tbxnomepesquisa_TextChanged(object sender, EventArgs e)
        {
            nome = tbxnomepesquisa.Text;

        }
    }
}
