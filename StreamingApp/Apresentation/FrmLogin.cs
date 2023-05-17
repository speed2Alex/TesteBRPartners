using StreamingApp.Apresentation;
using StreamingApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingApp
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Login e Senha não informados !!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Controle controle = new Controle();
                controle.Login(txtEmail.Text, txtSenha.Text);
                if (controle.blnsucesso)
                {
                    FrmMDI mDIForm = new FrmMDI();
                    this.Hide();
                    mDIForm.Show();

                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha !!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
