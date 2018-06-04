using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM
{
    class FornecedorClass
    {
        public string Nome;
        public string CNPJ;
        public string Categoria;
        public string Descricao;
        public string Email;
        public int ID;


        public String getNome(String nome)
        {
            return this.Nome;
        }

        public String setNome(String nome)
        {
            return this.Nome = nome;
        }

        public String getCNPJ(String cnpj)
        {
            return this.CNPJ;
        }

        public String setCNPJ(String cnpj)
        {
            return this.CNPJ = cnpj;
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

        public String getEmail(String email)
        {
            return this.Email;
        }

        public String setEmail(String email)
        {
            return this.Email = email;
        }


        /*public FornecedorClass(string Nome, string CNPJ, string Categoria, string Descricao, string Email)
        {
            this.Nome = Nome;
            this.CNPJ = CNPJ;
            this.Categoria = Categoria;
            this.Descricao = Descricao;
            this.Email = Email;

        }*/
    }
}
