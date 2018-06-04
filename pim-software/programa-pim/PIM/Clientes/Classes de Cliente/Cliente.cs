using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM
{
    class Cliente
    {
        public String Nome, RG, CPF, Email;
        public int Dta_nasc;

        public String getNome(String nome)
        {
            return this.Nome;
        }

        public String setNome(String nome)
        {
            return this.Nome = nome;
        }

        public String getRG(String rg)
        {
            return this.RG;
        }

        public String setRG(String rg)
        {
            return this.RG = rg;
        }

        public int getDta_nasc(int dta_nasc)
        {
            return this.Dta_nasc ;
        }

        public int setDta_nasc(int dta_nasc)
        {
            return this.Dta_nasc = dta_nasc;
        }

        public String getCPF(String cpf)
        {
            return this.CPF;
        }

        public String setCPF(String cpf)
        {
            return this.CPF = cpf;
        }

        public String getEmail(String email)
        {
            return this.Email;
        }

        public String setEmail(String email)
        {
            return this.Email = email;
        }


       /* public  Cliente(string Nome, string DataNascimento, string RG, string cpf, string Email)
         {
             this.Nome = Nome;
             this.DataNascimento = DataNascimento;
             this.RG = RG;
             this.cpf = cpf;
             this.Email = Email;

         }*/

    }
}
