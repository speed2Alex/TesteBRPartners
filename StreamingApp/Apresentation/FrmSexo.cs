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
    public partial class FrmSexo : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        const int constCodigo = 0;
        const int constDescricao = 1;
        bool blnSucesso = false;

        SexoCommand sexoCommand = new SexoCommand();
        public FrmSexo()
        {
            InitializeComponent();

        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                MessageBox.Show("Descrição não informada !!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SexoModel sexoModel = new SexoModel();
                sexoModel.Codigo = txtCodigo.Text == "" ? 0 : Convert.ToInt32(txtCodigo.Text);
                sexoModel.Descricao = txtDescricao.Text;
                if (txtCodigo.Text == "")
                {
                    blnSucesso = sexoCommand.Insert(sexoModel);
                    if (blnSucesso)
                        MessageBox.Show("Inclusão realizada com sucesso!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Erro :" + sexoCommand.strMensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
                }
                else
                {
                    blnSucesso = sexoCommand.Update(sexoModel);
                    if (blnSucesso)
                        MessageBox.Show("Alteração realizada com sucesso !!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Erro :" + sexoCommand.strMensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                dgvSexo.DataSource = sexoCommand.Consulta();
                Limpar();

            }

        }

        void Limpar()
        {
            txtCodigo.Text = "";
            txtDescricao.Text = "";
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
                    SexoModel sexoModel = new SexoModel();
                    sexoModel.Codigo = txtCodigo.Text == "" ? 0 : Convert.ToInt32(txtCodigo.Text);
                    sexoModel.Descricao = txtDescricao.Text;
                    blnSucesso = sexoCommand.Delete(sexoModel);
                    if (blnSucesso)
                        MessageBox.Show("Exclusão realizada com sucesso !!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Erro :" + sexoCommand.strMensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                dgvSexo.DataSource = sexoCommand.Consulta();
                Limpar();

            }

        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void FrmSexo_Load(object sender, EventArgs e)
        {
            dgvSexo.DataSource = sexoCommand.Consulta();
        }

        private void gridSexo_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = gridSexo.GetDataRow(gridSexo.GetSelectedRows()[0]);

            if (row == null || row[0].ToString() == "")
                return;

            txtCodigo.Text = row[constCodigo].ToString();
            txtDescricao.Text = row[constDescricao].ToString();
        }

    }
}