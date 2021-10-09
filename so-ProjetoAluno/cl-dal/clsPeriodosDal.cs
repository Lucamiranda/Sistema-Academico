using cl_modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace cl_dal
{
    public class clsPeriodosDal
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
            _ComandoSql.CommandText = " select isnull(max(perid), 0) + 1 as codigo " +
                                    " from tblPeriodos";

            vCodigo = Int32.Parse(_ComandoSql.ExecuteScalar().ToString());

            Conexao.FecharConexao(_ConexaoSql);
            return vCodigo;
        }


        public void Salvar(clsPeriodos parPeriodo)
        {
            _ConexaoSql = Conexao.ObterConexao();

            _ComandoSql = new SqlCommand();
            _ComandoSql.Connection = _ConexaoSql;
            _ComandoSql.CommandText = "insert into tblPeriodos values (@id, @periodo, @sigla);";
            _ComandoSql.Parameters.Add("@id", SqlDbType.Int).Value = parPeriodo.Codigo;
            _ComandoSql.Parameters.Add("@periodo", SqlDbType.VarChar).Value = parPeriodo.Nome;
            _ComandoSql.Parameters.Add("@sigla", SqlDbType.VarChar).Value = parPeriodo.Siglas;
            _ComandoSql.ExecuteNonQuery();

            Conexao.FecharConexao(_ConexaoSql);
        }

        public void Atualizar(clsPeriodos parPeriodo )
        {
            _ConexaoSql = Conexao.ObterConexao();
            _ComandoSql = new SqlCommand();
            _ComandoSql.Connection = _ConexaoSql;

            _ComandoSql.CommandText = "update tblPeriodos" +
             " set pernome = @periodo," +
             " persigla = @sigla" +
             " where perid = @id";

            _ComandoSql.Parameters.Add("@id", SqlDbType.Int).Value = parPeriodo.Codigo;
            _ComandoSql.Parameters.Add("@periodo", SqlDbType.VarChar).Value = parPeriodo.Nome;
            _ComandoSql.Parameters.Add("@sigla", SqlDbType.VarChar).Value = parPeriodo.Siglas;

            _ComandoSql.ExecuteNonQuery();

            Conexao.FecharConexao(_ConexaoSql);
        }

        public void Excluir(int parCodigo)
        {

            _ConexaoSql = Conexao.ObterConexao();

            _ComandoSql = new SqlCommand();
            _ComandoSql.Connection = _ConexaoSql;
            _ComandoSql.CommandText = "DELETE from tblPeriodos WHERE perid = @id;";
            _ComandoSql.Parameters.Add("@id", SqlDbType.Int).Value = parCodigo;
            _ComandoSql.ExecuteNonQuery();

            Conexao.FecharConexao(_ConexaoSql);

        }

        public DataTable ListarTodos()
        {
            _ConexaoSql = Conexao.ObterConexao();
            _ComandoSql = new SqlCommand();
            _ComandoSql.Connection = _ConexaoSql;

            _ComandoSql.CommandText = "select perid, pernome, persigla " +
                                      "from tblPeriodos " +
                                      "order by perid asc";

            _Tabela = new DataTable();
            _Adaptador = new SqlDataAdapter(_ComandoSql);
            _Adaptador.Fill(_Tabela);

            Conexao.FecharConexao(_ConexaoSql);

            return _Tabela;
        }
    }
}
