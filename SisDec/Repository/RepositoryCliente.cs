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
            if (objCliente.tipoPessoa == 1)
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO Cliente (nome, cpf, endereco, dataNascimento, sexo, rg, bairro,cep,complemento,email,tipoPessoa, numero, telefone,cidadeId) Values(@nome, @cpf, @endereco, @dataNascimento, @sexo, @rg, @bairro, @cep, @complemento, @email, @tipoPessoa, @numero, @telefone, @cidadeId)";

                comando.Parameters.AddWithValue("@nome", objCliente.Nome);
                comando.Parameters.AddWithValue("@cpf", objCliente.Cpf);
                comando.Parameters.AddWithValue("@endereco", objCliente.Endereco);
                comando.Parameters.AddWithValue("@dataNascimento", objCliente.DataNascimento);
                comando.Parameters.AddWithValue("@sexo", objCliente.enumSexo);
                comando.Parameters.AddWithValue("@rg", objCliente.Rg);
                comando.Parameters.AddWithValue("@bairro", objCliente.Bairro);
                comando.Parameters.AddWithValue("@cep", objCliente.Cep);
                comando.Parameters.AddWithValue("@complemento", objCliente.Complemento);
                comando.Parameters.AddWithValue("@email", objCliente.Email);
                comando.Parameters.AddWithValue("@tipoPessoa", objCliente.tipoPessoa);
                comando.Parameters.AddWithValue("@numero", objCliente.Numero);
                comando.Parameters.AddWithValue("@telefone", objCliente.Telefone);
                comando.Parameters.AddWithValue("@cidadeId", objCliente.objCidade.CidadeId);


                Conexao.Crud(comando);
            }
            else
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO Cliente (Nome, Bairro, Cnpj, Email, Endereco, Inscricaoestadual, Inscricaomunicipal, Numero, Telefone, TipoPessoa, CidadeID) values @Nome, @Bairro, @Cnpj, @Email, @Endereco, @Inscricaoestadual, @Inscricaomunicipal, @Numero, @Telefone, @TipoPessoa, @CidadeID";

                comando.Parameters.AddWithValue("@Nome", objCliente.Nome);
                comando.Parameters.AddWithValue("@Bairro", objCliente.Bairro);
                comando.Parameters.AddWithValue("@Cnpj", objCliente.Cnpj);
                comando.Parameters.AddWithValue("@endereco", objCliente.Endereco);
                comando.Parameters.AddWithValue("@email", objCliente.Email);
                comando.Parameters.AddWithValue("@Inscricaoestadual", objCliente.InscricaoEstadual);
                comando.Parameters.AddWithValue("@Inscricaomunicipal", objCliente.InscricaoMunicipal);
                comando.Parameters.AddWithValue("@Telefone", objCliente.Telefone);
                comando.Parameters.AddWithValue("@numero", objCliente.Numero);
                comando.Parameters.AddWithValue("@TipoPessoa", objCliente.tipoPessoa);
                comando.Parameters.AddWithValue("@cidadeId", objCliente.objCidade.CidadeId);


                Conexao.Crud(comando);
            }



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
            comando.CommandText = "SELECT * FROM Cliente";

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