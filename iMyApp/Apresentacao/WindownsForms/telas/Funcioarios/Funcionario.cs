using Database.Repositorios;
using Negocio.Comum;
using Negocio.Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindownsForms.telas.Funcioarios
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var nome = txtNomeCompleto.Text;
            var cpf = txtCpf.Text;
            var telefone = txtTelefone.Text;
            var cargo = cbCargo.Text;
            var departamento = txtDepartamento.Text;
            /*
            var novoFuncionario = new Colaborador(cargo,departamento,nome);
            */ 
            var funcionario = new FuncionarioRepository();


        }
    }
}
