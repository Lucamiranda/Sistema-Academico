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
    public partial class frmDisciplinaConsultar : Form
    {
        public frmDisciplinaConsultar()
        {
            InitializeComponent();
        }

        public void  Limpar()
        {
            txtCodDisciplina.Text = "";
            txtDisciplina.Text = "";
            txtObsDisciplina.Text = "";
            txtSiglaDisciplina.Text = "";
        }

        private void btExcluirDis_Click(object sender, EventArgs e)
        {

                if (txtCodDisciplina.Text == String.Empty || (txtCodDisciplina.Text.Trim() == String.Empty))
                {
                    MessageBox.Show("FAÇA UMA CONSULTA ANTES DE EXCLUIR!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodDisciplina.Focus();
                }
                else
                {

                    clsDisciplinaRegra dis = new clsDisciplinaRegra();
                    dis.Excluir(Int32.Parse(txtCodDisciplina.Text));
                    Limpar();
                    txtDisciplina.Focus();

                    MessageBox.Show("DISCIPLINA EXCLUIDA!!", "EXCLUIR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

        }

        private void btAlerarDis_Click(object sender, EventArgs e)
        {
            if (txtCodDisciplina.Text == String.Empty)
            {
                MessageBox.Show("FAÇA UMA CONSULTA ANTES DE ALTERAR!", "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                clsDisciplinas dis = new clsDisciplinas();


                dis.Codigo = Int32.Parse(txtCodDisciplina.Text);
                dis.Disciplinas = txtDisciplina.Text;
                dis.Siglas = txtSiglaDisciplina.Text;
                dis.Observacao = txtObsDisciplina.Text;

                clsDisciplinaRegra discdal = new clsDisciplinaRegra();
                discdal.Atualizar(dis);
                MessageBox.Show("CADASTRO ATUALIZADO", "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
        }

        private void btConsultarDis_Click(object sender, EventArgs e)
        {
            frmDisciplinaPesquisa PDisciplinas = new frmDisciplinaPesquisa();
            PDisciplinas.ShowDialog();

            if (PDisciplinas.Disciplinas.Codigo >= 0)
            {
                txtCodDisciplina.Text = PDisciplinas.Disciplinas.Codigo.ToString();
                txtDisciplina.Text = PDisciplinas.Disciplinas.Disciplinas.ToString();
                txtSiglaDisciplina.Text = PDisciplinas.Disciplinas.Siglas.ToString();
                txtObsDisciplina.Text = PDisciplinas.Disciplinas.Observacao.ToString();
            }

        }
    }
}
