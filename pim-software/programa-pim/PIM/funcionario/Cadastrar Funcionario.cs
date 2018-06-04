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

namespace PIM
{
    public partial class Cadastrar_Funcionario : Form
    {
        string url = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml";
        Funcionarios funcionario = new Funcionarios();

        private String nome, ctps, rg,cpf,sexo;
        private int nv_acesso;
        private Int64 dta_nasc;
        Endereços endereço = new Endereços();

        private String rua, num, bairro, cidade, estado, cep;

        Telefone telefone = new Telefone();

        private String ddd, tel_num;

        public Cadastrar_Funcionario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Visualizar_Funcionario visualizarFuncionario = new Visualizar_Funcionario();
            visualizarFuncionario.Show();


            this.Close();
        }

        public void TbxNome_TextChanged(object sender, EventArgs e)
        {
             

        }

        private void tbxNascimento_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void TbxCargo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbxCPF_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void TbxTelefoneDDD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbxRG_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ComBoxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            tbxNascimento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            //var nascSemMask = tbxNascimento.Text;
            dta_nasc = Convert.ToInt32(tbxNascimento.Text);
        }

        private void TbxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void TbxRG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void TbxCTPS_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void TbxCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void TbxCep_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }
        
        private void LocalizarCEP()
        {
            DataSet dsRetornaEndereco = new DataSet();
            dsRetornaEndereco.ReadXml(url.Replace("@cep", TbxCep.Text));

            string retorno = dsRetornaEndereco.Tables[0].Rows[0]["resultado"].ToString();
            if (retorno == "0")
            {
                MessageBox.Show("CEP Invalido");
            }
            else
            {
                TbxBairro.Text = dsRetornaEndereco.Tables[0].Rows[0]["bairro"].ToString();
                TbxCidade.Text = dsRetornaEndereco.Tables[0].Rows[0]["cidade"].ToString();
                TbxEstado.Text = dsRetornaEndereco.Tables[0].Rows[0]["uf"].ToString();
                tbxRua.Text = dsRetornaEndereco.Tables[0].Rows[0]["logradouro"].ToString();
            }
        }

        private void TbxCep_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TbxCep_Leave_1(object sender, EventArgs e)
        {
            
        }

        private void TbxCep_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TbxCep_Leave_2(object sender, EventArgs e)
        {
            LocalizarCEP();
        }

        private void Cadastrar_Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void TbxTelefoneDDD_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TbxEstado_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Tbxctps_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void TbxTelefone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxRua_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void tbxNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbxBairro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbxCep_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbxCidade_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void TbxEstado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            nome = TbxNome.Text;
            funcionario.setNome(nome);

            nv_acesso = Convert.ToInt32(TbxCargo.Text);
            funcionario.setNiveldeAcesso(nv_acesso);

            ddd = TbxTelefoneDDD.Text;
            telefone.setDDD(ddd);

            sexo = Convert.ToString(ComBoxSexo.Text);
            funcionario.setSexo(sexo);

            funcionario.setDta_nasc(Convert.ToInt32(tbxNascimento.TextMaskFormat= MaskFormat.ExcludePromptAndLiterals));

            cpf = TbxCPF.Text;
            funcionario.setCPF(cpf);

            rg = TbxRG.Text;
            funcionario.setRG(rg);

            ctps = TbxCTPS.Text;
            funcionario.setCTPS(ctps);

            cep = TbxCep.Text;
            endereço.SetCEP(cep);

            estado = TbxEstado.Text;
            endereço.SetEstado(estado);

            tel_num = TbxTelefone.Text;
            telefone.setTel_num(tel_num);

            rua = tbxRua.Text;
            endereço.SetRua(rua);

            num = tbxNumero.Text;
            endereço.SetNum(num);

            bairro = TbxBairro.Text;
            endereço.setBairro(bairro);

            cidade = TbxCidade.Text;
            endereço.SetCidade(cidade);

            DAOFuncionario2 daofuncionario = new DAOFuncionario2();
            daofuncionario.adicionar(funcionario, telefone, endereço);
        }
    }
}



