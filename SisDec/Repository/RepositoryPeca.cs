using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using SisDec.Models;

namespace SisDec.Repository
{
    public class RepositoryPeca
    {
        public void Inserir(Peca objPeca)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Pecas (referencia,descricao,valor) values(@referencia,@descricao,@valor)";

            comando.Parameters.AddWithValue("@Referencia", objPeca.Referencia);
            comando.Parameters.AddWithValue("@Descricao", objPeca.Descricao);
            comando.Parameters.AddWithValue("@Valor", objPeca.Valor);
            
            Conexao.Crud(comando);

        }

        public void Update(Peca objPeca)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Pecas SET @referencia,@descricao,@valor";

            comando.Parameters.AddWithValue("@Referencia", objPeca.Referencia);
            comando.Parameters.AddWithValue("@Descricao", objPeca.Descricao);
            comando.Parameters.AddWithValue("@Valor", objPeca.Valor);

            Conexao.Crud(comando);
        }

        public Peca BuscarPorId(int id)
        {
            Peca objPeca = new Peca();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Pecas where pecaId=@pecaId";

            comando.Parameters.AddWithValue("pecaId", id);

            SqlDataReader dr = Conexao.Selecionar(comando);

            if (dr.HasRows)
            {
                dr.Read();
                objPeca.PecaId = Convert.ToInt32(dr["pecaId"]);
                objPeca.Referencia = dr["numSerie"].ToString();
                objPeca.Descricao = dr["descricao"].ToString();
                objPeca.Valor = Convert.ToDecimal(dr["valor"]);
            }
            else
            {
                objPeca = null;
            }
            return objPeca;
        }

        public IList<Peca> BuscarTodos()
        {
            IList<Peca> ListaPeca = new List<Peca>();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Pecas";

            SqlDataReader dr = Conexao.Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Peca objPeca = new Peca();
                    objPeca.Referencia = dr["Referencia"].ToString();
                    objPeca.Descricao = dr["descricao"].ToString();
                    objPeca.Valor = Convert.ToDecimal(dr["valor"]);
                    ListaPeca.Add(objPeca);
                }
            }
            else
            {
                ListaPeca = null;
            }
            dr.Close();
            return ListaPeca;
        }

    }



}