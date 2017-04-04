using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SisDec.Models;
using System.Data.SqlClient;
using System.Data;

namespace SisDec.Repository
{
    public class RepositoryCidade
    {
        public Cidade CidadePorId(int id)
        {
            Cidade objCidade = new Cidade();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * from Cidade where cidadeId=@cidadeId";

            comando.Parameters.AddWithValue("cidadeId", id);

            SqlDataReader dr = Conexao.Selecionar(comando);

            if (dr.HasRows)
            {
                dr.Read();
                objCidade.CidadeId = Convert.ToInt32(dr["cidadeId"]);
                objCidade.Nome = dr["Nome"].ToString();
                objCidade.enumEstado = (Estado)Enum.Parse(typeof(Estado), dr["estado"].ToString());
            }
            else
            {
                objCidade = null;
            }

            return objCidade;
        }

        internal Cidade BuscarPorId(int cidadeId)
        {
            Cidade objCidade = new Cidade();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * from Cidade where cidadeId=@cidadeId";

            comando.Parameters.AddWithValue("cidadeId", cidadeId);

            SqlDataReader dr = Conexao.Selecionar (comando);

            if (dr.HasRows)
            {
                dr.Read();
                objCidade.CidadeId = Convert.ToInt32(dr["cidadeId"]);
                objCidade.Nome = dr["Nome"].ToString();
                objCidade.enumEstado = (Estado)Enum.Parse(typeof(Estado), dr["estado"].ToString());
            }
            else
            {
                objCidade = null;
            }

            return objCidade;
        }

        public IList<Cidade> BuscarPorCidade(string cidade)
        {
            IList<Cidade> ListaCidade = new List<Cidade>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * from Cidade where nome like @cidade";

            comando.Parameters.AddWithValue("@cidade", string.Format("%{0}", cidade));

            SqlDataReader dr = Conexao.Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Cidade objCidade = new Cidade();
                    objCidade.CidadeId = Convert.ToInt32(dr["cidadeId"]);
                    objCidade.Nome = dr["nome"].ToString();
                    objCidade.enumEstado = (Estado)Enum.Parse(typeof(Estado), dr["Estado"].ToString());

                    ListaCidade.Add(objCidade);
                }
            }
            else
            {
                ListaCidade = null;
            }
            dr.Close();
            return ListaCidade;
        }
    }
}