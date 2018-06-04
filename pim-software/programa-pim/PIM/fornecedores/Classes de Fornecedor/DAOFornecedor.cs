using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace PIM
{
    class DAOFornecedor
    {

        private String nome, cnpj, categoria, descricao, email;
        public String rua, num, bairro, cidade, estado, cep;
        public String ddd, tel_num;


        public void adicionar(FornecedorClass fornecedor, Telefone telefone, Endereços endereço)
        {
            long id = -1;

            String query;
            try
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();

                query = "INSERT INTO fornecedor (id_fornecedor, Nome_Empresa, CNPJ, email, descricao, categoria, end_rua, end_num, end_bairro, end_cidade, end_estado, CEP_Sede, id_produto) VALUES (DEFAULT, @Nome_Empresa, @CNPJ, @email, @descricao, @categoria, @end_rua, @end_num, @end_bairro, @end_cidade, @end_estado,@CEP_Sede, DEFAULT); ";


                conn.Open();


                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("Nome_Empresa", fornecedor.getNome(nome)));
                cmd.Parameters.Add(new MySqlParameter("CNPJ", fornecedor.getCNPJ(cnpj)));
                cmd.Parameters.Add(new MySqlParameter("email", fornecedor.getEmail(email)));
                cmd.Parameters.Add(new MySqlParameter("descricao", fornecedor.getDescricao(descricao)));
                cmd.Parameters.Add(new MySqlParameter("categoria", fornecedor.getCategoria(categoria)));
                cmd.Parameters.Add(new MySqlParameter("end_rua", endereço.getRua(rua)));
                cmd.Parameters.Add(new MySqlParameter("end_num", endereço.getNum(num)));
                cmd.Parameters.Add(new MySqlParameter("end_bairro", endereço.getBairro(bairro)));
                cmd.Parameters.Add(new MySqlParameter("end_cidade", endereço.getCidade(cidade)));
                cmd.Parameters.Add(new MySqlParameter("end_estado", endereço.getEstado(estado)));
                cmd.Parameters.Add(new MySqlParameter("CEP_Sede", endereço.getCEP(cep)));

                id = cmd.LastInsertedId;
                cmd.Prepare();
                cmd.ExecuteNonQuery();


                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }


                MessageBox.Show("Fornecedor adicionado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: " + ex.ToString());
            }



            try
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();
                conn.Open();

                query = "INSERT INTO num_fornecedor (id_fornecedor, ddd, numero) VALUES (LAST_INSERT_ID(), @ddd,@numero); ";

                MySqlCommand cmd = new MySqlCommand(query, conn);


                cmd.Parameters.Add(new MySqlParameter("DDD", telefone.getDDD(ddd)));
                cmd.Parameters.Add(new MySqlParameter("numero", telefone.getTel_num(tel_num)));

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

        public void excluirID(int id_fornecedor)
        {
            try
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();
                string query = "DELETE FROM num_fornecedor" + " WHERE id_fornecedor = @id_fornecedor";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id_fornecedor", id_fornecedor);
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
                string query = "DELETE FROM fornecedor" + " WHERE id_fornecedor = @id_fornecedor";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();

                cmd.Parameters.AddWithValue("@id_fornecedor", id_fornecedor);

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
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT *FROM fornecedor where Nome_Empresa like '%" +
                nome + "%'", conn);
            da.Fill(tabela);

            return tabela;
        }

        public DataTable PesquisarPorID(int id_fornecedor)
        {
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DataTable tabela = new DataTable();
            String query = "Select * from fornecedor WHERE id_fornecedor = @id_fornecedor";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_fornecedor", id_fornecedor);
            conn.Open();
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            MySqlDataAdapter dadosCliente = new MySqlDataAdapter(query, conn);

            dadosCliente.Fill(tabela);
            return tabela;

        }

        public FornecedorClass carregaFornecedor(int Codigo)
        {
            FornecedorClass fornecedor = new FornecedorClass();

            MySqlConnection conn = new ConnectionFactory().GetConnection();
            String query = "SELECT * FROM fornecedor WHERE id_fornecedor = " + Codigo.ToString();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader registro = cmd.ExecuteReader();

            conn.Close();
            return fornecedor;
        }



        //Metodo que faz a pesquisa de fornecedor no banco por cnpj
        public DataTable PesquisarPorCnpj(String cnpj)
        {
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("Select * from fornecedor where cnpj like '%" + cnpj + "%'", conn);

            dadosCliente.Fill(tabela);
            return tabela;
        }


        public DataTable PesquisarGeral()
        {
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter(" SELECT * FROM fornecedor,num_fornecedor  WHERE fornecedor.id_fornecedor = num_fornecedor.id_fornecedor;", conn);
            dadosCliente.Fill(tabela);
            return tabela;
        }
    }
}
