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
    public class clsCursosRegras
    {
        private clsCursosDal cursoDal = new clsCursosDal();

        public Int32 ObterProximoID()
        {
            return cursoDal.ObterProximoID();
        }
        public void Salvar(clsCursos salvarPeriodos)
        {
            cursoDal.Salvar(salvarPeriodos);
        }

        public void Excluir(Int32 excluirPeriodos)
        {
            cursoDal.Excluir(excluirPeriodos);
        }

        public void Atualizar(clsCursos atualizarPeriodos)
        {
            cursoDal.Atualizar(atualizarPeriodos);
        }

        public DataTable ListarTodos()
        {
            return cursoDal.ListarTodos();   
        }
    }
}
