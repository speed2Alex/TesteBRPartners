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
    class GeneroCommand
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
                string sql = "select * from tblGenero";
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
        public bool Insert(GeneroModel genero)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            try
            {
                string sql = "insert into tblgenero(Descricao) values (@descricao)";
                cmd.CommandText = sql;
                cmd.Connection = con.conectar();
                cmd.Parameters.AddWithValue("@descricao", genero.Descricao);
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
        public bool Update(GeneroModel genero)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            try
            {
                string sql = "update tblgenero set Descricao = @descricao where codigo = @codigo";
                cmd.CommandText = sql;
                cmd.Connection = con.conectar();
                cmd.Parameters.AddWithValue("@descricao", genero.Descricao);
                cmd.Parameters.AddWithValue("@codigo", genero.Codigo);
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
        public bool Delete(GeneroModel genero)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            try
            {
                string sql = "Delete tblgenero where codigo = @codigo";
                cmd.CommandText = sql;
                cmd.Connection = con.conectar();
                cmd.Parameters.AddWithValue("@codigo", genero.Codigo);
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
