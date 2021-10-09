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
    public partial class frmPeriodosPesquisa : Form
    {

        public clsPeriodos Periodos = new clsPeriodos();

        private clsPeriodosRegras _PeriodosDal;
        private void carregarGridPeriodos()
        {
            _PeriodosDal = new clsPeriodosRegras();
            dgPeriodos.AutoGenerateColumns = true;
            dgPeriodos.DataSource = _PeriodosDal.ListarTodos();
        }
        public frmPeriodosPesquisa()
        {
            InitializeComponent();
            Periodos.Codigo = -1;
            carregarGridPeriodos();
            FormatarGridPeriodos();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            carregarGridPeriodos();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            Int32  vI = 0;
            vI = dgPeriodos.CurrentRow.Index;
            Periodos.Codigo = Int32.Parse(dgPeriodos[0, vI].Value.ToString());
            Periodos.Nome = dgPeriodos[1, vI].Value.ToString();
            Periodos.Siglas = dgPeriodos[2, vI].Value.ToString();

            this.Close();
        }

        private void FormatarGridPeriodos()
        {
            dgPeriodos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgPeriodos.ScrollBars = ScrollBars.Vertical;
            dgPeriodos.Columns[0].HeaderText = "CÓDIGO";
            dgPeriodos.Columns[1].HeaderText = "PERIODOS";
            dgPeriodos.Columns[2].HeaderText = "SIGLAS";
            dgPeriodos.Columns[0].Width = 100;
            dgPeriodos.Columns[1].Width = 120;
            dgPeriodos.Columns[2].Width = 122;
        }

        private void dgPeriodos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPeriodosPesquisa_Load(object sender, EventArgs e)
        {
            carregarGridPeriodos();
        }
    }
}
