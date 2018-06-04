using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.Produto
{
    public partial class Visualizar_Produtos : Form
    {
        private int id_produto;
        private String nome, categoria;

        public Visualizar_Produtos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Produto.Cadastrar_Produto cadastrarProduto = new Produto.Cadastrar_Produto();
            cadastrarProduto.Show();
            this.Close();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            DAOProduto daoproduto = new DAOProduto();

            daoproduto.excluirID(id_produto);
        }

        public void alterarnomesDtagridview()
        {

        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
           


            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DAOProduto daoproduto = new DAOProduto();

            DtaGridProduto.DataSource = daoproduto.Pesquisa_Geral();



            //daofornecedor.PesquisarPorID(id_fornecedor);


            if (tbxnomepesquisa.Text != string.Empty)
            {
                DtaGridProduto.DataSource = daoproduto.PesquisarPorNome(tbxnomepesquisa.Text);
                alterarnomesDtagridview();
            }
            else
            {

                DtaGridProduto.DataSource = daoproduto.Pesquisa_Geral();
                alterarnomesDtagridview();
            }


            if (ComBoxTipoProcura.Text == "Valor")
            {
                DtaGridProduto.DataSource = daoproduto.Pesquisa_Geral();
                alterarnomesDtagridview();
            }
            else
            {

                DtaGridProduto.DataSource = daoproduto.Pesquisa_Geral();
                alterarnomesDtagridview();
            }
            conn.Close();


        }


        private void ComBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoria = Convert.ToString(ComBoxCategoria.Text);
        }

        private void ComBoxTipoProcura_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (ComBoxCategoria.Text == null)
            {
                ComBoxTipoProcura.Enabled = false;
            }
        }

        private void DtaGridProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Visualizar_Produtos_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DAOProduto daoproduto = new DAOProduto();
            conn.Open();
            DtaGridProduto.DataSource = daoproduto.Pesquisa_Geral();
            alterarnomesDtagridview();
            conn.Close();
        }

        private void tbxnomepesquisa_TextChanged(object sender, EventArgs e)
        {
            nome = tbxnomepesquisa.Text;

        }
    }
}

