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
    public partial class frmCursoConsultar : Form
    {
        private clsPeriodosRegras PeriodosDal;
        private void carregarComboPeriodo()
        {
            cbPeriodo.DataSource = PeriodosDal.ListarTodos();
            cbPeriodo.DisplayMember = "pernome";
            cbPeriodo.ValueMember = "perid";
        }
        public frmCursoConsultar()
        {
            InitializeComponent();

        }

        public void Limpar()
        {
            txtCodCurso.Text = "";
            txtSiglaCurso.Text = "";
            txtCurso.Text = "";
            txtObsCurso.Text = "";

        }

        private void btExcluirCur_Click(object sender, EventArgs e)
        {
            if (txtCodCurso.Text == String.Empty || (txtCodCurso.Text.Trim() == String.Empty))
            {
                MessageBox.Show("FAÇA UMA CONSULTA ANTES DE EXCLUIR!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodCurso.Focus();
            }
            else
            {

                clsCursosRegras curso = new clsCursosRegras();
                curso.Excluir(Int32.Parse(txtCodCurso.Text));
                Limpar();                
                txtCodCurso.Focus();

                MessageBox.Show("CURSO EXCLUIDO!!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btAlerarCur_Click(object sender, EventArgs e)
        {
            if (txtCodCurso.Text == String.Empty)
            {
                MessageBox.Show("FAÇA UMA CONSULTA ANTES DE ALTERAR!", "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                clsCursos curso = new clsCursos();

                curso.Codigo = Int32.Parse(txtCodCurso.Text);
                curso.Curso = txtCurso.Text;
                curso.Siglas = txtSiglaCurso.Text;
                curso.Observacao = txtObsCurso.Text;
                curso.CodigoPeriodo = Int32.Parse(cbPeriodo.SelectedValue.ToString());

                clsCursosRegras cursodal = new clsCursosRegras();
                cursodal.Atualizar(curso);
                MessageBox.Show("CADASTRO ATUALIZADO", "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
        }

        private void btConsultarCur_Click(object sender, EventArgs e)
        {
            frmCursoPesquisa PCurso = new frmCursoPesquisa();
            PCurso.ShowDialog();

            if (PCurso.Curso.Codigo >= 0)
            {
                txtCodCurso.Text = PCurso.Curso.Codigo.ToString();
                txtCurso.Text = PCurso.Curso.Curso.ToString();
                txtSiglaCurso.Text = PCurso.Curso.Siglas.ToString();
                txtObsCurso.Text = PCurso.Curso.Observacao.ToString();
                cbPeriodo.SelectedValue = PCurso.Curso.CodigoPeriodo.ToString();

            }
//            if (PCurso.Curso.Codigo ==-1)
//            {
//                txtCodCurso.Text ="";
//                txtCurso.Text = "";
//                txtSiglaCurso.Text = "";
//                txtObsCurso.Text = "";
//                txtPeriodo.Text = "";
//            }

        }

        private void cbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCursoConsultar_Load(object sender, EventArgs e)
        {
            PeriodosDal = new clsPeriodosRegras();
            carregarComboPeriodo();
        }
    }
}
