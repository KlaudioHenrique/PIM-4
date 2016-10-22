using System.Data.SqlClient;
using System.Data;

namespace BibliotecaDoAlex.DAO
{
    public class Conexao
    {
        public SqlConnection Conectar()
        {
            string StringConexao = "Data Source = Local; Initial Catalog = THEHOST; User ID = sa; Password = fury1234";

            SqlConnection conexao = new SqlConnection(StringConexao);
            conexao.Open();


            return conexao;
        }

        public void ExecutarCrud(SqlCommand Comando)
        {
            SqlConnection Con = Conectar();
            Comando.Connection = Con;
            Comando.ExecuteNonQuery();
            Con.Close();
        }

        public SqlDataReader ExecutarSelect(SqlCommand Comando)
        {
            SqlConnection Con = Conectar();
            Comando.Connection = Con;

            SqlDataReader DR = Comando.ExecuteReader(CommandBehavior.CloseConnection);
            return DR;

        }
    }


}