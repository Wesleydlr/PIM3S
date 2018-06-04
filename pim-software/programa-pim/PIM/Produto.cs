using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM
{
    class ProdutoClass
    {
        public string Nome, Categoria, Descricao, Tamanho, Cor, Estilo;
        public Decimal Valor_Venda, Valor_Compra, Valor_Promo, Valor_Total;
        public Decimal Med_Peitoral, Med_Cintura, Med_Quadril, Med_Altura, Numeracao;
        public int Dta_Inicio;
        public int Dta_Fim;
        public int Qtd, ID;
      
        FornecedorClass fornecedor = new FornecedorClass();


        public String getNome(String nome)
        {
            return this.Nome;
        }

        public String setNome(String nome)
        {
            return this.Nome = nome;
        }

        public String getCategoria(String categoria)
        {
            return this.Categoria;
        }

        public String setCategoria(String categoria)
        {
            return this.Categoria = categoria;
        }

        public String getDescricao(String descricao)
        {
            return this.Descricao;
        }

        public String setDescricao(String descricao)
        {
            return this.Descricao = descricao;
        }

        public String getTamanho(String tamanho)
        {
            return this.Tamanho;
        }

        public String setTamanho(String tamanho)
        {
            return this.Tamanho = tamanho;
        }

        public String getCor(String cor)
        {
            return this.Cor;
        }

        public String setCor(String cor)
        {
            return this.Cor = cor;
        }

        public Decimal getValor_Venda(Decimal valor_venda)
        {
            return this.Valor_Venda;
        }

        public Decimal setValor_venda(Decimal valor_venda)
        {
            return this.Valor_Venda = valor_venda;
        }

        public Decimal getValor_compra(Decimal valor_compra)
        {
            return this.Valor_Compra;
        }

        public Decimal setValor_compra(Decimal valor_compra)
        {
            return this.Valor_Compra = valor_compra;
        }

        public Decimal getValor_promo(Decimal valor_promo)
        {
            return this.Valor_Promo;
        }

        public Decimal setValor_promo(Decimal valor_promo)
        {
            return this.Valor_Promo = valor_promo;
        }

        public int getDta_inicio(int dta_inicio)
        {
            return this.Dta_Inicio;
        }

        public int SetDta_inicio(int dta_inicio)
        {
           return  this.Dta_Inicio = dta_inicio;
        }

        public int getDta_fim(int dta_fim)
        {
            return this.Dta_Fim;
        }

        public int setDta_fim(int dta_fim)
        {
            return this.Dta_Fim = dta_fim;
        }

        public int getQtd(int qtd)
        {
            return this.Qtd;
        }

        public int setQtd(int qtd)
        {
            return this.Qtd = qtd;
        }

        public Decimal getMed_Peitoral(Decimal med_peitoral)
        {
            return this.Med_Peitoral;
        }

        public Decimal setMed_Peitoral(Decimal med_peitoral)
        {
            return this.Med_Peitoral = med_peitoral;
        }

        public Decimal getMed_Cintrua(Decimal med_cintura)
        {
            return this.Med_Cintura;
        }

        public Decimal setMed_Cintura(Decimal med_cintura)
        {
            return this.Med_Cintura = med_cintura;
        }

        public Decimal getMed_Quadril(Decimal med_quadril)
        {
            return this.Med_Quadril;
        }

        public Decimal setMed_Quadril(Decimal med_quadril)
        {
            return this.Med_Quadril = med_quadril;
        }

        public Decimal getMed_Altura(Decimal med_altura)
        {
            return this.Med_Altura;
        }

        public Decimal setMed_Altura(Decimal med_altura)
        {
            return this.Med_Altura = med_altura;
        }

        public Decimal getNumeracao(Decimal numeracao)
        {
            return this.Numeracao;
        }

        public Decimal setNumeracao(Decimal numeracao)
        {
            return this.Numeracao =numeracao;
        }

        public String getEstilo(String estilo)
        {
            return this.Estilo;
        }

        public String setEstilo(String estilo)
        {
            return this.Estilo = estilo;
        }

        /*public int getID(int id)
        {
            return this.ID;
        }

        public int setID(int id)
        {
            return ID = id ;
        }*/





        /*public ProdutoClass(string Nome, string Categoria, string Descricao, string Tamanho, string Cor, decimal Valor_Venda, decimal Valor_Compra, decimal Valor_Promo, DateTime Dta_Inicio, DateTime Dta_Fim, int Qtd)
        {
            this.Nome = Nome;
            this.Categoria = Categoria;
            this.Descricao = Descricao;
            this.Tamanho = Tamanho;
            this.Cor = Cor;
            this.Valor_Venda = Valor_Venda;
            this.Valor_Compra = Valor_Compra;
            this.Valor_Promo = Valor_Promo;
            this.Dta_Inicio = Dta_Inicio;
            this.Dta_Fim = Dta_Fim;
            this.Qtd = Qtd;
        }*/

        public ProdutoClass()
        {
        }
    }
}
