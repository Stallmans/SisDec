using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SisDec.Models;
using System.Data.SqlClient;
using System.Data;

namespace SisDec.Repository
{
    public class RepositoryClienteFisica
    {

        public void Inserir(PessoaFisica objPessoaFisica)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            //  comando.CommandText = "INSERT INTO"
            Conexao.Crud(comando);
        }

        public void Update()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            //   comando.CommandText = "UPDATE Paciente SET"

            Conexao.Crud(comando);
        }

        public void Delete()
        {

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM  WHERE ";

            //   comando.Parameters.AddWithValue();

            Conexao.Crud(comando);
        }

        public IList<Cidade> BuscarPorReferencia(string referencia)
        {
            IList<Cidade> listaPeca = new List<Cidade>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT Referencia FROM Peca WHERE referencia LIKE @Referencia";

            comando.Parameters.AddWithValue("@referencia", string.Format("%{0}%", referencia));

            SqlDataReader dr = Conexao.Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Cidade peca = new Cidade();

                    //    Concessionaria.Id = Convert.ToInt32(dr["pecaId"]);


                    listaPeca.Add(peca);
                }
            }
            else
            {
                listaPeca = null;
            }
            return listaPeca;


        }

    }

}