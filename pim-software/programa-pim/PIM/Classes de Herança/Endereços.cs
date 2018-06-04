using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM
{
    public class Endereços
    {

        private String End_rua; //faltando
        private String End_num; //faltando
        private String End_bairro;//falatando
        private String End_cidade;//faltando
        private String End_estado;//faltando
        private String CEP;//faltando


        public String getRua(String rua)
        {
            return End_rua;
        }

        public String SetRua(String rua)
        {
            return this.End_rua = rua;
        }

        public String getNum(String num)
        {
            return End_num;
        }

        public String SetNum(String num)
        {
           return this.End_num = num;
        }

        public String getBairro(String bairro)
        {
            return End_bairro;
        }

        public String setBairro(String bairro)
        {
           return this.End_bairro = bairro;
        }


        public String getCidade(String cidade)
        {
            return End_cidade;
        }

        public String SetCidade(String cidade)
        {
            return this.End_cidade = cidade;
        }

        public String getEstado(String estado)
        {
            return End_estado;
        }

        public String SetEstado(String estado)
        {
            return this.End_estado = estado;
        }

        public String getCEP(String cep)
        {
            return CEP;
        }

        public String SetCEP(String cep)
        {
           return this.CEP = cep;
        }

        /*public Endereços(string rua, string num, string bairro, string cidade, string estado, string cep)
        {
            this.End_rua = rua;
            this.End_num = num;
            this.End_bairro = bairro;
            this.End_cidade = cidade;
            this.End_estado = estado;
            this.CEP = cep;
        } */
    }
}
