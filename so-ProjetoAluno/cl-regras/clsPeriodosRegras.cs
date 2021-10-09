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
            try
            {
                if ((salvarPeriodos).Nome.Trim() == String.Empty)
                {
                    throw new Exception("INFORME O PERÍODO!");
                }
                else
                {
                    if ((salvarPeriodos).Siglas.Trim() == String.Empty)
                    {
                        throw new Exception("INFORME UMA SIGLA!");
                    }
                }

                periodosDal.Salvar(salvarPeriodos);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Excluir(Int32 excluirPeriodos)
        {

            periodosDal.Excluir(excluirPeriodos);
        }

        public void Atualizar(clsPeriodos alteraPeriodos )
        {
            try
            {
                if ((alteraPeriodos).Nome.Trim() == String.Empty)
                {
                    throw new Exception("INFORME O PERÍODO!");
                }
                else
                {
                    if ((alteraPeriodos).Siglas.Trim() == String.Empty)
                    {
                        throw new Exception("INFORME UMA SIGLA!");
                    }
                }

                periodosDal.Atualizar(alteraPeriodos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarTodos()
        {
            return periodosDal.ListarTodos();
        }

    }
}
