using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Conexoes
{
    /// <summary>
    /// A <c>SqlServer</c> é uma classe estatica com a string de conexão com SqlServer
    /// </summary>
    internal static class SqlServer
    {
        /// <summary>
        /// Metodo <c>StrConexaao()</c> retorna a string de conexão sql
        /// </summary>
        /// <returns> string: ConnectionString</returns>
        internal static string StrConexao() 
        {
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=IMyApp;User ID=sa;Password=sql2022;Trusted_Connection=False; TrustServerCertificate=True;"; 
        }
    }
}
