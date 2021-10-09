using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using cl_modelos;

namespace cl_dal
{
    public class clsCursosDal
    {
        private SqlConnection _ConexaoSql;
        private SqlCommand _ComandoSql;
        private DataTable _Tabela;
        private SqlDataAdapter _Adaptador;

        public Int32 ObterProximoID()
        {
            Int32 vCodigo = 0;
            _ConexaoSql = Conexao.ObterConexao();

            _ComandoSql = new SqlCommand();
            _ComandoSql.Connection = _ConexaoSql;
            _ComandoSql.CommandText = " select isnull(max(curid), 0) + 1 as codigo " +
                                        " from tblCursos";

            vCodigo = Int32.Parse(_ComandoSql.ExecuteScalar().ToString());

            Conexao.FecharConexao(_ConexaoSql);
            return vCodigo;
        }


        public void Salvar(clsCursos parCurso)
        {
            _ConexaoSql = Conexao.ObterConexao();

            _ComandoSql = new SqlCommand();
            _ComandoSql.Connection = _ConexaoSql;
            _ComandoSql.CommandText = "insert into tblCursos values (@id, @curso, @sigla, @obs, @periodo);";
            _ComandoSql.Parameters.Add("@id", SqlDbType.Int).Value = parCurso.Codigo;
            _ComandoSql.Parameters.Add("@curso", SqlDbType.VarChar).Value = parCurso.Curso;
            _ComandoSql.Parameters.Add("@sigla", SqlDbType.VarChar).Value = parCurso.Siglas;
            _ComandoSql.Parameters.Add("@obs", SqlDbType.VarChar).Value = parCurso.Observacao;
            _ComandoSql.Parameters.Add("@periodo", SqlDbType.Int).Value = parCurso.CodigoPeriodo;

            _ComandoSql.ExecuteNonQuery();

            Conexao.FecharConexao(_ConexaoSql);
        }

        public void Atualizar(clsCursos parCurso)
        {
            _ConexaoSql = Conexao.ObterConexao();
            _ComandoSql = new SqlCommand();
            _ComandoSql.Connection = _ConexaoSql;

            _ComandoSql.CommandText = "update tblCursos" +
                                     " set curnome = @curso," +
                                     " cursigla = @sigla," +
                                     " curobservacao = @obs," +
                                     " perid = @periodo" +
                                     " where curid = @id";

            _ComandoSql.Parameters.Add("@id", SqlDbType.Int).Value = parCurso.Codigo;
            _ComandoSql.Parameters.Add("@curso", SqlDbType.VarChar).Value = parCurso.Curso;
            _ComandoSql.Parameters.Add("@sigla", SqlDbType.VarChar).Value = parCurso.Siglas;
            _ComandoSql.Parameters.Add("@obs", SqlDbType.VarChar).Value = parCurso.Observacao;
            _ComandoSql.Parameters.Add("@periodo", SqlDbType.Int).Value = parCurso.CodigoPeriodo;

            _ComandoSql.ExecuteNonQuery();

            Conexao.FecharConexao(_ConexaoSql);
        }

        public void Excluir(int parCodigo)
        {

            _ConexaoSql = Conexao.ObterConexao();

            _ComandoSql = new SqlCommand();
            _ComandoSql.Connection = _ConexaoSql;
            _ComandoSql.CommandText = "DELETE from tblCursos WHERE curid = @id;";
            _ComandoSql.Parameters.Add("@id", SqlDbType.Int).Value = parCodigo;
            _ComandoSql.ExecuteNonQuery();

            Conexao.FecharConexao(_ConexaoSql);

        }

        public DataTable ListarTodos()
        {
            _ConexaoSql = Conexao.ObterConexao();
            _ComandoSql = new SqlCommand();
            _ComandoSql.Connection = _ConexaoSql;

            _ComandoSql.CommandText = "select curid, curnome, cursigla, perid, curobservacao " +
                                      "from tblCursos " +
                                      "order by curid asc ";

            _Tabela = new DataTable();
            _Adaptador = new SqlDataAdapter(_ComandoSql);
            _Adaptador.Fill(_Tabela);

            Conexao.FecharConexao(_ConexaoSql);

            return _Tabela;
        }

    }
}
