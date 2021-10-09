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
    public class clsPeriodosRegras
    {
        private clsPeriodosDal periodosDal = new clsPeriodosDal();

        public Int32 ObterProximoID()
        {
            return periodosDal.ObterProximoID();
        }
        public void Salvar(clsPeriodos salvarPeriodos)
        {
            periodosDal.Salvar(salvarPeriodos);
        }

        public void Excluir(Int32 excluirPeriodos)
        {
            periodosDal.Excluir(excluirPeriodos);
        }

        public void Atualizar(clsPeriodos atualizarPeriodos)
        {
            periodosDal.Atualizar(atualizarPeriodos);
        }

        public DataTable ListarTodos()
        {
            return periodosDal.ListarTodos();
        }

    }
}
