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
            try
            {
                if((salvarDisciplina).Siglas.Trim() == String.Empty)
                {
                    throw new Exception("INFORME A SIGLA DA DISCIPLINA!");
                }
                else
                {
                    if((salvarDisciplina).Disciplinas.Trim() == String.Empty)
                    {
                        throw new Exception("INFORME A DISCIPLINA!");
                    }
                }
                disciplinaDal.Salvar(salvarDisciplina);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(Int32 excluirDisciplina)
        {
            disciplinaDal.Excluir(excluirDisciplina);
        }

        public void Atualizar(clsDisciplinas atualizarDisciplina)
        {
            try
            {
                if ((atualizarDisciplina).Disciplinas.Trim() == String.Empty)
                {
                    throw new Exception("INFORME O NOME DA DISCIPLINA!");
                }
                else
                {
                    if((atualizarDisciplina).Siglas.Trim() == String.Empty)
                    {
                        throw new Exception("INFORME A SIGLA DA DISCIPLINA!");
                    }
                }
            disciplinaDal.Atualizar(atualizarDisciplina);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarTodos()
        {
            return disciplinaDal.ListarTodos();
        }
    }
}
