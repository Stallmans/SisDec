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
    public class RepositoryRequisicao
    {
        public void Inserir()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
           // comando.CommandText = "INSERT INTO"
                         Conexao.Crud(comando);
        }

        public void Update()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
          //  comando.CommandText = "UPDATE Cidade SET"


                Conexao.Crud(comando);
        }

        public void Delete()
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM  WHERE ";

           // comando.Parameters.AddWithValue();

            Conexao.Crud(comando);
        }

        public IList<Requisicao> BuscarTodos()
        {
            IList<Requisicao> ListaRequsicao = new List<Requisicao>();
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Requisicao";

            SqlDataReader dr = Conexao.Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Requisicao objRequisicao = new Requisicao();
                    objRequisicao.RequisicaoId = Convert.ToInt32(dr["RequisicaoId"]);
                    objRequisicao.NumeroRequisicao = Convert.ToInt32(dr["NumeroRequisicao"]);
                    objRequisicao.ObjCliente.Nome = dr["Nome"].ToString();
                    objRequisicao.objPeca.PecaId = Convert.ToInt32(dr["PecaId"]);
                    ListaRequsicao.Add(objRequisicao);
                }
            }
            else
            {
                ListaRequsicao = null;
            }
            dr.Close();
            return ListaRequsicao;
        }
    }
}