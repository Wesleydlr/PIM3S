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

namespace PIM.Produto
{
    public partial class Cadastrar_Produto : Form
    {
        public Cadastrar_Produto()
        {
            InitializeComponent();
        }

        ProdutoClass produto = new ProdutoClass();
        private String nome, categoria, descricao, tamanho, cor, estilo;
        private Decimal valor_venda, valor_compra, valor_promo;
        private int dta_inicio, dta_fim;
        private Decimal med_peitoral, med_cintura, med_quadril, med_altura, numeracao;
        private int qtd;




        private void TbxDta_Fim_TextChanged(object sender, EventArgs e)
        {
            dta_fim = Convert.ToInt32(TbxDta_Fim.Text);
            produto.setDta_fim(dta_fim);
        }

        private void TbxPeitoral_TextChanged(object sender, EventArgs e)
        {
            med_peitoral = Convert.ToDecimal(TbxPeitoral.Text);
            produto.setMed_Peitoral(med_peitoral);

        }

        private void TbxCintura_TextChanged(object sender, EventArgs e)
        {
            med_cintura = Convert.ToDecimal(TbxCintura.Text);
            produto.setMed_Cintura(med_cintura);
        }

        private void TbxQuadril_TextChanged(object sender, EventArgs e)
        {
            med_quadril = Convert.ToDecimal(TbxQuadril.Text);
            produto.setMed_Quadril(med_quadril);
        }

        private void TbxAltura_TextChanged(object sender, EventArgs e)
        {
            med_altura = Convert.ToDecimal(TbxAltura.Text);
            produto.setMed_Altura(med_altura);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            estilo = Convert.ToString(comboBox1.SelectedText);
            produto.setEstilo(estilo);
        }

        private void TbxNumeracao_TextChanged(object sender, EventArgs e)
        {
            numeracao = Convert.ToDecimal(TbxNumeracao);
            produto.setNumeracao(numeracao);
        }

        private void CheckBxCalçado_CheckedChanged(object sender, EventArgs e)
        {



            while (CheckBxCalçado.Checked)
            {


                TbxNumeracao.Enabled = true;
                TbxPeitoral.Enabled = false;
                TbxCintura.Enabled = false;
                TbxQuadril.Enabled = false;
                TbxAltura.Enabled = false;

            }

            TbxNumeracao.Enabled = false;
            TbxPeitoral.Enabled = true;
            TbxCintura.Enabled = true;
            TbxQuadril.Enabled = true;
            TbxAltura.Enabled = true;
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TbxValor_Venda_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbxDta_Inicio_TextChanged(object sender, EventArgs e)
        {
            dta_inicio = Convert.ToInt32(TbxDta_Inicio.Text);
            produto.SetDta_inicio(dta_inicio);
        }

        private void TbxDescricao_TextChanged(object sender, EventArgs e)
        {
            categoria = TbxDescricao.Text;
            produto.setDescricao(descricao);
        }

        private void TbxNome_TextChanged(object sender, EventArgs e)
        {
            nome = TbxNome.Text;
            produto.setNome(nome);
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Produto.Visualizar_Produtos visualizarProdutos = new Produto.Visualizar_Produtos();
            visualizarProdutos.Show();
            this.Close();
        }

        private void ComBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoria = Convert.ToString(ComBoxCategoria.Text);
            produto.setCategoria(categoria);

            if (categoria == "Equipamento")
            {
                comboBox1.Enabled = false;

                TbxNumeracao.Enabled = false;

                TbxPeitoral.Enabled = false;

                TbxCintura.Enabled = false;

                TbxQuadril.Enabled = false;

                TbxAltura.Enabled = false;

                TbxNumeracao.Enabled = false;

                ComBoxTam.Enabled = false;


            }
            else
            {
                ComBoxTam.Enabled = true;

                comboBox1.Enabled = true;

                TbxPeitoral.Enabled = true;

                TbxCintura.Enabled = true;

                TbxQuadril.Enabled = true;

                TbxAltura.Enabled = true;

                TbxNumeracao.Enabled = true;


            }


        }

        private void TbxCor_TextChanged(object sender, EventArgs e)
        {
            cor = TbxCor.Text;
            produto.setCor(cor);
        }

        private void TbxValor_Venda_TextChanged(object sender, KeyPressEventArgs e)
        {
            
                
                valor_venda = Convert.ToDecimal(TbxValor_Venda.Text);
                produto.setValor_venda(valor_venda);

        }

        private void TbxQtd_TextChanged(object sender, EventArgs e)
        {
            
            qtd = Convert.ToInt32(TbxQtd.Text);
            produto.setQtd(qtd);
         
        }

        private void TbxValor_Compra_TextChanged(object sender, EventArgs e)
        {
            valor_compra = Convert.ToDecimal(TbxValor_Compra.Text);
            produto.setValor_compra(valor_compra);
        }

        private void TbxValor_Promo_TextChanged(object sender, EventArgs e)
        {
            valor_promo = Convert.ToDecimal(TbxValor_Promo.Text);
            produto.setValor_promo(valor_promo);
        }

        private void ComBoxTam_SelectedIndexChanged(object sender, EventArgs e)
        {
            tamanho = Convert.ToString(ComBoxTam.Text);
            produto.setTamanho(tamanho);
        }






        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            DAOProduto daoproduto = new DAOProduto();

            daoproduto.adicionar(produto);

        }
    }
}