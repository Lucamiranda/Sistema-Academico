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
    public class clsDisciplinasDal
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
            _ComandoSql.CommandText = " select isnull(max(disid), 0) + 1 as codigo " +
                                    " from tblDisciplinas";

            vCodigo = Int32.Parse(_ComandoSql.ExecuteScalar().ToString());

            Conexao.FecharConexao(_ConexaoSql);
            return vCodigo;
        }


        public void Salvar(clsDisciplinas parDis)
        {
            _ConexaoSql = Conexao.ObterConexao();

            _ComandoSql = new SqlCommand();
            _ComandoSql.Connection = _ConexaoSql;
            _ComandoSql.CommandText = "insert into tblDisciplinas values (@id, @dis, @sigla, @obs);";
            _ComandoSql.Parameters.Add("@id", SqlDbType.Int).Value = parDis.Codigo;
            _ComandoSql.Parameters.Add("@dis", SqlDbType.VarChar).Value = parDis.Disciplinas;
            _ComandoSql.Parameters.Add("@sigla", SqlDbType.VarChar).Value = parDis.Siglas;
            _ComandoSql.Parameters.Add("@obs", SqlDbType.VarChar).Value = parDis.Observacao;

            _ComandoSql.ExecuteNonQuery();

            Conexao.FecharConexao(_ConexaoSql);
        }

        public void Atualizar(clsDisciplinas parDis)
        {
            _ConexaoSql = Conexao.ObterConexao();
            _ComandoSql = new SqlCommand();
            _ComandoSql.Connection = _ConexaoSql;

            _ComandoSql.CommandText = "update tblDisciplinas" +
             " set disnome = @dis," +
             " dissigla = @sigla," +
             " disobervacao = @obs" +
             " where disid = @id";

            _ComandoSql.Parameters.Add("@id", SqlDbType.Int).Value = parDis.Codigo;
            _ComandoSql.Parameters.Add("@dis", SqlDbType.VarChar).Value = parDis.Disciplinas;
            _ComandoSql.Parameters.Add("@sigla", SqlDbType.VarChar).Value = parDis.Siglas;
            _ComandoSql.Parameters.Add("@obs", SqlDbType.VarChar).Value = parDis.Observacao;


            _ComandoSql.ExecuteNonQuery();

            Conexao.FecharConexao(_ConexaoSql);
        }

        public void Excluir(int parCodigo)
        {

            _ConexaoSql = Conexao.ObterConexao();

            _ComandoSql = new SqlCommand();
            _ComandoSql.Connection = _ConexaoSql;
            _ComandoSql.CommandText = "DELETE from tblDisciplinas WHERE disid = @id;";
            _ComandoSql.Parameters.Add("@id", SqlDbType.Int).Value = parCodigo;
            _ComandoSql.ExecuteNonQuery();

            Conexao.FecharConexao(_ConexaoSql);

        }

        public DataTable ListarTodos()
        {
            _ConexaoSql = Conexao.ObterConexao();
            _ComandoSql = new SqlCommand();
            _ComandoSql.Connection = _ConexaoSql;

            _ComandoSql.CommandText = "select disid, disnome, dissigla, disobervacao " +
                                      "from tblDisciplinas " +
                                      "order by disid asc";

            _Tabela = new DataTable();
            _Adaptador = new SqlDataAdapter(_ComandoSql);
            _Adaptador.Fill(_Tabela);

            Conexao.FecharConexao(_ConexaoSql);

            return _Tabela;
        }
    
    }
}

