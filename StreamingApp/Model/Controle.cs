using StreamingApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingApp.Model
{
    public class Controle
    {
        public bool blnsucesso = false;
        public string strMensagem = "";
        public bool Login(string email, string senha)
        {
            
            LoginCommand loginCommand = new LoginCommand();
            blnsucesso = loginCommand.Login(email, senha);
            if (!loginCommand.strMensagem.Equals(""))
            {
                this.strMensagem = loginCommand.strMensagem;
            }
            return blnsucesso;
        }

    }
}
