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
    

    public partial class FrmClassificacao : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        const int constCodigo = 0;
        const int constNome = 1;
        const int constIdadeLimite = 2;
        const int constDescricao = 3;
        bool blnSucesso = false;


        ClassificacaoCommand classificacaoCommand = new ClassificacaoCommand();
        public FrmClassificacao()
        {
            InitializeComponent();
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtDescricao.Text == "" || txtLimite.Text == "" || txtNome.Text == "" )
            {
                MessageBox.Show("Existem campos sem dados !!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClassificacaoModel classificacaoModel = new ClassificacaoModel();
                classificacaoModel.Codigo = txtCodigo.Text == "" ? 0 : Convert.ToInt32(txtCodigo.Text);
                classificacaoModel.Nome = txtNome.Text;
                classificacaoModel.IdadeMaxima = txtLimite.Text;
                classificacaoModel.Descricao = txtDescricao.Text;
                if (txtCodigo.Text == "")
                {
                    blnSucesso = classificacaoCommand.Insert(classificacaoModel);
                    if (blnSucesso)
                        MessageBox.Show("Inclusão realizada com sucesso!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Erro :" + classificacaoCommand.strMensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    blnSucesso = classificacaoCommand.Update(classificacaoModel);
                    if (blnSucesso)
                        MessageBox.Show("Alteração realizada com sucesso!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Erro :" + classificacaoCommand.strMensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                dgvClassificacao.DataSource = classificacaoCommand.Consulta();
                Limpar();

            }

        }

        void Limpar()
        {
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            txtNome.Text = "";
            txtLimite.Text = "";
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
                    ClassificacaoModel classificacaoModel = new ClassificacaoModel();
                    classificacaoModel.Codigo = txtCodigo.Text == "" ? 0 : Convert.ToInt32(txtCodigo.Text);
                    classificacaoModel.Descricao = txtDescricao.Text;
                    classificacaoModel.Nome = txtNome.Text;
                    classificacaoModel.IdadeMaxima = txtLimite.Text;
                    blnSucesso = classificacaoCommand.Delete(classificacaoModel);
                    if (blnSucesso)
                        MessageBox.Show("Exclusão realizada com sucesso!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Erro :" + classificacaoCommand.strMensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                dgvClassificacao.DataSource = classificacaoCommand.Consulta();
                Limpar();

            }

        }

        private void gridClassificacao_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = gridClassificacao.GetDataRow(gridClassificacao.GetSelectedRows()[0]);

            if (row == null || row[0].ToString() == "")
                return;

            txtCodigo.Text = row[constCodigo].ToString();
            txtNome.Text = row[constNome].ToString();
            txtLimite.Text = row[constIdadeLimite].ToString();
            txtDescricao.Text = row[constDescricao].ToString();

        }

        private void FrmClassificacao_Load(object sender, EventArgs e)
        {
            dgvClassificacao.DataSource = classificacaoCommand.Consulta();
        }
    }
}