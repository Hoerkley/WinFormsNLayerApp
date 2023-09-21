using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Validators
{
    public static partial class Validacoes
    {
        /// <summary>
        /// Valida as DataAnotattions de uma classe.
        /// <example>Exemplo:
        /// <code>
        ///     var erros = Validacao.getValidationErros(obj);
        ///     foreach(var error in erros)
        ///     {
        ///         MessageBox.Show((error.ErrorMessage));
        ///     }
        /// </code>
        /// </example>
        /// <param nome="obj">é a classe instanciada</param>
        /// <returs>Lista de erros</returs>
        /// </summary>

        public static IEnumerable<ValidationResult> getValidationErros(object obj)
        {
            var resultadoValidacao = new List<ValidationResult>(); 
            var contexto = new ValidationContext(obj, null, null);
            Validator.TryValidateObject(obj, contexto, resultadoValidacao, true);
            return resultadoValidacao;
        }
    }
}
