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
        public void Salvar(clsCursos salvarCurso)
        {
            try
            {
                if((salvarCurso).Siglas.Trim() == String.Empty)
                {
                    throw new Exception("INFORME A SIGLA DO CURSO!");
                }
                else
                {
                    if((salvarCurso).Curso.Trim() == String.Empty)
                    {
                        throw new Exception("O NOME DO CURSO DEVE SER INFORMADO!");
                    }
                }
                cursoDal.Salvar(salvarCurso);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Excluir(Int32 excluirPeriodos)
        {
            cursoDal.Excluir(excluirPeriodos);
        }

        public void Atualizar(clsCursos atualizarCurso)
        {
            try
            {
                if ((atualizarCurso).Siglas.Trim() == String.Empty)
                {
                    throw new Exception("O CAMPO SIGLA NÃO DEVE ESTAR EM BRANCO, INFORME A SIGLA DO CURSO!");
                }
                else
                {
                    if ((atualizarCurso).Curso.Trim() == String.Empty)
                    {
                        throw new Exception("O CAMPO CURSO NÃO DEVE ESTAR EM BRANCO, INFORME O CURSO!");
                    }
                }
                cursoDal.Atualizar(atualizarCurso);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public DataTable ListarTodos()
        {
            return cursoDal.ListarTodos();   
        }
    }
}
