using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PIM
{
    class DAOFuncionario2
    {
        private String nome, ctps, rg, cpf, sexo;
        private int nv_acesso, dta_nasc;
        private String rua, num, bairro, cidade, estado, cep;
        private String ddd, tel_num;


        public void adicionar(Funcionarios funcionario, Telefone telefone, Endereços endereço)
        {
            long id = -1;

            String query;
            try
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();

                query = "INSERT INTO funcionario (id_funcionario, nome, Dta_nasc, nv_acesso, cpf_cnpj, CTPS, end_rua, end_num, end_bairro, end_cidade, end_estado, cep, rg, sexo) VALUES (DEFAULT, @nome, @Dta_nasc, @nv_acesso, @cpf_cnpj, @CTPS, @end_rua, @end_num, @end_bairro, @end_cidade, @end_estado,@cep, @rg,@sexo); ";


                conn.Open();


                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("nome", funcionario.getNome(nome)));
                cmd.Parameters.Add(new MySqlParameter("Dta_nasc", funcionario.getDta_Nasc(dta_nasc)));
                cmd.Parameters.Add(new MySqlParameter("nv_acesso", funcionario.getNiveldeAcesso(nv_acesso)));
                cmd.Parameters.Add(new MySqlParameter("cpf_cnpj", funcionario.getCPF(cpf)));
                cmd.Parameters.Add(new MySqlParameter("CTPS", funcionario.getCTPS(ctps)));
                cmd.Parameters.Add(new MySqlParameter("end_rua", endereço.getRua(rua)));
                cmd.Parameters.Add(new MySqlParameter("end_num", endereço.getNum(num)));
                cmd.Parameters.Add(new MySqlParameter("end_bairro", endereço.getBairro(bairro)));
                cmd.Parameters.Add(new MySqlParameter("end_cidade", endereço.getCidade(cidade)));
                cmd.Parameters.Add(new MySqlParameter("end_estado", endereço.getEstado(estado)));
                cmd.Parameters.Add(new MySqlParameter("CEP", endereço.getCEP(cep)));
                cmd.Parameters.Add(new MySqlParameter("rg", funcionario.getRG(rg)));
                cmd.Parameters.Add(new MySqlParameter("sexo", funcionario.getSexo(sexo)));

                id = cmd.LastInsertedId;
                cmd.Prepare();
                cmd.ExecuteNonQuery();


                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }


                MessageBox.Show("Funcionário adicionado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: " + ex.ToString());
            }



            try
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();
                conn.Open();

                query = "INSERT INTO num_funcionario (id_funcionario, ddd, num) VALUES (LAST_INSERT_ID(), @ddd,@num); ";

                MySqlCommand cmd = new MySqlCommand(query, conn);


                cmd.Parameters.Add(new MySqlParameter("DDD", telefone.getDDD(ddd)));
                cmd.Parameters.Add(new MySqlParameter("num", telefone.getTel_num(tel_num)));

                id = cmd.LastInsertedId;
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


        public DataTable PesquisarGeral()
        {


            MySqlConnection conn = new ConnectionFactory().GetConnection();
            conn.Open();
            DataTable tabela = new DataTable();
            String query = "select * from funcionario;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            MySqlDataAdapter DadosFuncionarios = new MySqlDataAdapter(query, conn);
            conn.Close();
            DadosFuncionarios.Fill(tabela);
            
            return tabela;

        }


        public DataTable PesquisarPorNome(String nome)
        {
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM funcionario where nome like '%" +
            nome + "%'", conn);
            da.Fill(tabela);

            return tabela;
        }

        public DataTable PesquisarPorId(long Id)
        {
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM funcionario where id_funcionario like '%" +
                Id + "%'", conn);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable PesquisarPorCPF(String CPF)
        {
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM funcionario where CPF_CNPJ like '%" +
                CPF + "%'", conn);
            da.Fill(tabela);
            return tabela;
        }
        /*public DataTable AbrirFuncionario(long id)
        {
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM funcionario where id_funcionario like '%" + id + "%'", conn);
            Cadastrar_Funcionario cadastrar_Funcionario = new Cadastrar_Funcionario();
            cadastrar_Funcionario.Show();
            cadastrar_Funcionario.TbxNome_TextChanged = nome
            return tabela;
        }*/
    }






}
