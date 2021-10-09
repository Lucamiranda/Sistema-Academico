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
    public partial class frmDisciplinas : Form
    {
        public frmDisciplinas()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            txtDis.Text = "";
            txtCodDisciplina.Text = "";
            txtObsDis.Text = "";
            txtSiglaDis.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCadastrarDis_Click(object sender, EventArgs e)
        {

            if (txtDis.Text == String.Empty)
            {

                MessageBox.Show("INFORME A DISCIPLINA!", "DISCIPLINA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDis.Focus();
            }
            else
            {
                if (txtCodDisciplina.Text == String.Empty)
                {
                    clsDisciplinaRegra disDal = new clsDisciplinaRegra();
                    clsDisciplinas dis = new clsDisciplinas();

                    txtCodDisciplina.Text = disDal.ObterProximoID().ToString();

                    dis.Codigo = Int16.Parse(txtCodDisciplina.Text);
                    dis.Disciplinas = txtDis.Text;
                    dis.Siglas = txtSiglaDis.Text;
                    dis.Observacao = txtObsDis.Text;

                    disDal.Salvar(dis);
                    MessageBox.Show("CADASTRO EFETUADO", "CADASTRAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    txtSiglaDis.Focus();
                }
            }
        }
    }
}
