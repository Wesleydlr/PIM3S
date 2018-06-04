using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    class DAOCliente
    {
        private String nome, RG, CPF, email;
        public String rua, num, bairro, cidade, estado, cep;
        public String ddd, tel_num;
        private int DataNascimento;

        public void adicionar(Cliente cliente, Telefone telefone, Endereços endereço)
        {
            

            String query;
            try
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();

                query = "INSERT INTO cliente (nome, CPF,RG, email, end_rua, end_num, end_bairro, end_cidade, end_municipio, cep, dta_nasc) VALUES (@Nome, @CPF, @RG, @email, @end_rua, @end_num, @end_bairro, @end_cidade, @end_municipio,@CEP, @dta_nasc); ";


                conn.Open();


                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("nome", cliente.getNome(nome)));
                cmd.Parameters.Add(new MySqlParameter("CPF", cliente.getCPF(CPF)));
                cmd.Parameters.Add(new MySqlParameter("email", cliente.getEmail(email)));
                cmd.Parameters.Add(new MySqlParameter("RG", cliente.getRG(RG)));
                cmd.Parameters.Add(new MySqlParameter("end_rua", endereço.getRua(rua)));
                cmd.Parameters.Add(new MySqlParameter("end_num", endereço.getNum(num)));
                cmd.Parameters.Add(new MySqlParameter("end_bairro", endereço.getBairro(bairro)));
                cmd.Parameters.Add(new MySqlParameter("end_cidade", endereço.getCidade(cidade)));
                cmd.Parameters.Add(new MySqlParameter("end_municipio", endereço.getEstado(estado)));
                cmd.Parameters.Add(new MySqlParameter("CEP", endereço.getCEP(cep)));
                cmd.Parameters.Add(new MySqlParameter("dta_nasc", cliente.getDta_nasc(DataNascimento)));

                cmd.Prepare();
                cmd.ExecuteNonQuery();


                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }


                MessageBox.Show("Cliente adicionado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: " + ex.ToString());
            }



            try
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();
                conn.Open();

                query = "INSERT INTO num_cliente (CPF, ddd, num) VALUES (@CPF, @ddd,@num); ";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.Add(new MySqlParameter("CPF", cliente.getCPF(CPF)));
                cmd.Parameters.Add(new MySqlParameter("ddd", telefone.getDDD(ddd)));
                cmd.Parameters.Add(new MySqlParameter("num", telefone.getTel_num(tel_num)));

                
                cmd.Prepare();
                cmd.ExecuteNonQuery();



                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                MessageBox.Show("Numero Adicionado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: " + ex.ToString());
            }
        }

        /*public void excluirCPF(String cpf)
        {
            try
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();
                string query = "DELETE FROM num_cliente" + " WHERE cpf = @cpf";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@cpf", cpf);
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.ToString());
            }

            try
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();
                string query = "DELETE FROM cliente" + " WHERE cpf = @cpf";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@cpf", CPF);

                cmd.Prepare();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.ToString());
            }
            MessageBox.Show("Removido com sucesso");
        }

        public DataTable PesquisarPorNome(String nome)
        {
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM cliente where Nome like '%" +
                nome + "%'", conn);
            da.Fill(tabela);

            return tabela;
        }
        /*public DataTable PesquisarPorID(int id_fornecedor)
        {
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DataTable tabela = new DataTable();
            String query = "Select * from fornecedor WHERE id_fornecedor = @id_fornecedor";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_fornecedor", id_fornecedor);

            cmd.Prepare();


            MySqlDataAdapter dadosCliente = new MySqlDataAdapter(query, conn);

                dadosCliente.Fill(tabela);
                return tabela;

        }*/

        public Cliente carregaCliente(int Codigo)
        {
            Cliente cliente = new Cliente();

            MySqlConnection conn = new ConnectionFactory().GetConnection();
            String query = "SELECT * FROM cliente WHERE cpf = " + Codigo.ToString();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                cliente.CPF = Convert.ToString(registro["CPF"]);
                cliente.Nome = Convert.ToString(registro["nome"]);
                cliente.Email = Convert.ToString(registro["email"]);
                cliente.RG = Convert.ToString(registro["RG"]);
                //fornecedor.Descricao = Convert.ToString(registro["descricao"]);
            }
            conn.Close();
            return cliente;
        }



        //Metodo que faz a pesquisa de fornecedor no banco por cnpj
        public DataTable PesquisarPorCpf(String cpf)
        {
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            conn.Open();
            DataTable tabela = new DataTable();
            String query = "SELECT * FROM cliente WHERE CPF like '%"+ cpf + "%'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            MySqlDataAdapter DadosFuncionarios = new MySqlDataAdapter(query, conn);
            conn.Close();
            DadosFuncionarios.Fill(tabela);

            return tabela;
        }

        public DataTable PesquisarPorNome(string Nome)
        {
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM cliente where nome like '%" +
                Nome + "%'", conn);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable PesquisarGeral()
        {

            MySqlConnection conn = new ConnectionFactory().GetConnection();
            conn.Open();
            DataTable tabela = new DataTable();
            String query = "select * from cliente, num_cliente WHERE cliente.CPF = num_cliente.CPF;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            MySqlDataAdapter DadosFuncionarios = new MySqlDataAdapter(query, conn);
            conn.Close();
            DadosFuncionarios.Fill(tabela);

            return tabela;
        }
    }
}

