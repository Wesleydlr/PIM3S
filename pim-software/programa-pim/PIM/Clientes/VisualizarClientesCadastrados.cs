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

namespace PIM
{
    public partial class VisualizarClientesCadastrados : Form
    {

        public VisualizarClientesCadastrados()
        {
            InitializeComponent();
        }
        private string nome, cpf;
        private void VisualizarClientesCadastrados_Load(object sender, EventArgs e)
        {
            DAOCliente daocliente = new DAOCliente();
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            conn.Open();

            DtaGridClientes.DataSource = daocliente.PesquisarGeral();
            conn.Close();
            alterarNomesDtagridview();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            CadastrodeClientes cadastrarCliente = new CadastrodeClientes();
            cadastrarCliente.Show();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal mainMenu = new MenuPrincipal();
            mainMenu.Show();
        }

        private void TbxCPFpesquisa_TextChanged(object sender, EventArgs e)
        {
            cpf = TbxCPFpesquisa.Text;

        }


        private void DtaGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnRemover_Click_1(object sender, EventArgs e)
        {
            DAOCliente daocliente = new DAOCliente();

            // daocliente.excluirCPF(cpf);
        }

        public void alterarNomesDtagridview()
        {
            DtaGridClientes.Columns[0].HeaderText = "Nome";
            DtaGridClientes.Columns[0].DataPropertyName = "nome";
            DtaGridClientes.Columns[1].HeaderText = "CPF";
            DtaGridClientes.Columns[1].DataPropertyName = "CPF";
            DtaGridClientes.Columns[2].HeaderText = "RG";
            DtaGridClientes.Columns[2].DataPropertyName = "RG";
            DtaGridClientes.Columns[3].HeaderText = "Dta_nasc";
            DtaGridClientes.Columns[3].DataPropertyName = "Dta_nasc";
            DtaGridClientes.Columns[4].HeaderText = "Rua";
            DtaGridClientes.Columns[4].DataPropertyName = "end_rua";
            DtaGridClientes.Columns[5].HeaderText = "N°";
            DtaGridClientes.Columns[5].DataPropertyName = "end_num";
            DtaGridClientes.Columns[6].HeaderText = "Bairro";
            DtaGridClientes.Columns[6].DataPropertyName = "end_bairro";
            DtaGridClientes.Columns[7].HeaderText = "Cidade";
            DtaGridClientes.Columns[7].DataPropertyName = "end_cidade";
            DtaGridClientes.Columns[8].HeaderText = "Estado";
            DtaGridClientes.Columns[8].DataPropertyName = "end_municipio";
            DtaGridClientes.Columns[9].HeaderText = "CEP";
            DtaGridClientes.Columns[9].DataPropertyName = "cep";
            DtaGridClientes.Columns[10].HeaderText = "E-Mail";
            DtaGridClientes.Columns[10].DataPropertyName = "email";
        }

        private void tbxnomepesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPesquisa_Click_1(object sender, EventArgs e)
        {
            DAOCliente daocliente = new DAOCliente();

            if (tbxnomepesquisa.Text == String.Empty && TbxCPFpesquisa.Text == String.Empty)
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();
                conn.Open();

                DtaGridClientes.DataSource = daocliente.PesquisarGeral();
                conn.Close();
                alterarNomesDtagridview();
            }
            if (tbxnomepesquisa.Text == String.Empty)
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();
                conn.Open();

                DtaGridClientes.DataSource = daocliente.PesquisarPorCpf(cpf);
                conn.Close();
                alterarNomesDtagridview();
            }
            if(TbxCPFpesquisa.Text == String.Empty)
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();
                conn.Open();

                DtaGridClientes.DataSource = daocliente.PesquisarPorNome(nome);
                conn.Close();
                alterarNomesDtagridview();
            }

        }

    }
}
