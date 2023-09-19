using Database.Repositorios;
using Microsoft.Data.SqlClient;
using Negocio.Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace WindownsForms.telas.Cargos
{
    public partial class CargoView : Form
    {
        int varericar = -1;
        public CargoView()
        {
            InitializeComponent();
        }
        private void gvCargo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cargoRepository = new CargoRepository();
            DataGridViewRow row = gvCargo.Rows[e.RowIndex];

            if (gvCargo.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Deseja realmente deletar o registro?",
                    "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var resulatdo = cargoRepository.Deletar(int.Parse(row.Cells[1].Value.ToString()));
                    MessageBox.Show("Registro deletado com sucesso!!");
                };
                return;
            }

            if (e.RowIndex >= 0)
            {
                groupBoxCargo.Show();
                btnSalvar.Text = "Atualizar";
                txtCargo.Text = row.Cells[2].Value.ToString();
                chkStatus.Checked = Convert.ToBoolean(row.Cells[3].Value.ToString());
                varericar = Convert.ToInt32(row.Cells[1].Value);
            }
        }
        private void CargoView_Load(object sender, EventArgs e)
        {
            carregarCagos();
        }
        private void btnNovoCargo_Click(object sender, EventArgs e)
        {
            txtCargo.Clear();
            groupBoxCargo.Visible = !groupBoxCargo.Visible;
            btnSalvar.Text = "Cadastrar";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;

            var nome = txtCargo.Text;
            var status = chkStatus.Checked;
            var novoCargo = new Cargo(nome, status);
            var cargo = new CargoRepository();
            switch (botao.Text)
            {
                case "Cadastrar":
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
                        //cadastar
                        break;
                    }
                case "Salvar":
                    {
                        cargo.Atualizar(novoCargo, varericar);
                        MessageBox.Show("Cargo alterado com sucesso!!");
                        //cadastar
                        break;
                    }
                default:
                    break;
            }
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            carregarCagos();
        }

        private void carregarCagos()
        {
            var cargoRepository = new CargoRepository();
            var dataTable = cargoRepository.ObterTodos();
            gvCargo.DataSource = dataTable;
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            
            var nome = txtCargo.Text;
            var cargo = new CargoRepository();

            var reader = cargo.Complemento(nome);

            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();


            foreach (var i in reader)
            {
                autoCompleteStringCollection.Add(i);  
            }

            txtCargo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCargo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCargo.AutoCompleteCustomSource = autoCompleteStringCollection;                 
        }
    }
}
