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

namespace PIM
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void UserTbx_TextChanged(object sender, EventArgs e)
        {


        }

        private void PasswdTbx_TextChanged(object sender, EventArgs e)
        {


        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            




            Usuario usuario = new Usuario();

            String str = @"server=localhost;database=PIM;userid=root;password=1234;";

            MySqlConnection conn = null;

            conn = new MySqlConnection(str);

            if (usuario.ValidarsenhaeUsuario(UserTbx.Text, PasswdTbx.Text))
            {

                MenuPrincipal mainMenu = new MenuPrincipal();
                this.Hide();
                mainMenu.ShowDialog();

            }
            else
            {
                MessageBox.Show("senha ou usuario incorreto");
            }

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
