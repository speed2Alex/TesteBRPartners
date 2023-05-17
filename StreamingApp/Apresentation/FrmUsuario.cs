using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using StreamingApp.DAL;
using StreamingApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingApp.Apresentation
{
    public partial class FrmUsuario : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        const int constCodigo = 0;
        const int constNome = 1;
        const int constIdade = 2;
        const int constEmail = 3;
        const int constCodigoSexo = 4;
        const int constSexo = 5;
        const int constCodigoGenero = 6;
        const int constGenero = 7;
        const int constSenha = 8;


        bool blnSucesso = false;

        GeneroCommand generoCommand = new GeneroCommand();
        SexoCommand sexoCommand = new SexoCommand();
        UsuarioCommand usuarioCommand = new UsuarioCommand();
        public FrmUsuario()
        {
            InitializeComponent();

        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNome.Text == "" || txtIdade.Text == "" || txtEmail.Text == "" ||
                cboGenero.SelectedIndex == 0 || cboSexo.SelectedIndex == 0 || txtSenha.Text == "" ||
                txtConfirma.Text == "")
            {
                MessageBox.Show("Existem campos não informados !!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtSenha.Text != txtConfirma.Text)
                {
                    MessageBox.Show("Senhas informadas não batem !!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                else
                {
                    UsuarioModel usuarioModel = new UsuarioModel();
                    usuarioModel.Codigo = txtCodigo.Text == "" ? 0 : Convert.ToInt32(txtCodigo.Text);
                    usuarioModel.Nome = txtNome.Text;
                    usuarioModel.Idade = txtIdade.Text;
                    usuarioModel.Email = txtEmail.Text;
                    usuarioModel.CodigoSexo = Convert.ToInt32(cboSexo.SelectedValue);
                    usuarioModel.CodigoGenero = Convert.ToInt32(cboGenero.SelectedValue);
                    usuarioModel.Senha = txtSenha.Text;

                    if (txtCodigo.Text == "")
                    {
                        blnSucesso = usuarioCommand.Insert(usuarioModel);
                        if (blnSucesso)
                            MessageBox.Show("Inclusão realizada com sucesso !!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Erro :" + generoCommand.strMensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        blnSucesso = usuarioCommand.Update(usuarioModel);
                        if (blnSucesso)
                            MessageBox.Show("Alteração realizada com sucesso!!!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Erro :" + generoCommand.strMensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dgvUsuario.DataSource = usuarioCommand.Consulta();
                    Limpar();

                }

            }


        }

        void Limpar()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtIdade.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtConfirma.Text = "";
            CarregarComboGenero();
            CarregarComboSexo();

        }


        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CarregarComboGenero();
            CarregarComboSexo();
            dgvUsuario.DataSource = usuarioCommand.Consulta();
        }
        void CarregarComboGenero()
        {
            DataTable table = new DataTable();
            table = generoCommand.Consulta();
            DataRow linha = table.NewRow();
            linha["descricao"] = "Selecione";
            table.Rows.InsertAt(linha, 0);
            cboGenero.DataSource = table;

            cboGenero.DisplayMember = "descricao";
            cboGenero.ValueMember = "codigo";
            cboGenero.SelectedIndex = 0;
        }
        void CarregarComboSexo()
        {
            DataTable table = new DataTable();
            table = sexoCommand.Consulta();
            DataRow linha = table.NewRow();
            linha["descricao"] = "Selecione";
            table.Rows.InsertAt(linha, 0);
            cboSexo.DataSource = table;

            cboSexo.DisplayMember = "descricao";
            cboSexo.ValueMember = "codigo";
            cboSexo.SelectedIndex = 0;
        }

        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Limpar();

        }

        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Registro não selecionado !!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Deseja realmente Excluir o registro ?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UsuarioModel usuarioModel = new UsuarioModel();
                    usuarioModel.Codigo = txtCodigo.Text == "" ? 0 : Convert.ToInt32(txtCodigo.Text);
                    usuarioModel.Nome = txtNome.Text;
                    usuarioModel.Idade = txtIdade.Text;
                    usuarioModel.Email = txtEmail.Text;
                    usuarioModel.CodigoSexo = Convert.ToInt32(cboSexo.SelectedValue);
                    usuarioModel.CodigoGenero = Convert.ToInt32(cboGenero.SelectedValue);
                    usuarioModel.Senha = txtSenha.Text;
                    blnSucesso = usuarioCommand.Delete(usuarioModel);
                    if (blnSucesso)
                        MessageBox.Show("Exclusão realizada com sucesso!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Erro :" + generoCommand.strMensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                dgvUsuario.DataSource = usuarioCommand.Consulta();
                Limpar();

            }

        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void gridUsuario_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = gridUsuario.GetDataRow(gridUsuario.GetSelectedRows()[0]);

            if (row == null || row[0].ToString() == "")
                return;


            txtCodigo.Text = row[constCodigo].ToString();
            txtNome.Text = row[constNome].ToString();
            txtIdade.Text = row[constIdade].ToString();
            txtEmail.Text = row[constEmail].ToString();
            cboSexo.SelectedValue = Convert.ToInt32(row[constCodigoSexo].ToString());
            cboGenero.SelectedValue = Convert.ToInt32(row[constCodigoGenero].ToString());
            txtCodigo.Text = row[constCodigo].ToString();
            txtSenha.Text = row[constSenha].ToString();
            txtConfirma.Text = row[constSenha].ToString();

        }
    }
}