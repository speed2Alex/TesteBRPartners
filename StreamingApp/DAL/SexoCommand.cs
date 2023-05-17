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
    class SexoCommand
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
                string sql = "select * from tblsexo";
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
        public bool Insert(SexoModel sexo)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            try
            {
                string sql = "insert into tblsexo(Descricao) values (@descricao)";
                cmd.CommandText = sql;
                cmd.Connection = con.conectar();
                cmd.Parameters.AddWithValue("@descricao", sexo.Descricao);
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
        public bool Update(SexoModel sexo)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            try
            {
                string sql = "update tblsexo set Descricao = @descricao where codigo = @codigo";
                cmd.CommandText = sql;
                cmd.Connection = con.conectar();
                cmd.Parameters.AddWithValue("@descricao", sexo.Descricao);
                cmd.Parameters.AddWithValue("@codigo", sexo.Codigo);
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
        public bool Delete(SexoModel sexo)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            try
            {
                string sql = "Delete tblsexo where codigo = @codigo";
                cmd.CommandText = sql;
                cmd.Connection = con.conectar();
                cmd.Parameters.AddWithValue("@codigo", sexo.Codigo);
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
