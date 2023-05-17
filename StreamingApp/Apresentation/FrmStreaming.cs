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
using static System.Net.Mime.MediaTypeNames;

namespace StreamingApp.Apresentation
{
    public partial class FrmStreaming : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        const int constCodigo = 0;
        const int constNome = 1;
        const int constLancamento = 2;
        const int constNota = 3;
        const int constDescricao = 4;
        const int constCodigoClassificacao = 5;
        const int constClassificacao = 6;
        const int constCodigoGenero = 7;
        const int constGenero = 8;
        const int constCodigoTipoStreaming = 9;
        const int constTipoStreaming = 10;


        bool blnSucesso = false;

        GeneroCommand generoCommand = new GeneroCommand();
        ClassificacaoCommand classificacaoCommand = new ClassificacaoCommand();
        TipoStreamingCommand tipoStreamingCommand = new TipoStreamingCommand();
        StreamingCommand streamingCommand = new StreamingCommand();

        public FrmStreaming()
        {
            InitializeComponent();

        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtNome.Text == "" || dtLancamento.Text == "" || txtDescricao.Text == "" ||
                cboClassificacao.SelectedIndex == 0 || cboGenero.SelectedIndex == 0  ||
                cboTipoStreaming.SelectedIndex == 0)
            {
                MessageBox.Show("Existem campos não informados !!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                StreamingModel streamingModel = new StreamingModel();
                streamingModel.Codigo = txtCodigo.Text == "" ? 0 : Convert.ToInt32(txtCodigo.Text);
                streamingModel.Nome = txtNome.Text;
                streamingModel.Lancamento = Convert.ToDateTime(dtLancamento.Text);
                streamingModel.Nota = Convert.ToInt32(txtNota.Text);
                streamingModel.Descricao = txtDescricao.Text;
                streamingModel.CodigoClassificacao = Convert.ToInt32(cboClassificacao.SelectedValue);
                streamingModel.CodigoGenero = Convert.ToInt32(cboGenero.SelectedValue);
                streamingModel.CodigoTipoStreaming = Convert.ToInt32(cboTipoStreaming.SelectedValue);

                if (txtCodigo.Text == "")
                {
                    blnSucesso = streamingCommand.Insert(streamingModel);
                    if (blnSucesso)
                        MessageBox.Show("Inclusão realizada com sucesso !!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Erro :" + streamingCommand.strMensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    blnSucesso = streamingCommand.Update(streamingModel);
                    if (blnSucesso)
                        MessageBox.Show("Alteração realizada com sucesso!!!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Erro :" + streamingCommand.strMensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dgvStreaming.DataSource = streamingCommand.Consulta();
                Limpar();

            }



        }

        void Limpar()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            dtLancamento.Text = "";
            txtNota.Text = "";
            txtDescricao.Text = "";
            CarregarComboGenero();
            CarregarComboClassificacao();
            CarregarComboTipoStreaming();

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
        void CarregarComboClassificacao()
        {
            DataTable table = new DataTable();
            table = classificacaoCommand.Consulta();
            DataRow linha = table.NewRow();
            linha["descricao"] = "Selecione";
            table.Rows.InsertAt(linha, 0);
            cboClassificacao.DataSource = table;

            cboClassificacao.DisplayMember = "descricao";
            cboClassificacao.ValueMember = "codigo";
            cboClassificacao.SelectedIndex = 0;
        }

        void CarregarComboTipoStreaming()
        {
            DataTable table = new DataTable();
            table = tipoStreamingCommand.Consulta();
            DataRow linha = table.NewRow();
            linha["descricao"] = "Selecione";
            table.Rows.InsertAt(linha, 0);
            cboTipoStreaming.DataSource = table;

            cboTipoStreaming.DisplayMember = "descricao";
            cboTipoStreaming.ValueMember = "codigo";
            cboTipoStreaming.SelectedIndex = 0;
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
                    StreamingModel streamingModel = new StreamingModel();
                    streamingModel.Codigo = txtCodigo.Text == "" ? 0 : Convert.ToInt32(txtCodigo.Text);
                    streamingModel.Nome = txtNome.Text;
                    streamingModel.Lancamento = Convert.ToDateTime(dtLancamento.Text);
                    streamingModel.Nota = Convert.ToInt32(txtNota.Text);
                    streamingModel.Descricao = txtDescricao.Text;
                    streamingModel.CodigoClassificacao = Convert.ToInt32(cboClassificacao.SelectedValue);
                    streamingModel.CodigoGenero = Convert.ToInt32(cboGenero.SelectedValue);
                    streamingModel.CodigoTipoStreaming = Convert.ToInt32(cboTipoStreaming.SelectedValue);
                    blnSucesso = streamingCommand.Delete(streamingModel);
                    if (blnSucesso)
                        MessageBox.Show("Exclusão realizada com sucesso!!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Erro :" + streamingCommand.strMensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                dgvStreaming.DataSource = streamingCommand.Consulta();
                Limpar();

            }

        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
        }

        private void gridStreaming_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = gridStreaming.GetDataRow(gridStreaming.GetSelectedRows()[0]);

            if (row == null || row[0].ToString() == "")
                return;


            txtCodigo.Text = row[constCodigo].ToString();
            txtNome.Text = row[constNome].ToString();
            dtLancamento.Text = row[constLancamento].ToString();
            txtNota.Text = row[constNota].ToString();
            txtDescricao.Text = row[constDescricao].ToString();
            cboClassificacao.SelectedValue = Convert.ToInt32(row[constCodigoClassificacao].ToString());
            cboGenero.SelectedValue = Convert.ToInt32(row[constCodigoGenero].ToString());
            cboTipoStreaming.SelectedValue = Convert.ToInt32(row[constCodigoTipoStreaming].ToString());

        }

        private void FrmStreaming_Load(object sender, EventArgs e)
        {
            CarregarComboGenero();
            CarregarComboClassificacao();
            CarregarComboTipoStreaming();
            dgvStreaming.DataSource = streamingCommand.Consulta();

        }

    }
}