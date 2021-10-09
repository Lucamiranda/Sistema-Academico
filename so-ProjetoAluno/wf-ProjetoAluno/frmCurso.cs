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
    public partial class frmCurso : Form
    {
        private clsCursosRegras cursosRegras = new clsCursosRegras();
        private clsPeriodosRegras periodoRegras = new clsPeriodosRegras();


        private void carregarComboPeriodo()
        {
            cbPeriodo.DataSource = periodoRegras.ListarTodos();
            cbPeriodo.DisplayMember = "pernome";
            cbPeriodo.ValueMember = "perid";
        }

        public frmCurso()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            txtCodCurso.Text = "";
            txtCurso.Text = "";
            txtObsCurso.Text = "";
            txtSiglaCurso.Text = "";
        }

        private void btCadastrarCurso_Click(object sender, EventArgs e)
        {
            try
            {         
                    if (txtCodCurso.Text == String.Empty)
                    {
                        clsCursos curso = new clsCursos();

                        txtCodCurso.Text = cursosRegras.ObterProximoID().ToString();

                        curso.Codigo = Int32.Parse(txtCodCurso.Text);
                        curso.Curso = txtCurso.Text;
                        curso.Siglas = txtSiglaCurso.Text;
                        curso.Observacao = txtObsCurso.Text;
                        curso.CodigoPeriodo = Int32.Parse(cbPeriodo.SelectedValue.ToString());

                        cursosRegras.Salvar(curso);
                        MessageBox.Show("CADASTRO EFETUADO", "CADASTRAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                        txtSiglaCurso.Focus();
                    }
            }
            catch (Exception ex)
            {
                txtCodCurso.Text =  "";
                MessageBox.Show(ex.Message.ToString(),"CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                            
        }
        private void frmCurso_Load(object sender, EventArgs e)
        {
                cursosRegras = new clsCursosRegras();
                carregarComboPeriodo();
        }
    }
}