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
    class DAOCompra
    {

        public void adicionar(ProdutoClass produto, Cliente cliente)
        {
            String query;

            try
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();

                query = "create temporary table carrinho_temp(select * from carrinho);";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                query = "INSERT INTO carrinho_temp (id_produto,nome_prod, qtd, valor_unit, valor_conj) VALUES (@id_produto, @nome_prod, @qtd, @valor_unit, @valo_conj); ";

                cmd.Parameters.Add(new MySqlParameter("id_produto", produto.ID));
                cmd.Parameters.Add(new MySqlParameter("nome_prod", produto.Nome));
                cmd.Parameters.Add(new MySqlParameter("qtd", produto.Qtd));
                cmd.Parameters.Add(new MySqlParameter("valor_unit", produto.Valor_Venda));
                cmd.Parameters.Add(new MySqlParameter("valor_conj", produto.Valor_Total));


                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO:" + ex.ToString());
            }

            try
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();

                query = "INSERT INTO compra (nome, cpf, id_produto, dta_compra) VALUES (@nome, @cpf, @id_produto, @dta_compra) ; ";

                conn.Open();


                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("nome", produto.Nome));
                cmd.Parameters.Add(new MySqlParameter("CPF", cliente.CPF));
                cmd.Parameters.Add(new MySqlParameter("id_produto", produto.ID));
                cmd.Parameters.Add(new MySqlParameter("dta_compra", DateTime.Today));

                cmd.Prepare();
                cmd.ExecuteNonQuery();


                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }


                MessageBox.Show("Compra adicionada");
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
            String query = "select * from compra;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader leitor = cmd.ExecuteReader();
            MySqlDataAdapter DadosFuncionarios = new MySqlDataAdapter(query, conn);
            conn.Close();
            DadosFuncionarios.Fill(tabela);

            return tabela;

        }



        public void finalizar(CompraClass compra)
        {
            long protocolo = -1;

            try
            {
                String query;

                query = "create temporary table compra_temp(select* from compra);" +
                        "create temporary table carrinho_temp(select* from carrinho);";

                MySqlConnection conn = new ConnectionFactory().GetConnection();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.ToString());
            }

            try
            {
                String query;

                query = "INSERT INTO compra_temp (CPF,valor_total, dta_venda ) values( 18 , , 255.50);" +
                        " ;";

                MySqlConnection conn = new ConnectionFactory().GetConnection();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Prepare();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.ToString());
            }
        }

    }
}
