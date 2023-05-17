using StreamingApp.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingApp.DAL
{
    class LoginCommand
    {
        public string strMensagem = "";
        public bool blnSucesso = false;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool Login(string email, string senha)
        {
            string sql = "select * from tblusuario where email = @email and senha = @senha";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    blnSucesso = true;
                }
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
    }
}
