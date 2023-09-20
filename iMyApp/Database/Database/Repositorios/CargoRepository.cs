using Database.Conexoes;
using Microsoft.Data.SqlClient;
using Negocio.Entidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{
    /// <summary>
    /// <c>CargoRepository</c> - Executa comandos SQL (CRUD) na tabela de [dbo]. [Cargo]
    /// <example>Exemplo:
    ///     var repository = new CargoRepository();
    /// </example>Example>
    /// </summary>
    public class CargoRepository
    {
        /// <summary>
        /// Insere um novo registro na tabela Cargo
        /// <example>
        /// <code>
        ///     var repositorio = new CargoRepository();
        ///     var cargo = new Cargo("Nome", "Status");
        ///     var resultado = repository.Inserir(cargo);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="cargo">/Entidade->Cargo</param>
        /// <returns>true ou false</returns>
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
                 @Status,
                 @CriadoEm, 
                 @CriadoPor,
                 @AlteradoPor,
                 @AlteradoEm)";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Nome", cargo.Nome);
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

        public bool Atualizar(Cargo cargo, int id)
        {
            try
            {
                var stringConexao = SqlServer.StrConexao();
                var sqlConnection = new SqlConnection(stringConexao);
                sqlConnection.Open();

                var sql = @"UPDATE [dbo].[Cargo]
                           SET [Nome] = @Nome
                              ,[Status] = @Status
                              ,[AlteradoPor] = @AlteradoPor
                              ,[AlteradoEm] =@AlteradoEm
                         WHERE Id = @Id";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@Status", cargo.Status);
                    cmd.Parameters.AddWithValue("@AlteradoPor", cargo.AlteradoPor);
                    cmd.Parameters.AddWithValue("@AlteradoEm", cargo.AlteradoEm);
                    cmd.Parameters.AddWithValue("@Id", id);
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

        public bool Deletar(int cargoId)
        {
            try
            {
                var sql = @"DELETE FROM [dbo].[Cargo]
                          WHERE Id = @Id";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Id", cargoId);

                    var resposta = cmd.ExecuteNonQuery();
                    connection.Close();
                    return resposta == 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ObterTodos()
        {
            var sql = @"SELECT [Id]
                      ,[Nome]
                      ,[Status]      
                      ,[AlteradoEm]
                  FROM [dbo].[Cargo]";

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

        public List<string> Complemento(string cargo)
        {
            var sql = @"SELECT [Nome] FROM [dbo].[Cargo]";

            try
            {
                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    SqlCommand com = new SqlCommand(sql, connection);                    
                    
                    SqlDataReader reader = com.ExecuteReader();

                    var lista = new List<string>();

                    while (reader.Read())
                    {
                        lista.Add(reader.GetString(0).Trim());
                    }

                    return lista;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
