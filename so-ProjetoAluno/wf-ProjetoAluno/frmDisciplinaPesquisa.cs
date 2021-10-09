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
    public partial class frmDisciplinaPesquisa : Form
    {
        public clsDisciplinas Disciplinas = new clsDisciplinas();
        private clsDisciplinaRegra _DisciplinaDal;


        private void carregarGridPeriodos()
        {
            _DisciplinaDal = new clsDisciplinaRegra();
            dgDisciplinas.AutoGenerateColumns = true;
            dgDisciplinas.DataSource = _DisciplinaDal.ListarTodos();
        }
        public frmDisciplinaPesquisa()
        {
            InitializeComponent();
            Disciplinas.Codigo = -1;
            carregarGridPeriodos();
            FormatarGridDisciplinas();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            Int32 vI = 0;
            vI = dgDisciplinas.CurrentRow.Index;
            Disciplinas.Codigo = Int32.Parse(dgDisciplinas[0, vI].Value.ToString());
            Disciplinas.Disciplinas = dgDisciplinas[1, vI].Value.ToString();
            Disciplinas.Siglas = dgDisciplinas[2, vI].Value.ToString();
            Disciplinas.Observacao = dgDisciplinas[3, vI].Value.ToString();

            this.Close();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            carregarGridPeriodos();
        }

        private void FormatarGridDisciplinas()
        {
            dgDisciplinas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgDisciplinas.ScrollBars = ScrollBars.Vertical;
            dgDisciplinas.Columns[0].HeaderText = "CÓDIGO";
            dgDisciplinas.Columns[1].HeaderText = "DISCIPLINAS";
            dgDisciplinas.Columns[2].HeaderText = "SIGLAS";
            dgDisciplinas.Columns[3].HeaderText = "OBSERVAÇÕES";
            dgDisciplinas.Columns[0].Width = 100;
            dgDisciplinas.Columns[1].Width = 220;
            dgDisciplinas.Columns[2].Width = 100;
            dgDisciplinas.Columns[3].Width = 320;
        }
    }
}
