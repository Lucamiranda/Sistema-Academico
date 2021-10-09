using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cl_regras;
using cl_modelos;

namespace wf_ProjetoAluno
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void aRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurso telaCurso = new frmCurso();
            telaCurso.ShowDialog();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisciplinas telaDisciplinas = new frmDisciplinas();
            telaDisciplinas.ShowDialog();


        }

        private void periodosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            frmPeriodos telaPeriodos = new frmPeriodos();
            telaPeriodos.ShowDialog();

        }
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projeto Sistema Acadêmico");
        }

        private void subMenuConsultarPeriodos_Click(object sender, EventArgs e)
        {
            frmPeriodoConsultar telaPeriodosConsultar = new frmPeriodoConsultar();
            telaPeriodosConsultar.ShowDialog();
        }

        private void subMenuConsultarDisciplinas_Click(object sender, EventArgs e)
        {
            frmDisciplinaConsultar telaDisciplinaConsultar = new frmDisciplinaConsultar();
            telaDisciplinaConsultar.ShowDialog();

        }

        private void subMenuConsultarCursos_Click(object sender, EventArgs e)
        {
            frmCursoConsultar telaCursoConsultar = new frmCursoConsultar();
            telaCursoConsultar.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin Sair = new frmLogin();
            this.Hide();
            Sair.ShowDialog();
        }
    }
}
