using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM
{
    public class Funcionarios
    {
        private String Nome;
        private String CTPS;
        private String Sexo;
        private String RG;
        private String CPF;
        private int NivelDeAcesso;
        private int Dta_nasc;//faltando
        private long ID_funcionario;

        /*public Funcionarios(string nome, string ctps, int id, string rg, string cpf, string nivelDeAcesso, int dta_nasc)
        {
            this.Nome = nome;
            this.CTPS = ctps;
            this.ID = id;
            this.RG = rg;
            this.CPF = cpf;
            this.NivelDeAcesso = nivelDeAcesso;
            this.Dta_nasc = dta_nasc;
           
        }*/

        //Resolvi criar 1 metodo getter e setter por atributo
        //Metodos Getters & Setters(inicio)
        public long getID(long id_funcionario)
        {
            return this.ID_funcionario;
        }

        public long setID(long id_funcionario)
        {
            return this.ID_funcionario = id_funcionario;
        }

        public String getNome(String nome)  
        {
            return this.Nome;
        }

        public String setNome(String nome)
        {
            return this.Nome = nome;
        }

        public String getCTPS(String ctps)
        {
            return this.CTPS;
        }

        public String setCTPS(String ctps)
        {
            return this.CTPS = ctps;
        }

        public String getRG(String rg)
        {
            return this.RG;
        }

        public String setRG(String rg)
        {
            return this.RG = rg;
        }

        public String getCPF(String cpf)
        {
            return this.CPF;
        }

        public String setCPF(String cpf)
        {
            return this.CPF = cpf;
        }

        public int getNiveldeAcesso(int nv_acesso)
        {
            return this.NivelDeAcesso;
        }

        public int setNiveldeAcesso(int nv_acesso)
        {
            return this.NivelDeAcesso = nv_acesso;
        }

        public int getDta_Nasc(int nv_acesso)
        {
            return Dta_nasc;
        }

        public int setDta_nasc(int dta_nasc)
        {
            return this.Dta_nasc = dta_nasc;
        }

        public String getSexo(String sexo)
        {
            return this.Sexo;
        }

        public String setSexo(String sexo)
        {
            return this.Sexo = sexo;
        }

      
        //metod Getters & Settters(fim)


      
    }
    
}
