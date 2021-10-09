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
    public partial class frmPeriodos : Form
    {
        public frmPeriodos()
        {
            InitializeComponent();
        }

        public void Limpar()
        {
            txtIdcod.Text = "";
            txtPeriodo.Text = "";
            txtSigla.Text = "";
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                   if (txtIdcod.Text == String.Empty)
                    {
                        clsPeriodosRegras periodosRegras = new clsPeriodosRegras();
                        clsPeriodos periodo = new clsPeriodos();

                        txtIdcod.Text = periodosRegras.ObterProximoID().ToString();

                        periodo.Codigo = Int16.Parse(txtIdcod.Text);
                        periodo.Nome = txtPeriodo.Text;
                        periodo.Siglas = txtSigla.Text;

                        periodosRegras.Salvar(periodo);
                        MessageBox.Show("CADASTRO EFETUADO", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                        txtPeriodo.Focus();
                    }
            }
            catch (Exception ex)
            {
                Limpar();
                MessageBox.Show(ex.Message.ToString(), "PERIODO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPeriodo.Focus();
            }
           
        }
    }
}
