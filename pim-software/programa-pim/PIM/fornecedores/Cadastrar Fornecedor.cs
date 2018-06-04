using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PIM.fornecedores
{
    public partial class Cadastrar_Fornecedor : Form
    {
        fornecedores.Visualizar_Fornecedor visualizarFornecedor = new fornecedores.Visualizar_Fornecedor();
        public Cadastrar_Fornecedor()
        {
            InitializeComponent();
        }

        string url = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml";

        Telefone telefone = new Telefone();
        public String ddd, tel_num;

        FornecedorClass fornecedor = new FornecedorClass();
        private String nome, cnpj, categoria, descricao, email;

        Endereços endereço = new Endereços();
        public String rua, num, bairro, cidade, estado, cep;

        private void TbxDDD_TextChanged(object sender, EventArgs e)
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

        private void ComBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TbxCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            

        }

        private void TbxCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void TbxCep_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            ddd = TbxDDD.Text;
            telefone.setDDD(ddd);

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

            categoria = ComBoxCategoria.Text;
            fornecedor.setCategoria(categoria);

            cnpj = TbxCNPJ.Mask;
            fornecedor.setCNPJ(cnpj);

            cep = TbxCep.Mask;
            endereço.SetCEP(cep);

            email = TbxEmail.Text;
            fornecedor.setEmail(email);

            descricao = TbxDescricao.Text;
            fornecedor.setDescricao(descricao);

            nome = TbxNome.Text;
            fornecedor.setNome(nome);

            estado = TbxEstado1.Text;
            endereço.SetEstado(estado);
            DAOFornecedor addfornecedor = new DAOFornecedor();

            addfornecedor.adicionar(fornecedor, telefone, endereço);
        }

        private void TbxEmail_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void TbxDescricao_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void TbxNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TbxCNPJ_TextChanged(object sender, EventArgs e)
        {
            
        }

       

        private void btnSair_Click(object sender, EventArgs e)
        {
            visualizarFornecedor.Show();
            this.Close();
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
                TbxEstado1.Text = dsRetornaEndereco.Tables[0].Rows[0]["uf"].ToString();
                tbxRua.Text = dsRetornaEndereco.Tables[0].Rows[0]["logradouro"].ToString();
            }
        }

        private void TbxEstado1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
