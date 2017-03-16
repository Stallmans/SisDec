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
    public class RepositoryPessoa
    {

        public void Inserir(Pessoa pessoa)
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
            //   comando.CommandText = "UPDATE Cidade SET"


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

        public IList<Cidade> BuscarPorConcessionaria(string concessionaria)
        {
            IList<Cidade> listaconcessionaria = new List<Cidade>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT Concessionaria FROM Concessionaria WHERE concessionaria LIKE @Concessionaria";

            comando.Parameters.AddWithValue("@concessionaria", string.Format("%{0}%", concessionaria));

            SqlDataReader dr = Conexao.Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Cidade ciade = new Cidade();

                    //          Concessionaria.id = Convert.ToInt32(dr["concessionariaId"]);


                    //       listaconcessionaria.Add(concessionaria);
                }
            }
            else
            {
                listaconcessionaria = null;
            }
            return listaconcessionaria;
        }

        public IList<Pessoa> BuscarTodos()
        {
            IList<Pessoa> ListaPessoa = new List<Pessoa>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Pessoa";

            SqlDataReader dr = Conexao.Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Pessoa objPessoa = new Pessoa();


                    ListaPessoa.Add(objPessoa);
                }
            }
            else
            {
                ListaPessoa = null;
            }
            return ListaPessoa;
        }
    }
}