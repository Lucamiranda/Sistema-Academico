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
    public partial class frmPeriodoConsultar : Form
    {
        private clsPeriodosRegras periodosRegras = new clsPeriodosRegras();
        private frmPeriodosPesquisa PPesquisa = new frmPeriodosPesquisa();
        private clsPeriodos periodo = new clsPeriodos();


        public frmPeriodoConsultar()
        {

            InitializeComponent();
            PPesquisa = new frmPeriodosPesquisa();

        }

        public void Limpar()
        {
            txtIdcod.Text = "";
            txtPeriodo.Text = "";
            txtSigla.Text = "";
        }

        private void btExcluirPer_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdcod.Text == String.Empty || (txtIdcod.Text.Trim() == String.Empty))
                {
                    MessageBox.Show("FAÇA UMA CONSULTA ANTES DE EXCLUIR!!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPeriodo.Focus();
                }
                else
                {
                    periodosRegras.Excluir(Int32.Parse(txtIdcod.Text));
                    txtIdcod.Focus();
                    MessageBox.Show("PERIODO EXCLUIDO!!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
            }
            catch
            {
                MessageBox.Show("PERIODO SENDO UTILIZADO, NÃO É POSSIVEL EXCLUIR!", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btConsultarPer_Click(object sender, EventArgs e)
        {
            PPesquisa.ShowDialog();

            if (PPesquisa.Periodos.Codigo >= 0)
            {
                txtIdcod.Text = PPesquisa.Periodos.Codigo.ToString();
                txtPeriodo.Text = PPesquisa.Periodos.Nome.ToString();
                txtSigla.Text = PPesquisa.Periodos.Siglas.ToString();
            }

        }

        private void btAlerarPer_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdcod.Text == String.Empty)
                {
                    MessageBox.Show("FAÇA UMA CONSULTA ANTES DE ALTERAR", "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    periodo.Codigo = Int16.Parse(txtIdcod.Text);
                    periodo.Nome = txtPeriodo.Text;
                    periodo.Siglas = txtSigla.Text;

                    periodosRegras.Atualizar(periodo);
                    MessageBox.Show("CADASTRO ATUALIZADO", "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPeriodo.Focus();
                    Limpar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ALTERAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
