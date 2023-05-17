using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingApp.Apresentation
{
    public partial class FrmMDI : DevExpress.XtraEditors.XtraForm
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void usuriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair da aplicação ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSexo frmSexo = new FrmSexo();
            frmSexo.MdiParent = this;
            frmSexo.Show();

        }

        private void generosFilmesSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenero frmGenero = new FrmGenero();
            frmGenero.MdiParent = this;
            frmGenero.Show();

        }

        private void classificaçãoEtáriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClassificacao frmClassificacao = new FrmClassificacao();
            frmClassificacao.MdiParent = this;
            frmClassificacao.Show();
        }

        private void filmesSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStreaming frmStreaming = new FrmStreaming();
            frmStreaming.MdiParent = this;
            frmStreaming.Show();

        }

        private void tipoDeStreamingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoStreaming frmTipoStreaming = new FrmTipoStreaming();
            frmTipoStreaming.MdiParent = this;
            frmTipoStreaming.Show();
        }
    }
}