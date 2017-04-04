﻿using System;
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
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Cliente (nome, cpf, endereco, dataNascimento, sexo, rg, bairro,cep,complemento,email,tipoPessoa, numero, telefone,cidadeId, Cnpj,Inscricaoestadual, Inscricaomunicipal) Values(@nome, @cpf, @endereco, @dataNascimento, @sexo, @rg, @bairro, @cep, @complemento, @email, @tipoPessoa, @numero, @telefone, @cidadeId, @Cnpj, @Inscricaoestadual, @Inscricaomunicipal)";

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
            // pj
            comando.Parameters.AddWithValue("@Cnpj", objCliente.Cnpj);
            comando.Parameters.AddWithValue("@Inscricaoestadual", objCliente.InscricaoEstadual);
            comando.Parameters.AddWithValue("@Inscricaomunicipal", objCliente.InscricaoMunicipal);

            Conexao.Crud(comando);
        }

        public void Update(Cliente objCliente)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Cliente (nome, cpf, endereco, dataNascimento, sexo, rg, bairro,cep,complemento,email,tipoPessoa, numero, telefone,cidadeId, Cnpj,Inscricaoestadual, Inscricaomunicipal) Values(@nome, @cpf, @endereco, @dataNascimento, @sexo, @rg, @bairro, @cep, @complemento, @email, @tipoPessoa, @numero, @telefone, @cidadeId, @Cnpj, @Inscricaoestadual, @Inscricaomunicipal)";

            comando.Parameters.AddWithValue("@clienteId", objCliente.IdCliente);
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
            // pj
            comando.Parameters.AddWithValue("@Cnpj", objCliente.Cnpj);
            comando.Parameters.AddWithValue("@Inscricaoestadual", objCliente.InscricaoEstadual);
            comando.Parameters.AddWithValue("@Inscricaomunicipal", objCliente.InscricaoMunicipal);

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
                    objCliente.IdCliente = Convert.ToInt32(dr["ClienteId"]);
                    objCliente.Nome = dr["Nome"].ToString();
                    objCliente.Cpf = dr["Cpf"].ToString();
                    objCliente.Endereco = dr["endereco"].ToString();
                    objCliente.Bairro = dr["bairro"].ToString();
                    objCliente.Cep = Convert.ToDecimal(dr["cep"]);
                    objCliente.Complemento = dr["complemento"].ToString();
                    objCliente.Email = dr["email"].ToString();
                    objCliente.tipoPessoa = (TipoPessoa)Enum.Parse(typeof(TipoPessoa), dr["TipoPessoa"].ToString());
                    objCliente.Numero = Convert.ToInt32(dr["numero"]);
                    objCliente.Telefone = Convert.ToDecimal(dr["telefone"]);
                    objCliente.Cnpj = dr["cnpj"].ToString();
                    objCliente.objCidade = new RepositoryCidade().CidadePorId((int)dr["cidadeId"]);

                    ListaCliente.Add(objCliente);
                }
            }
            else
            {
                ListaCliente = null;
            }
            return ListaCliente;
        }


        public Cliente ClientePorId(int id)
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
                objCliente.Nome = dr["nome"].ToString();
                objCliente.Cpf = dr["cpf"].ToString();
                objCliente.tipoPessoa = (TipoPessoa)Enum.Parse(typeof(TipoPessoa), dr["TipoPessoa"].ToString());
                objCliente.objCidade = new RepositoryCidade().CidadePorId((int)dr["cidadeId"]);
            }
            else
            {
                objCliente = null;
            }

            return objCliente;
        }
    }

}