using Negocio.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidade
{
    public class Colaborador : Pessoa
    {
        public string Cargo { get; set; }
        public string Departamento { get; set; }

        public Colaborador(string cargo, string departamento, string nome) 
        {
            Cargo = cargo;
            Departamento = departamento;
            Nome = nome;

            CriadoEm = DateTime.Now;
            CriadoPor = nome;

            AlteradoEm = DateTime.Now;
            AlteradoPor = nome;
        }
    }
}
