using Database.Conexoes;
using Microsoft.Data.SqlClient;
using Negocio.Comum;
using Negocio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{
    public class FuncionarioRepository
    {

        public bool Inserir(Colaborador funcionario)
        {
            try
            {
                var sql = @"INSERT INTO [dbo].[Colaborador]
                               ([Nome]
                               ,[Telefone]
                               ,[Nascimento]
                               ,[cpf]
                               ,[Genero]
                               ,[Departamento]
                               ,[Rg]
                               ,[Status]
                               ,[EndecoEstado]
                               ,[EnderecoCidade]
                               ,[EnderecoRua]
                               ,[EnderecoBairro]
                               ,[EnderecoNumero]
                               ,[EstadoCivil]
                               ,[Nacionalidade]
                               ,[Cargo]
                               ,[DataAdmissao]
                               ,[CriadoEm]
                               ,[CriadoPor]
                               ,[AlteradoEM]
                               ,[AlteradoPor])
                         VALUES
                               (Nome
                               ,Telefone
                               ,Nascimento 
                               ,cpf
                               ,Genero
                               ,Departamento
                               ,Rg
                               ,Status
                               ,EndecoEstado
                               ,EnderecoCidade
                               ,EnderecoRua
                               ,EnderecoBairro
                               ,EnderecoNumero
                               ,EstadoCivil
                               ,Nacionalidade
                               ,Cargo
                               ,DataAdmissao
                               ,CriadoEm
                               ,CriadoPor
                               ,AlteradoEM
                               ,AlteradoPor)";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("@Telefone", funcionario.Telefone);
                    cmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                    cmd.Parameters.AddWithValue("@Genero", funcionario.Genero);
                    cmd.Parameters.AddWithValue("@Departamento", funcionario.Departamento);
                    cmd.Parameters.AddWithValue("@Departamento", funcionario.Rg);
                    cmd.Parameters.AddWithValue("@Departamento", funcionario.Status);
                    cmd.Parameters.AddWithValue("@Departamento", funcionario.EndecoEstado);
                    cmd.Parameters.AddWithValue("@Departamento", funcionario.EnderecoCidade);
                    cmd.Parameters.AddWithValue("@Departamento", funcionario.EnderecoRua);
                    cmd.Parameters.AddWithValue("@Departamento", funcionario.EnderecoBairro);
                    cmd.Parameters.AddWithValue("@Departamento", funcionario.EnderecoNumero);
                    cmd.Parameters.AddWithValue("@Departamento", funcionario.EstadoCivil);
                    cmd.Parameters.AddWithValue("@Departamento", funcionario.Nacionalidade);
                    cmd.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
                    cmd.Parameters.AddWithValue("@DataAdmissao", funcionario.Admissao);
                    cmd.Parameters.AddWithValue("@CriadoEm", funcionario.CriadoEm);
                    cmd.Parameters.AddWithValue("@CriadoPor", funcionario.CriadoPor);
                    cmd.Parameters.AddWithValue("@AlteradoPor", funcionario.AlteradoEm);
                    cmd.Parameters.AddWithValue("@AlteradoEm", funcionario.AlteradoPor);
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
    }
}
