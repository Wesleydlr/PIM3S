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
using MySql.Data;
using PIM;
using System.Data.SqlClient;

namespace PIM
{
    public partial class Visualizar_Funcionario : Form
    {

        Funcionarios funcionario = new Funcionarios();
        public long id;
        private String nome_func, cpf;
        public string cod;

        Endereços endereço = new Endereços();

        Telefone telefone = new Telefone();

        public Visualizar_Funcionario()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Cadastrar_Funcionario cadastrar = new Cadastrar_Funcionario();
            cadastrar.ShowDialog();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }



        public void alterarnomesDtagridview()
        {
            
            DataGridViewFuncionario.Columns[0].HeaderText = "ID Funcionario";
            DataGridViewFuncionario.Columns[0].DataPropertyName = "id_funcionario";
            DataGridViewFuncionario.Columns[1].HeaderText = "Nome";
            DataGridViewFuncionario.Columns[1].DataPropertyName = "nome";
            DataGridViewFuncionario.Columns[2].HeaderText = "RG";
            DataGridViewFuncionario.Columns[2].DataPropertyName = "RG";
            DataGridViewFuncionario.Columns[3].HeaderText = "CPF";
            DataGridViewFuncionario.Columns[3].DataPropertyName = "CPF_CNPJ";
            DataGridViewFuncionario.Columns[4].HeaderText = "CTPS";
            DataGridViewFuncionario.Columns[4].DataPropertyName = "CTPS";
            DataGridViewFuncionario.Columns[5].HeaderText = "Data de Nascimento";
            DataGridViewFuncionario.Columns[5].DataPropertyName = "Dta_nasc";
            DataGridViewFuncionario.Columns[6].HeaderText = "Sexo";
            DataGridViewFuncionario.Columns[6].DataPropertyName = "sexo";
            DataGridViewFuncionario.Columns[7].HeaderText = "Rua";
            DataGridViewFuncionario.Columns[7].DataPropertyName = "end_rua";
            DataGridViewFuncionario.Columns[8].HeaderText = "N°";
            DataGridViewFuncionario.Columns[8].DataPropertyName = "end_num";
            DataGridViewFuncionario.Columns[9].HeaderText = "Bairro";
            DataGridViewFuncionario.Columns[9].DataPropertyName = "end_bairro";
            DataGridViewFuncionario.Columns[10].HeaderText = "Cidade";
            DataGridViewFuncionario.Columns[10].DataPropertyName = "end_cidade";
            DataGridViewFuncionario.Columns[11].HeaderText = "Estado";
            DataGridViewFuncionario.Columns[11].DataPropertyName = "end_estado";
            DataGridViewFuncionario.Columns[12].HeaderText = "CEP";
            DataGridViewFuncionario.Columns[12].DataPropertyName = "CEP";
            DataGridViewFuncionario.Columns[13].HeaderText = "Nv_Acesso";
            DataGridViewFuncionario.Columns[13].DataPropertyName = "nv_acesso";
        }

        private void DataGridViewFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Tbxcodigopesquisa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            cpf = TbxCPFpesquisa.Text;
            funcionario.setCPF(cpf);
            if (tbxnomepesquisa.Text != String.Empty)
            {

                nome_func = Convert.ToString(tbxnomepesquisa.Text);
            }
            funcionario.setNome(nome_func);

            if (Tbxcodigopesquisa.Text != String.Empty)
            {
                id = Convert.ToInt32(Tbxcodigopesquisa.Text);
            }
            funcionario.setID(id);
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DAOFuncionario2 daofuncionario = new DAOFuncionario2();
            conn.Open();

            DataGridViewFuncionario.DataSource = daofuncionario.PesquisarGeral();
            conn.Close();
            alterarnomesDtagridview();

            if (tbxnomepesquisa.Text != String.Empty)
            {
                DataGridViewFuncionario.DataSource = daofuncionario.PesquisarPorNome(nome_func);
                conn.Close();
                alterarnomesDtagridview();
            }
            if (TbxCPFpesquisa.Text != String.Empty)
            {
                DataGridViewFuncionario.DataSource = daofuncionario.PesquisarPorCPF(cpf);
                conn.Close();
                alterarnomesDtagridview();
            }
            if (Tbxcodigopesquisa.Text != String.Empty)
            {
                DataGridViewFuncionario.DataSource = daofuncionario.PesquisarPorId(id);
                conn.Close();
                alterarnomesDtagridview();
            }
            // daofuncionario.;
        }

        private void TbxCPFpesquisa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbxCPFpesquisa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void tbxnomepesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void Visualizar_Funcionario_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DAOFuncionario2 daofuncionario = new DAOFuncionario2();
            conn.Open();
            DataGridViewFuncionario.DataSource = daofuncionario.PesquisarPorNome(nome_func);
            conn.Close();
            alterarnomesDtagridview();
        }

        public void mostraResultados()
        {
           


        }
    }
}


////////////////////////////////////////////////////////////////////////////////


