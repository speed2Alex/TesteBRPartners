
namespace StreamingApp.Apresentation
{
    partial class FrmMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sexoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generosFilmesSeriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classificaçãoEtáriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesSeriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeStreamingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuriosToolStripMenuItem,
            this.sexoToolStripMenuItem,
            this.generosFilmesSeriesToolStripMenuItem,
            this.classificaçãoEtáriaToolStripMenuItem,
            this.tipoDeStreamingToolStripMenuItem,
            this.filmesSeriesToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // usuriosToolStripMenuItem
            // 
            this.usuriosToolStripMenuItem.Name = "usuriosToolStripMenuItem";
            this.usuriosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.usuriosToolStripMenuItem.Text = "Usuários";
            this.usuriosToolStripMenuItem.Click += new System.EventHandler(this.usuriosToolStripMenuItem_Click);
            // 
            // sexoToolStripMenuItem
            // 
            this.sexoToolStripMenuItem.Name = "sexoToolStripMenuItem";
            this.sexoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.sexoToolStripMenuItem.Text = "Sexo";
            this.sexoToolStripMenuItem.Click += new System.EventHandler(this.sexoToolStripMenuItem_Click);
            // 
            // generosFilmesSeriesToolStripMenuItem
            // 
            this.generosFilmesSeriesToolStripMenuItem.Name = "generosFilmesSeriesToolStripMenuItem";
            this.generosFilmesSeriesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.generosFilmesSeriesToolStripMenuItem.Text = "Generos Filmes / Series";
            this.generosFilmesSeriesToolStripMenuItem.Click += new System.EventHandler(this.generosFilmesSeriesToolStripMenuItem_Click);
            // 
            // classificaçãoEtáriaToolStripMenuItem
            // 
            this.classificaçãoEtáriaToolStripMenuItem.Name = "classificaçãoEtáriaToolStripMenuItem";
            this.classificaçãoEtáriaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.classificaçãoEtáriaToolStripMenuItem.Text = "Classificação Etária";
            this.classificaçãoEtáriaToolStripMenuItem.Click += new System.EventHandler(this.classificaçãoEtáriaToolStripMenuItem_Click);
            // 
            // filmesSeriesToolStripMenuItem
            // 
            this.filmesSeriesToolStripMenuItem.Name = "filmesSeriesToolStripMenuItem";
            this.filmesSeriesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.filmesSeriesToolStripMenuItem.Text = "Filmes / Series";
            this.filmesSeriesToolStripMenuItem.Click += new System.EventHandler(this.filmesSeriesToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tipoDeStreamingToolStripMenuItem
            // 
            this.tipoDeStreamingToolStripMenuItem.Name = "tipoDeStreamingToolStripMenuItem";
            this.tipoDeStreamingToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.tipoDeStreamingToolStripMenuItem.Text = "Tipo de Streaming";
            this.tipoDeStreamingToolStripMenuItem.Click += new System.EventHandler(this.tipoDeStreamingToolStripMenuItem_Click);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 268);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMDI";
            this.Text = "MDIForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sexoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generosFilmesSeriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmesSeriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classificaçãoEtáriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeStreamingToolStripMenuItem;
    }
}