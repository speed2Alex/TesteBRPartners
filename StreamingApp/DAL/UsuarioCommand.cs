using StreamingApp.DAO;
using StreamingApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingApp.DAL
{
    class UsuarioCommand
    {
        public string strMensagem = "";
        public bool blnSucesso = false;


        #region Consulta
        public DataTable Consulta()
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            DataTable table = new DataTable();
            try
            {
                string sql = @"select
                                    u.Codigo, u.Nome, u.idade, u.Email, u.CodigoSexo, 
                                    s.Descricao as sexo, u.CodigoGenero, g.Descricao as genero,
	                                u.Senha, u.Criacao
                                from
                                    tblUsuario u inner join
                                    tblSexo s on u.CodigoSexo = s.Codigo inner join
                                    tblGenero g on u.CodigoGenero = g.Codigo
                                ";
                cmd.CommandText = sql;
                cmd.Connection = con.conectar();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                this.strMensagem = ex.Message.ToString();
            }
            finally
            {
                con.desconectar();
                cmd.Dispose();

            }
            return table;


        }
        #endregion

        #region Inclusão
        public bool Insert(UsuarioModel usuario)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            try
            {
                string sql = "insert into tblUsuario(Nome, Idade, Email, CodigoSexo, CodigoGenero, Senha) values (@nome, @idade, @email, @codigoSexo, @codigoGenero, @senha)";
                cmd.CommandText = sql;
                cmd.Connection = con.conectar();
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@idade", usuario.Idade);
                cmd.Parameters.AddWithValue("@email", usuario.Email);
                cmd.Parameters.AddWithValue("@codigoSexo", usuario.CodigoSexo);
                cmd.Parameters.AddWithValue("@codigoGenero", usuario.CodigoGenero);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);


                cmd.ExecuteNonQuery();
                cmd.Dispose();
                blnSucesso = true;
            }
            catch (Exception ex)
            {
                this.strMensagem = ex.Message.ToString();
                blnSucesso = false;
            }
            finally
            {
                con.desconectar();
                cmd.Dispose();

            }

            return blnSucesso;

        }
        #endregion

        #region Update
        public bool Update(UsuarioModel usuario)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            try
            {
                string sql = "update tblUsuario set Nome = @nome, Idade = @idade, Email = @email, CodigoSexo = @codigoSexo, CodigoGenero = @codigoGenero, Senha = @senha where codigo = @codigo";
                cmd.CommandText = sql;
                cmd.Connection = con.conectar();
                cmd.Parameters.AddWithValue("@codigo", usuario.Codigo);
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@idade", usuario.Idade);
                cmd.Parameters.AddWithValue("@email", usuario.Email);
                cmd.Parameters.AddWithValue("@codigoSexo", usuario.CodigoSexo);
                cmd.Parameters.AddWithValue("@codigoGenero", usuario.CodigoGenero);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                blnSucesso = true;

            }
            catch (Exception ex)
            {
                this.strMensagem = ex.Message.ToString();
                blnSucesso = false;
            }
            finally
            {
                con.desconectar();
                cmd.Dispose();

            }

            return blnSucesso;

        }
        #endregion

        #region Delete
        public bool Delete(UsuarioModel usuario)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            try
            {
                string sql = "Delete tblusuario where codigo = @codigo";
                cmd.CommandText = sql;
                cmd.Connection = con.conectar();
                cmd.Parameters.AddWithValue("@codigo", usuario.Codigo);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                blnSucesso = true;

            }
            catch (Exception ex)
            {
                this.strMensagem = ex.Message.ToString();
                blnSucesso = false;
            }
            finally
            {
                con.desconectar();
                cmd.Dispose();

            }

            return blnSucesso;

        }


        #endregion

    }
}
