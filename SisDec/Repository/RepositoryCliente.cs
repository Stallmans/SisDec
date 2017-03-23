using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SisDec.Models;
using System.Data.SqlClient;
using System.Data;

namespace SisDec.Repository
{
    public class RepositoryCliente
    {

        public void Inserir(Cliente objCliente)
        {

            SqlCommand comando = new SqlCommand("[dbo].[procPessoaFisicaInserir]");
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@nome", objCliente.Nome);
            comando.Parameters.AddWithValue("@cpf", objCliente.Cpf);
            comando.Parameters.AddWithValue("@dataNascimento", objCliente.DataNascimento);
            comando.Parameters.AddWithValue("@rg", objCliente.Rg);


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

        

        public IList<Cliente> BuscarTodos()
        {
            IList<Cliente> ListaCliente = new List<Cliente>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM tblPessoaFisica";

            SqlDataReader dr = Conexao.Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Cliente objCliente = new Cliente();
                    objCliente.IdCliente = Convert.ToInt32(dr["IdCliente"]);
                    objCliente.Nome = dr["Nome"].ToString();
                    objCliente.Cpf = dr["Cpf"].ToString();
                    objCliente.DataNascimento = Convert.ToDateTime(dr["DataNascimento"]);
                    objCliente.Rg = Convert.ToInt32(dr["Rg"]);

                    ListaCliente.Add(objCliente);
                }
            }
            else
            {
                ListaCliente = null;
            }
            return ListaCliente;
        }

    }

}