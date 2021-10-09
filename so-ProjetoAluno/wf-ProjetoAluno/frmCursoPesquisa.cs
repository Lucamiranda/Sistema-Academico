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
    public partial class frmCursoPesquisa : Form
    {
        public frmCursoConsultar LimparConsulta = new frmCursoConsultar();
        public clsCursos Curso = new clsCursos();
        private clsCursosRegras _CursoDal;

        private void CarregarGridCurso()
        {
            _CursoDal = new clsCursosRegras();
            dgCursos.AutoGenerateColumns = true;
            dgCursos.DataSource = _CursoDal.ListarTodos();
        }

        public frmCursoPesquisa()
        {
            InitializeComponent();
            Curso.Codigo = -1;
            CarregarGridCurso();
            FormatarGridCurso();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            Int32 vI = 0;
            vI = dgCursos.CurrentRow.Index;
            Curso.Codigo = Int32.Parse(dgCursos[0, vI].Value.ToString());
            Curso.Curso = dgCursos[1, vI].Value.ToString();
            Curso.Siglas = dgCursos[2, vI].Value.ToString();
            Curso.CodigoPeriodo = Int32.Parse(dgCursos[3, vI].Value.ToString());
            Curso.Observacao = dgCursos[4, vI].Value.ToString();

            this.Close();
        }


        private void btAtualizar_Click(object sender, EventArgs e)
        {
            CarregarGridCurso();
        }

        private void FormatarGridCurso()
        {
            dgCursos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgCursos.ScrollBars = ScrollBars.Both;
            dgCursos.Columns[0].HeaderText = "CÓDIGO";
            dgCursos.Columns[1].HeaderText = "CURSO";
            dgCursos.Columns[2].HeaderText = "SIGLA";
            dgCursos.Columns[3].HeaderText = "PERIODO";
            dgCursos.Columns[4].HeaderText = "OBSERVAÇÕES";
            dgCursos.Columns[0].Width = 80;
            dgCursos.Columns[1].Width = 200;
            dgCursos.Columns[2].Width = 80;
            dgCursos.Columns[3].Width = 100;
            dgCursos.Columns[4].Width = 320;

        }

        private void frmCursoPesquisa_Load(object sender, EventArgs e)
        {
            //Curso.Codigo = -1;
        }
    }
}
