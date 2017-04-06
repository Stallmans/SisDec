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
    public class RepositoryUsuario
    {
        public void Inserir(Usuarios objUsuario)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Usuarios (nome,login,senha,email,responsavel) values(@nome,@login,@senha,@email,@responsavel)";

            comando.Parameters.AddWithValue("@nome", objUsuario.Nome);
            comando.Parameters.AddWithValue("@login", objUsuario.Login);
            comando.Parameters.AddWithValue("@senha", objUsuario.Senha);
            comando.Parameters.AddWithValue("@email", objUsuario.Email);
            comando.Parameters.AddWithValue("@responsavel", objUsuario.enumReponsavel);

            Conexao.Crud(comando);
        }

        public void Update(Usuarios objUsuario)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Usuarios set nome=@nome,login=@login,senha=@senha where UsuariosId=@UsuariosId";

            comando.Parameters.AddWithValue("@UsuariosId", objUsuario.IdUsuario);
            comando.Parameters.AddWithValue("@nome", objUsuario.Nome);
            comando.Parameters.AddWithValue("@login", objUsuario.Login);
            comando.Parameters.AddWithValue("@senha", objUsuario.Senha);
            comando.Parameters.AddWithValue("@email", objUsuario.Email);
            comando.Parameters.AddWithValue("@responsavel", objUsuario.enumReponsavel);

            Conexao.Crud(comando);
        }

        public IList<Usuarios> BuscarTodos()
        {
            IList<Usuarios> ListaUsuarios = new List<Usuarios>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Usuarios";

            SqlDataReader dr = Conexao.Selecionar(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Usuarios objUsuarios = new Usuarios();
                    objUsuarios.IdUsuario = Convert.ToInt32(dr["UsuariosId"]);
                    objUsuarios.Nome = dr["Nome"].ToString();
                    objUsuarios.Email = dr["Email"].ToString();
                    objUsuarios.enumReponsavel = (Reponsavel)Enum.Parse(typeof(Reponsavel),dr ["responsavel"].ToString());
  
                    ListaUsuarios.Add(objUsuarios);
                }
            }
            else
            {
                ListaUsuarios = null;
            }
            return ListaUsuarios;
        }

        public Usuarios BuscarPorId(int id)
        {
            Usuarios objUsuario = new Usuarios();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Usuarios where UsuariosId=@UsuariosId";

            comando.Parameters.AddWithValue("UsuariosId", id);

            SqlDataReader dr = Conexao.Selecionar(comando);

            if (dr.HasRows)
            {
                dr.Read();
                Usuarios objUsuarios = new Usuarios();
                objUsuarios.IdUsuario = Convert.ToInt32(dr["UsuariosId"]);
                objUsuarios.Nome = dr["Nome"].ToString();
                objUsuarios.Email = dr["Email"].ToString();
                objUsuario.Senha = Convert.ToInt32(dr["senha"]);
                objUsuarios.enumReponsavel = (Reponsavel)Enum.Parse(typeof(Reponsavel), dr["responsavel"].ToString());
            }
            else
            {
                objUsuario = null;
            }
            return objUsuario;
        }
    }
}