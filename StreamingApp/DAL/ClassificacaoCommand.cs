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
    class ClassificacaoCommand
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
                string sql = "select * from tblClassificacao";
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
        public bool Insert(ClassificacaoModel classificacao)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            try
            {
                string sql = "insert into tblClassificacao(Nome, IdadeMaxima, Descricao) values (@nome, @idadeMaxima, @descricao)";
                cmd.CommandText = sql;
                cmd.Connection = con.conectar();
                cmd.Parameters.AddWithValue("@nome", classificacao.Nome);
                cmd.Parameters.AddWithValue("@idadeMaxima", classificacao.IdadeMaxima);
                cmd.Parameters.AddWithValue("@descricao", classificacao.Descricao);
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
        public bool Update(ClassificacaoModel classificacao)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            try
            {
                string sql = "update tblClassificacao set Nome = @nome, IdadeMaxima = @idadeMaxima, Descricao = @descricao where codigo = @codigo";
                cmd.CommandText = sql;

                cmd.Connection = con.conectar();
                cmd.Parameters.AddWithValue("@codigo", classificacao.Codigo);
                cmd.Parameters.AddWithValue("@nome", classificacao.Nome);
                cmd.Parameters.AddWithValue("@idadeMaxima", classificacao.IdadeMaxima);
                cmd.Parameters.AddWithValue("@descricao", classificacao.Descricao);
                
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
        public bool Delete(ClassificacaoModel classificacao)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            try
            {
                string sql = "Delete tblClassificacao where codigo = @codigo";
                cmd.CommandText = sql;
                cmd.Connection = con.conectar();
                cmd.Parameters.AddWithValue("@codigo", classificacao.Codigo);
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
