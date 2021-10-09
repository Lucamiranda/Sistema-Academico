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
    public class Conexao
    {
        private static SqlConnection _Conexao;
        private static SqlCommand _Comando;
        private static SqlDataAdapter _Adaptador;
        private static DataTable _Tabela;
        private static String _StringConexao = "Data Source=DESKTOP-A7PLR0V; " +
        "Initial Catalog=SISTEMA_ACADEMICO; " +
        "Integrated Security=True;";

        public static SqlConnection ObterConexao()
        {
            try
            {
                _Conexao = new SqlConnection(_StringConexao);
                _Conexao.Open();
                return _Conexao;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public static void FecharConexao(SqlConnection parConexao)
        {
            if (_Conexao.State == ConnectionState.Open)
            {
                _Conexao.Close();
            }
        }
    }
}
    

