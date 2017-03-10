using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SisDec.Repository
{
    public class Conexao
    {
        public static SqlConnection Conectar()
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["ConexaoSisDec"].ConnectionString;
            SqlConnection con = new SqlConnection(stringConexao);
            con.Open();

            return con;
        }

        public static void Crud(SqlCommand comando)
        {
            SqlConnection con = Conectar();
            comando.Connection = con;
            comando.ExecuteNonQuery();

            con.Close();
        }

        public static SqlDataReader Selecionar(SqlCommand comando)
        {
            SqlConnection con = Conectar();
            comando.Connection = con;
            SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);

            return dr;
        }
    }
}