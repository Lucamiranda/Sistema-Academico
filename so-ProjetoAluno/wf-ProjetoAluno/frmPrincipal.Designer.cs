
namespace wf_ProjetoAluno
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuCadastrarCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuCadastrarDisciplinas = new System.Windows.Forms.ToolStripMenuItem();
            this.periodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuConsultarCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuConsultarDisciplinas = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuConsultarPeriodos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuAjudaSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrar,
            this.menuConsultar,
            this.menuAjuda,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastrar
            // 
            this.menuCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuCadastrarCursos,
            this.subMenuCadastrarDisciplinas,
            this.periodosToolStripMenuItem});
            this.menuCadastrar.Name = "menuCadastrar";
            this.menuCadastrar.Size = new System.Drawing.Size(69, 20);
            this.menuCadastrar.Text = "Cadastrar";
            this.menuCadastrar.Click += new System.EventHandler(this.incluirToolStripMenuItem_Click);
            // 
            // subMenuCadastrarCursos
            // 
            this.subMenuCadastrarCursos.Name = "subMenuCadastrarCursos";
            this.subMenuCadastrarCursos.Size = new System.Drawing.Size(130, 22);
            this.subMenuCadastrarCursos.Text = "Cursos";
            this.subMenuCadastrarCursos.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // subMenuCadastrarDisciplinas
            // 
            this.subMenuCadastrarDisciplinas.Name = "subMenuCadastrarDisciplinas";
            this.subMenuCadastrarDisciplinas.Size = new System.Drawing.Size(130, 22);
            this.subMenuCadastrarDisciplinas.Text = "Disciplinas";
            this.subMenuCadastrarDisciplinas.Click += new System.EventHandler(this.disciplinasToolStripMenuItem_Click);
            // 
            // periodosToolStripMenuItem
            // 
            this.periodosToolStripMenuItem.Name = "periodosToolStripMenuItem";
            this.periodosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.periodosToolStripMenuItem.Text = "Periodos";
            this.periodosToolStripMenuItem.Click += new System.EventHandler(this.periodosToolStripMenuItem_Click_1);
            // 
            // menuConsultar
            // 
            this.menuConsultar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuConsultarCursos,
            this.subMenuConsultarDisciplinas,
            this.subMenuConsultarPeriodos});
            this.menuConsultar.Name = "menuConsultar";
            this.menuConsultar.Size = new System.Drawing.Size(70, 20);
            this.menuConsultar.Text = "Consultar";
            // 
            // subMenuConsultarCursos
            // 
            this.subMenuConsultarCursos.Name = "subMenuConsultarCursos";
            this.subMenuConsultarCursos.Size = new System.Drawing.Size(130, 22);
            this.subMenuConsultarCursos.Text = "Cursos";
            this.subMenuConsultarCursos.Click += new System.EventHandler(this.subMenuConsultarCursos_Click);
            // 
            // subMenuConsultarDisciplinas
            // 
            this.subMenuConsultarDisciplinas.Name = "subMenuConsultarDisciplinas";
            this.subMenuConsultarDisciplinas.Size = new System.Drawing.Size(130, 22);
            this.subMenuConsultarDisciplinas.Text = "Discipilnas";
            this.subMenuConsultarDisciplinas.Click += new System.EventHandler(this.subMenuConsultarDisciplinas_Click);
            // 
            // subMenuConsultarPeriodos
            // 
            this.subMenuConsultarPeriodos.Name = "subMenuConsultarPeriodos";
            this.subMenuConsultarPeriodos.Size = new System.Drawing.Size(130, 22);
            this.subMenuConsultarPeriodos.Text = "Periodos";
            this.subMenuConsultarPeriodos.Click += new System.EventHandler(this.subMenuConsultarPeriodos_Click);
            // 
            // menuAjuda
            // 
            this.menuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuAjudaSobre});
            this.menuAjuda.Name = "menuAjuda";
            this.menuAjuda.Size = new System.Drawing.Size(50, 20);
            this.menuAjuda.Text = "Ajuda";
            // 
            // subMenuAjudaSobre
            // 
            this.subMenuAjudaSobre.Name = "subMenuAjudaSobre";
            this.subMenuAjudaSobre.Size = new System.Drawing.Size(104, 22);
            this.subMenuAjudaSobre.Text = "Sobre";
            this.subMenuAjudaSobre.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Acadêmico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAjuda;
        private System.Windows.Forms.ToolStripMenuItem subMenuAjudaSobre;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrar;
        private System.Windows.Forms.ToolStripMenuItem subMenuCadastrarCursos;
        private System.Windows.Forms.ToolStripMenuItem subMenuCadastrarDisciplinas;
        private System.Windows.Forms.ToolStripMenuItem periodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuConsultar;
        private System.Windows.Forms.ToolStripMenuItem subMenuConsultarCursos;
        private System.Windows.Forms.ToolStripMenuItem subMenuConsultarDisciplinas;
        private System.Windows.Forms.ToolStripMenuItem subMenuConsultarPeriodos;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

