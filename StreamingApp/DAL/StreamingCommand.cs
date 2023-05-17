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
    class StreamingCommand
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
	                                st.codigo, st.nome, st.lancamento, st.nota, st.descricao, st.codigoclassificacao, c.Descricao as classificacao,
	                                st.codigoGenero, g.Descricao as genero, st.codigoTipoStreaming, stt.descricao as tipoStreaming, st.criacao
                                from
	                                tblStreaming st inner join
	                                tblTipoStreaming stt on st.codigoTipoStreaming = stt.codigo inner join
	                                tblClassificacao c on st.codigoClassificacao = c.Codigo inner join
	                                tblGenero g on st.codigoGenero = g.Codigo 
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
        public bool Insert(StreamingModel streaming)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            try
            {
                string sql = @"insert into tblStreaming (
                                    Nome, Lancamento, Nota, Descricao, CodigoClassificacao, 
                                    CodigoGenero, CodigoTipoStreaming)
                                    values (
                                    @nome, @lancamento, @nota, @descricao, @codigoClassificacao, 
                                    @codigoGenero, @codigoTipoStreaming)";
                cmd.CommandText = sql;
                cmd.Connection = con.conectar();
                cmd.Parameters.AddWithValue("@nome", streaming.Nome);
                cmd.Parameters.AddWithValue("@lancamento", streaming.Lancamento);
                cmd.Parameters.AddWithValue("@nota", streaming.Nota);
                cmd.Parameters.AddWithValue("@descricao", streaming.Descricao);
                cmd.Parameters.AddWithValue("@codigoClassificacao", streaming.CodigoClassificacao);
                cmd.Parameters.AddWithValue("@codigoGenero", streaming.CodigoGenero);
                cmd.Parameters.AddWithValue("@codigoTipoStreaming", streaming.CodigoTipoStreaming);


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
        public bool Update(StreamingModel streaming)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            try
            {
                string sql = @"update tblStreaming 
                                set Nome = @nome, Lancamento = @lancamento, Nota = @nota, Descricao = @descricao, 
                                CodigoClassificacao = @codigoClassificacao, CodigoGenero = @codigoGenero ,
                                CodigoTipoStreaming = @codigoTipoStreaming
                             where 
                                codigo = @codigo";
                cmd.CommandText = sql;
                cmd.Connection = con.conectar();
                cmd.Parameters.AddWithValue("@codigo", streaming.Codigo);
                cmd.Parameters.AddWithValue("@nome", streaming.Nome);
                cmd.Parameters.AddWithValue("@lancamento", streaming.Lancamento);
                cmd.Parameters.AddWithValue("@nota", streaming.Nota);
                cmd.Parameters.AddWithValue("@descricao", streaming.Descricao);
                cmd.Parameters.AddWithValue("@codigoClassificacao", streaming.CodigoClassificacao);
                cmd.Parameters.AddWithValue("@codigoGenero", streaming.CodigoGenero);
                cmd.Parameters.AddWithValue("@codigoTipoStreaming", streaming.CodigoTipoStreaming);
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
        public bool Delete(StreamingModel streaming)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();

            try
            {
                string sql = "Delete tblStreaming where codigo = @codigo";
                cmd.CommandText = sql;
                cmd.Connection = con.conectar();
                cmd.Parameters.AddWithValue("@codigo", streaming.Codigo);
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
