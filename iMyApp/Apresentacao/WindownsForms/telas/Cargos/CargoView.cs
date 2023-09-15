using Database.Repositorios;
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

namespace WindownsForms.telas.Cargos
{
    public partial class CargoView : Form
    {
        int varericar = -1;
        public CargoView()
        {
            InitializeComponent();
        }

        private void CargoView_Load(object sender, EventArgs e)
        {
            carregarCagos();
        }
        private void btnNovoCargo_Click(object sender, EventArgs e)
        {
            groupBoxCargo.Visible = !groupBoxCargo.Visible;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var nome = txtCargo.Text;
            var status = chkStatus.Checked;
            var novoCargo = new Cargo(nome, status);
            var cargo = new CargoRepository();
            if (varericar != -1)
            {
                cargo.Atualizar(novoCargo,varericar);
                MessageBox.Show("Cargo alterado com sucesso!!");
            }       
            else
            {
                cargo.Inserir(novoCargo);

                var resultado = cargo.Inserir(novoCargo);

                if (resultado)
                {
                    MessageBox.Show("Cargo cadastrado com sucesso!!");
                }
                else
                {
                    MessageBox.Show("Não foi possivel gravar o cargo!!");
                }
            }
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            carregarCagos();
        }

        private void gvCargo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                groupBoxCargo.Show();
                DataGridViewRow row = gvCargo.Rows[e.RowIndex];
                txtCargo.Text = row.Cells[1].Value.ToString();
                chkStatus.Checked = Convert.ToBoolean(row.Cells[2].Value.ToString());
                varericar = Convert.ToInt32(row.Cells[0].Value.ToString());
            }
        }

        private void carregarCagos()
        {
            var cargoRepository = new CargoRepository();
            var dataTable = cargoRepository.ObterTodos();
            gvCargo.DataSource = dataTable;
        }
    }
}
