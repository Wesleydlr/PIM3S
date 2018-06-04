using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM
{
    class Usuario
    {
        private string UserName = "adm";
        private string Senha = "123";

        public bool ValidarsenhaeUsuario(string UserName, string Senha)
        {
            return ((this.UserName == UserName) && (this.Senha == Senha));
        }

    }
}
