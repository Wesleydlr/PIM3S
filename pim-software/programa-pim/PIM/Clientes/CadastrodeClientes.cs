using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM
{
    public partial class CadastrodeClientes : Form
    {
        VisualizarClientesCadastrados visualizarCliente = new VisualizarClientesCadastrados();

        string url = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml";

        Cliente cliente = new Cliente();
        private String nome, RG, cpf, email;
        private int DataNascimento;
        Telefone telefone = new Telefone();
        public String ddd, tel_num;

        Endereços endereço = new Endereços();
        public String rua, num, bairro, cidade, estado, cep;

        private void TbxTelefone_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbxRua_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbxBairro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbxCep_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbxCidade_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbxEstadoCliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbxDDD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbxCPF_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbxEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbxCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void TbxCep_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }

        public void tbxnascimento_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TbxRg_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxnascimento_TextChanged(object sender, EventArgs e)
        {
            
        }

        public CadastrodeClientes()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TbxNome_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            
            tel_num = TbxTelefone.Text;
            telefone.setTel_num(tel_num);

            rua = tbxRua.Text;
            endereço.SetRua(rua);

            bairro = TbxBairro.Text;
            endereço.setBairro(bairro);

            cep = TbxCep.Text;
            endereço.SetCEP(cep);

            num = tbxNumero.Text;
            endereço.SetNum(num);

            cidade = TbxCidade.Text;
            endereço.SetCidade(cidade);

            estado = TbxEstadoCliente.Text;
            endereço.SetEstado(estado);


            //TbxDDD.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            ddd = TbxDDD.Text;
            telefone.setDDD(ddd);

            cpf = TbxCPF.Text;
            cliente.setCPF(cpf);

            email = TbxEmail.Text;
            cliente.setEmail(email);

            RG = TbxRg.Text;
            cliente.setRG(RG);

            DataNascimento = Convert.ToInt32(tbxnascimento.Text);

            cliente.setDta_nasc(DataNascimento);

            nome = TbxNome.Text;
            cliente.setNome(nome);

            DAOCliente daocliente = new DAOCliente();
            daocliente.adicionar(cliente, telefone, endereço);

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
                TbxEstadoCliente.Text = dsRetornaEndereco.Tables[0].Rows[0]["uf"].ToString();
                tbxRua.Text = dsRetornaEndereco.Tables[0].Rows[0]["logradouro"].ToString();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
            visualizarCliente.Show();
            this.Close();
        }
    }
}
