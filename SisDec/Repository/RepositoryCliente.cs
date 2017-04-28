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
            if (objCliente.tipoPessoa == TipoPessoa.pessoaFisica)
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO Cliente (nome, cpf, endereco, sexo, rg, bairro,cep,complemento,email,tipoPessoa, numero, telefone,cidadeId) Values(@nome, @cpf, @endereco, @sexo, @rg, @bairro, @cep, @complemento, @email, @tipoPessoa, @numero, @telefone, @cidadeId)";

                comando.Parameters.AddWithValue("@nome", objCliente.Nome);
                comando.Parameters.AddWithValue("@cpf", objCliente.Cpf);
                comando.Parameters.AddWithValue("@endereco", objCliente.Endereco);
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
            else if (objCliente.tipoPessoa == TipoPessoa.pessoaJuridica)
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO Cliente (nome,endereco,bairro,cep,email,tipoPessoa,numero, telefone,cidadeId, Cnpj,Inscricaomunicipal) Values(@nome,@endereco,@bairro,@cep,@email,@tipoPessoa,@numero,@telefone,@cidadeId, @Cnpj,@Inscricaomunicipal)";

                comando.Parameters.AddWithValue("@nome", objCliente.Nome);
                comando.Parameters.AddWithValue("@endereco", objCliente.Endereco);
                comando.Parameters.AddWithValue("@bairro", objCliente.Bairro);
                comando.Parameters.AddWithValue("@cep", objCliente.Cep);
                comando.Parameters.AddWithValue("@email", objCliente.Email);
                comando.Parameters.AddWithValue("@tipoPessoa", objCliente.tipoPessoa);
                comando.Parameters.AddWithValue("@numero", objCliente.Numero);
                comando.Parameters.AddWithValue("@telefone", objCliente.Telefone);
                comando.Parameters.AddWithValue("@cidadeId", objCliente.objCidade.CidadeId);
                comando.Parameters.AddWithValue("@Cnpj", objCliente.Cnpj);
                comando.Parameters.AddWithValue("@Inscricaomunicipal", objCliente.InscricaoMunicipal);
                Conexao.Crud(comando);
            }
        }

        public void Update(Cliente objCliente)
        {

            if (objCliente.tipoPessoa == TipoPessoa.pessoaFisica)
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE Cliente set nome=@nome, cpf=@cpf, endereco=@endereco, sexo=@sexo, rg=@rg, bairro=@bairro, cep=@cep, complemento=@complemento, email=@email, tipoPessoa=@tipoPessoa, numero=@numero, telefone=@telefone, cidadeId=@cidadeId where clienteId=@clienteId";

                comando.Parameters.AddWithValue("@clienteId", objCliente.IdCliente);
                comando.Parameters.AddWithValue("@nome", objCliente.Nome);
                comando.Parameters.AddWithValue("@cpf", objCliente.Cpf);
                comando.Parameters.AddWithValue("@endereco", objCliente.Endereco);
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
            else if (objCliente.tipoPessoa == TipoPessoa.pessoaJuridica)
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE Cliente set nome=@nome, cpf=@cpf, endereco=@endereco, dataNascimento=@dataNascimento, sexo=@sexo, rg=@rg, bairro=@bairro, cep=@cep, complemento=@complemento, email=@email, tipoPessoa=@tipoPessoa, numero=@numero, telefone=@telefone, cidadeId=@cidadeId, cnpj=@Cnpj, Inscreicaomunicipal=@Inscricaomunicipal where clienteId=@clienteId";

                comando.Parameters.AddWithValue("@clienteId", objCliente.IdCliente);
                comando.Parameters.AddWithValue("@nome", objCliente.Nome);
                comando.Parameters.AddWithValue("@endereco", objCliente.Endereco);
                comando.Parameters.AddWithValue("@bairro", objCliente.Bairro);
                comando.Parameters.AddWithValue("@cep", objCliente.Cep);
                comando.Parameters.AddWithValue("@email", objCliente.Email);
                comando.Parameters.AddWithValue("@tipoPessoa", objCliente.tipoPessoa);
                comando.Parameters.AddWithValue("@numero", objCliente.Numero);
                comando.Parameters.AddWithValue("@telefone", objCliente.Telefone);
                comando.Parameters.AddWithValue("@cidadeId", objCliente.objCidade.CidadeId);
                comando.Parameters.AddWithValue("@Cnpj", objCliente.Cnpj);
                comando.Parameters.AddWithValue("@Inscricaomunicipal", objCliente.InscricaoMunicipal);
                Conexao.Crud(comando);
            }
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
                    objCliente.IdCliente = Convert.ToInt32(dr["ClienteId"]);
                    objCliente.Nome = dr["Nome"].ToString();
                    objCliente.Cpf = dr["Cpf"].ToString();
                    objCliente.tipoPessoa = (TipoPessoa)Enum.Parse(typeof(TipoPessoa), dr["TipoPessoa"].ToString());
                    objCliente.objCidade = new RepositoryCidade().CidadePorId((int)dr["cidadeId"]);
                    objCliente.Cnpj = dr["cnpj"].ToString();

                    ListaCliente.Add(objCliente);
                }
            }
            else
            {
                ListaCliente = null;
            }
            return ListaCliente;
        }


        public Cliente ClientePorIdFisica(int id)
        {
            Cliente objCliente = new Cliente();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * from Cliente where clienteId=@clienteId";

            comando.Parameters.AddWithValue("clienteId", id);

            SqlDataReader dr = Conexao.Selecionar(comando);

            if (dr.HasRows)
            {
                dr.Read();
                objCliente.IdCliente = Convert.ToInt32(dr["clienteId"]);
                objCliente.Nome = dr["Nome"].ToString();
                objCliente.Cpf = dr["Cpf"].ToString();
                objCliente.Endereco = dr["endereco"].ToString();
                objCliente.enumSexo = (Sexo)Enum.Parse(typeof(Sexo), dr["sexo"].ToString());
                objCliente.Rg = Convert.ToInt32(dr["Rg"]);
                objCliente.Bairro = dr["bairro"].ToString();
                objCliente.Cep = dr["cep"].ToString();
                objCliente.Complemento = dr["complemento"].ToString();
                objCliente.Email = dr["email"].ToString();
                objCliente.tipoPessoa = (TipoPessoa)Enum.Parse(typeof(TipoPessoa), dr["TipoPessoa"].ToString());
                objCliente.Numero = Convert.ToInt32(dr["numero"]);
                objCliente.Telefone = dr["telefone"].ToString();
                objCliente.objCidade = new RepositoryCidade().CidadePorId((int)dr["cidadeId"]);

            }
            else
            {
                objCliente = null;
            }

            return objCliente;
        }

        public Cliente ClientePorIdJurica(int id)
        {
            Cliente objCliente = new Cliente();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * from Cliente where clienteId=@clienteId";

            comando.Parameters.AddWithValue("clienteId", id);

            SqlDataReader dr = Conexao.Selecionar(comando);

            if (dr.HasRows)
            {
                dr.Read();
                objCliente.IdCliente = Convert.ToInt32(dr["clienteId"]);
                objCliente.Nome = dr["Nome"].ToString();
                objCliente.Cpf = dr["Cpf"].ToString();
                objCliente.Endereco = dr["endereco"].ToString();
                objCliente.Bairro = dr["bairro"].ToString();
                objCliente.Cep = dr["cep"].ToString();
                objCliente.Email = dr["email"].ToString();
                objCliente.tipoPessoa = (TipoPessoa)Enum.Parse(typeof(TipoPessoa), dr["TipoPessoa"].ToString());
                objCliente.Numero = Convert.ToInt32(dr["numero"]);
                objCliente.Telefone = dr["telefone"].ToString();
                objCliente.objCidade = new RepositoryCidade().CidadePorId((int)dr["cidadeId"]);
                objCliente.Cnpj = dr["cnpj"].ToString();
                objCliente.InscricaoMunicipal = dr["Inscricaomunicipal"].ToString();

            }
            else
            {
                objCliente = null;
            }

            return objCliente;
        }
    }

}