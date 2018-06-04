using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PIM
{
    public partial class MenuPrincipal : Form

    {

        public MenuPrincipal()
        {
            InitializeComponent();       
        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
            {
                Visualizar_Funcionario visualizarFuncionario = new Visualizar_Funcionario();
                visualizarFuncionario.Show();
                this.Close();
            //visualizarFuncionario.mostraResultados();
            }

            private void btnSair_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void btnRealizarVenda_Click(object sender, EventArgs e)
            {
                Teladevendas vendas = new Teladevendas();
                vendas.Show();
                this.Close();
            }

            private void btnClientes_Click(object sender, EventArgs e)
            {
                VisualizarClientesCadastrados clientesCadastrados = new VisualizarClientesCadastrados();
                clientesCadastrados.Show();
                this.Close();
            }

            private void btnFornecedores_Click(object sender, EventArgs e)
            {
                fornecedores.Visualizar_Fornecedor visualizarFornecedor = new fornecedores.Visualizar_Fornecedor();
                
                visualizarFornecedor.alterarnomesDtagridview();
            visualizarFornecedor.Show();
            this.Close();
            }

            private void btnEstoque_Click(object sender, EventArgs e)
            {
                Produto.Visualizar_Produtos visualizarProdutos = new Produto.Visualizar_Produtos();
                visualizarProdutos.Show();
                this.Close();
            }

        private void BtnRelatoriodeVendas_Click(object sender, EventArgs e)
        {
            RelatorioDeVendas relatorio = new RelatorioDeVendas();
            relatorio.ShowDialog();
            this.Close();
        }
    }
    }