using Database.Conexoes;
using Microsoft.Data.SqlClient;
using Negocio.Entidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{
    public class CargoRepository
    {
       public bool Inserir(Cargo cargo)
        {
            try
            {
                var sql = @"INSERT INTO [dbo].[Cargo]
                  ([Nome]
                 ,[Status]
                 ,[CriadoEm]
                 ,[CriadoPor]
                 ,[AlteradoPor]
                 ,[AlteradoEm])
              VALUES
                 (@Nome,
                 ,@Status,
                 ,@CriadoEm, 
                 ,@CriadoPor,
                 ,@AlteradoPor,
                 ,@AlteradoEm)";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                      connection.Open();
                      var cmd = new SqlCommand(sql, connection);
                      cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                      cmd.Parameters.AddWithValue("@Status", cargo.Status);
                      cmd.Parameters.AddWithValue("@CriadoEm", cargo.CriadoEm);
                      cmd.Parameters.AddWithValue("@CriadoPor", cargo.CriadoPor);
                      cmd.Parameters.AddWithValue("@AlteradoPor", cargo.AlteradoPor);
                      cmd.Parameters.AddWithValue("@AlteradoEm", cargo.AlteradoEm);
                      var resposta = cmd.ExecuteNonQuery();
                      connection.Close();  
                      return resposta == 1;
                }

            }
            catch (Exception)
            {

                throw;
            }       
        }

        public bool Arualizar(Cargo cargo)
        {
            try
            {
                var stringConexao = SqlServer.StrConexao();
                var sqlConnection = new SqlConnection(stringConexao);
                sqlConnection.Open();

                var sql = @"UPDATE [dbo].[Cargo]
                  ([Nome]
                 ,[Status]
                 ,[CriadoEm]
                 ,[CriadoPor]
                 ,[AlteradoPor]
                 ,[AlteradoEm])
              VALUES
                 (@Nome,
                 ,@Status,
                 ,@CriadoEm, 
                 ,@CriadoPor,
                 ,@AlteradoPor,
                 ,@AlteradoEm)";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@Status", cargo.Status);
                    cmd.Parameters.AddWithValue("@CriadoEm", cargo.CriadoEm);
                    cmd.Parameters.AddWithValue("@CriadoPor", cargo.CriadoPor);
                    cmd.Parameters.AddWithValue("@AlteradoPor", cargo.AlteradoPor);
                    cmd.Parameters.AddWithValue("@AlteradoEm", cargo.AlteradoEm);
                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }
            }
            catch (Exception)
            {

                throw;
            }           
        }

        public bool Deletar(Cargo cargo)
        {
            try
            {
                var stringConexao = SqlServer.StrConexao();
                var sqlConnection = new SqlConnection(stringConexao);
                sqlConnection.Open();

                var sql = @"DELETE FROM [dbo].[Cargo]
                 WHERE ([Nome]
                 ,[Status]
                 ,[CriadoEm]
                 ,[CriadoPor]
                 ,[AlteradoPor]
                 ,[AlteradoEm])
              VALUES
                 (@Nome,
                 ,@Status,
                 ,@CriadoEm, 
                 ,@CriadoPor,
                 ,@AlteradoPor,
                 ,@AlteradoEm)";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@Status", cargo.Status);
                    cmd.Parameters.AddWithValue("@CriadoEm", cargo.CriadoEm);
                    cmd.Parameters.AddWithValue("@CriadoPor", cargo.CriadoPor);
                    cmd.Parameters.AddWithValue("@AlteradoPor", cargo.AlteradoPor);
                    cmd.Parameters.AddWithValue("@AlteradoEm", cargo.AlteradoEm);
                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ObterTodos(Cargo cargo)
        {
            var sql = @"SELECT * FROM [dbo].[Cargo]";

            SqlDataAdapter dadaAdapter = null;
            var dataTable = new DataTable();
            try
            {
                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    var cmd = connection.CreateCommand();

                    cmd.CommandText = sql;

                    dadaAdapter = new SqlDataAdapter(cmd.CommandText, connection);
                    dadaAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
