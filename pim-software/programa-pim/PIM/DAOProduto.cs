using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PIM
{
    class DAOProduto
    {
        private String nome, categoria, descricao, tamanho, cor, estilo;
        private Decimal valor_venda, valor_compra, valor_promo;
        private int dta_inicio, dta_fim;
        private Decimal med_peitoral, med_cintura, med_quadril, med_altura, numeracao;
        private int qtd;


        public void adicionar(ProdutoClass produto)
        {
            long id = -1;
            String query;


            switch (produto.getCategoria(categoria))
            {


                case "Equipamento":
                    try
                    {
                        MySqlConnection conn = new ConnectionFactory().GetConnection();

                        conn.Open();

                        query = "INSERT INTO produto(id_produto, cod_barras,qtd) values(DEFAULT,1,@qtd);";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.Add(new MySqlParameter("qtd", produto.getQtd(qtd)));

                        id = cmd.LastInsertedId;
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();


                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("erro: " + ex.ToString());
                    }



                    try
                    {
                        MySqlConnection conn = new ConnectionFactory().GetConnection();


                        query = "INSERT INTO prod_equip(id_produto, cores, nome) values (LAST_INSERT_ID(), @cores, @nome); ";

                        conn.Open();

                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        cmd.Parameters.Add(new MySqlParameter("nome", produto.getNome(nome)));
                        cmd.Parameters.Add(new MySqlParameter("cores", produto.getCor(cor)));


                        id = cmd.LastInsertedId;
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();





                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("erro: " + ex.ToString());
                    }

                    try
                    {
                        MySqlConnection conn = new ConnectionFactory().GetConnection();

                        conn.Open();

                        query = "INSERT INTO tabela_precos(id_produto, Dta_inicio,Dta_fim,preco_compra,preco_venda) values(LAST_INSERT_ID(),@Dta_inicio,@Dta_fim, @preco_venda, @preco_compra);";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.Add(new MySqlParameter("Dta_inicio", produto.getDta_inicio(qtd)));
                        cmd.Parameters.Add(new MySqlParameter("Dta_fim", produto.getDta_fim(qtd)));
                        cmd.Parameters.Add(new MySqlParameter("preco_compra", produto.getQtd(qtd)));
                        cmd.Parameters.Add(new MySqlParameter("preco_venda", produto.getQtd(qtd)));


                        id = cmd.LastInsertedId;
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();


                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                        MessageBox.Show("Vestimenta adicionado");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("erro: " + ex.ToString());
                    }
                    break;



                case "Vestimenta":

                    try
                    {
                        MySqlConnection conn = new ConnectionFactory().GetConnection();

                        conn.Open();

                        query = "INSERT INTO produto(id_produto, cod_barras,qtd) values(DEFAULT,1,@qtd);";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.Add(new MySqlParameter("qtd", produto.getQtd(qtd)));

                        id = cmd.LastInsertedId;
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();


                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("erro: " + ex.ToString());
                    }

                    try
                    {
                        MySqlConnection conn = new ConnectionFactory().GetConnection();
                        query = "INSERT INTO prod_vest(id_produto, cores, nome, estilo) values (LAST_INSERT_ID(), @cores, @nome, @estilo); ";

                        conn.Open();

                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        cmd.Parameters.Add(new MySqlParameter("nome", produto.getNome(nome)));
                        cmd.Parameters.Add(new MySqlParameter("cores", produto.getCor(cor)));
                        cmd.Parameters.Add(new MySqlParameter("estilo", produto.getEstilo(estilo)));


                        id = cmd.LastInsertedId;
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();


                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("erro: " + ex.ToString());
                    }

                    try
                    {
                        MySqlConnection conn = new ConnectionFactory().GetConnection();
                        query = "INSERT INTO tabela_tam(id_produto, med_peitoral, med_cintura, med_quadril, med_altura, numeração, tamanho) values (LAST_INSERT_ID(), @med_peitoral, @med_cintura, @med_quadril, @med_altura, @numeração, @tamanho); ";

                        conn.Open();

                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        cmd.Parameters.Add(new MySqlParameter("med_peitoral", produto.getMed_Peitoral(med_peitoral)));
                        cmd.Parameters.Add(new MySqlParameter("med_cintura", produto.getMed_Cintrua(med_cintura)));
                        cmd.Parameters.Add(new MySqlParameter("med_quadril", produto.getMed_Quadril(med_quadril)));
                        cmd.Parameters.Add(new MySqlParameter("med_altura", produto.getMed_Altura(med_altura)));
                        cmd.Parameters.Add(new MySqlParameter("numeração", produto.getNumeracao(numeracao)));
                        cmd.Parameters.Add(new MySqlParameter("tamanho", produto.getTamanho(tamanho)));
                        id = cmd.LastInsertedId;
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();


                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("erro: " + ex.ToString());
                    }

                    try
                    {
                        MySqlConnection conn = new ConnectionFactory().GetConnection();

                        conn.Open();

                        query = "INSERT INTO tabela_precos(id_produto, Dta_inicio,Dta_fim,preco_compra,preco_venda) values(LAST_INSERT_ID(),@Dta_inicio,@Dta_fim, @preco_venda, @preco_compra);";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.Add(new MySqlParameter("Dta_inicio", produto.getDta_inicio(dta_inicio)));
                        cmd.Parameters.Add(new MySqlParameter("Dta_fim", produto.getDta_fim(dta_fim)));
                        cmd.Parameters.Add(new MySqlParameter("preco_compra", produto.getValor_compra(valor_compra)));
                        cmd.Parameters.Add(new MySqlParameter("preco_venda", produto.getValor_Venda(valor_venda)));


                        id = cmd.LastInsertedId;
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();


                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }


                        MessageBox.Show("Vestimenta adicionado");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("erro: " + ex.ToString());
                    }
                    break;
            }
        }

        public void excluirID(int id_produto)
        {
            try
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();
                string query = "DELETE FROM produto" + " WHERE id_produto = @id_produto";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id_fornecedor", id_produto);
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

                cmd.Parameters.AddWithValue("@id_fornecedor", id_produto);

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
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM produto a INNER JOIN prod_equip b ON a.id_produto = b.id_produto " +
                                                       "LEFT JOIN tabela_precos d ON a.id_produto = d.id_produto WHERE nome lIKE '%" + nome + "%'", conn);
            da.Fill(tabela);

            return tabela;
        }

       /* public DataTable PesquisarPorID(int id)
        {
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("SELECT * FROM produto a INNER JOIN prod_vest b ON a.id_produto = b.id_produto" +
                                                                " LEFT JOIN tabela_tam c ON a.id_produto = c.id_produto" +
                                                                " LEFT JOIN tabela_precos d ON a.id_produto = d.id_produto WHERE a.id_produto = d.id_produto" +
                                                                " WHERE a.id_produto =" + id.ToString() + ";", conn);
            dadosCliente.Fill(tabela);
            return tabela;

        }*/

        public ProdutoClass carregaProduto(int Codigo)
        {


            ProdutoClass produto = new ProdutoClass();

            MySqlConnection conn = new ConnectionFactory().GetConnection();
            String query = "SELECT * FROM produto,  " +
                " prod_vest ON prod_vest.id_produto = produto.id_produto" + Codigo.ToString();


            conn.Close();
            return produto;
        }



        public DataTable PesquisarEquipPreco()
        {
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("SELECT * FROM produto a INNER JOIN prod_equip b ON a.id_produto = b.id_produto " +
                                                                 "LEFT JOIN tabela_precos d ON a.id_produto = d.id_produto ; ", conn);
            dadosCliente.Fill(tabela);
            return tabela;
        }

        public DataTable PesquisaVestPreco()
        {
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("SELECT * FROM produto a INNER JOIN prod_vest b ON a.id_produto = b.id_produto " +
                                                                "LEFT JOIN tabela_tam c ON a.id_produto = c.id_produto " +
                                                                "LEFT JOIN tabela_precos d ON a.id_produto = d.id_produto;", conn);
            dadosCliente.Fill(tabela);
            return tabela;

        }

        public DataTable Pesquisa_Geral()
        {
            MySqlConnection conn = new ConnectionFactory().GetConnection();
            DataTable tabela = new DataTable();
            MySqlDataAdapter dadosCliente = new MySqlDataAdapter("SELECT * FROM produto a left JOIN prod_vest b ON a.id_produto = b.id_produto " +
                "left JOIN prod_equip c ON a.id_produto = c.id_produto " +
                "left JOIN tabela_precos d ON a.id_produto = d.id_produto; ", conn);


            dadosCliente.Fill(tabela);
            return tabela;

        }

        public void CarrinhoDB()
        {
            String query;

            try
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();

                conn.Open();

                query = "CREATE TEMP table_compra ON COMMIT DROP ;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.ExecuteNonQuery();


                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("erro: " + ex.ToString());
            }




            try
            {
                MySqlConnection conn = new ConnectionFactory().GetConnection();

                conn.Open();

                query = "INSERT INTO table_compra( ;";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                cmd.ExecuteNonQuery();


                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }catch(Exception ex)
            {

            }


    }
    }
}

