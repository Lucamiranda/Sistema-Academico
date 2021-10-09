using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cl_dal;
using cl_modelos;
using System.Data;
using System.Data.Sql;

namespace cl_regras
{
    public class clsDisciplinaRegra
    {
        private clsDisciplinasDal disciplinaDal = new clsDisciplinasDal();

        public Int32 ObterProximoID()
        {
            return disciplinaDal.ObterProximoID();
        }
        public void Salvar(clsDisciplinas salvarDisciplina)
        {
            disciplinaDal.Salvar(salvarDisciplina);
        }

        public void Excluir(Int32 excluirDisciplina)
        {
            disciplinaDal.Excluir(excluirDisciplina);
        }

        public void Atualizar(clsDisciplinas atualizarDisciplina)
        {
            disciplinaDal.Atualizar(atualizarDisciplina);
        }

        public DataTable ListarTodos()
        {
            return disciplinaDal.ListarTodos();
        }
    }
}
