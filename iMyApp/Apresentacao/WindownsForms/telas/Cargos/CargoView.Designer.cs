﻿namespace WindownsForms.telas.Cargos
{
    partial class CargoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            chkStatus = new CheckBox();
            btnSalvar = new Button();
            groupBoxCargo = new GroupBox();
            txtCargo = new TextBox();
            btnNovoCargo = new Button();
            gvCargo = new DataGridView();
            label1 = new Label();
            btnRecarregar = new Button();
            groupBoxCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvCargo).BeginInit();
            SuspendLayout();
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chkStatus.Location = new Point(429, 21);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(95, 21);
            chkStatus.TabIndex = 0;
            chkStatus.Text = "Cargo ativo";
            chkStatus.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.FlatStyle = FlatStyle.Popup;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(617, 21);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(65, 24);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // groupBoxCargo
            // 
            groupBoxCargo.Controls.Add(btnSalvar);
            groupBoxCargo.Controls.Add(txtCargo);
            groupBoxCargo.Controls.Add(chkStatus);
            groupBoxCargo.Location = new Point(12, 46);
            groupBoxCargo.Name = "groupBoxCargo";
            groupBoxCargo.Size = new Size(701, 53);
            groupBoxCargo.TabIndex = 2;
            groupBoxCargo.TabStop = false;
            groupBoxCargo.Text = "Novo cargo";
            groupBoxCargo.Visible = false;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(6, 22);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(403, 23);
            txtCargo.TabIndex = 3;
            // 
            // btnNovoCargo
            // 
            btnNovoCargo.FlatStyle = FlatStyle.Popup;
            btnNovoCargo.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNovoCargo.Location = new Point(12, 12);
            btnNovoCargo.Name = "btnNovoCargo";
            btnNovoCargo.Size = new Size(83, 28);
            btnNovoCargo.TabIndex = 2;
            btnNovoCargo.Text = "Novo cargo";
            btnNovoCargo.UseVisualStyleBackColor = true;
            btnNovoCargo.Click += btnNovoCargo_Click;
            // 
            // gvCargo
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gvCargo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gvCargo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            gvCargo.DefaultCellStyle = dataGridViewCellStyle4;
            gvCargo.Location = new Point(1, 161);
            gvCargo.Name = "gvCargo";
            gvCargo.RowTemplate.Height = 25;
            gvCargo.Size = new Size(799, 294);
            gvCargo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1, 137);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 4;
            label1.Text = "Todos os cargos";
            // 
            // btnRecarregar
            // 
            btnRecarregar.FlatStyle = FlatStyle.Popup;
            btnRecarregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRecarregar.Location = new Point(705, 131);
            btnRecarregar.Name = "btnRecarregar";
            btnRecarregar.Size = new Size(83, 24);
            btnRecarregar.TabIndex = 4;
            btnRecarregar.Text = "Recarregar";
            btnRecarregar.UseVisualStyleBackColor = true;
            // 
            // CargoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRecarregar);
            Controls.Add(label1);
            Controls.Add(gvCargo);
            Controls.Add(btnNovoCargo);
            Controls.Add(groupBoxCargo);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "CargoView";
            Text = "CargoView";
            groupBoxCargo.ResumeLayout(false);
            groupBoxCargo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvCargo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkStatus;
        private Button btnSalvar;
        private GroupBox groupBoxCargo;
        private TextBox txtCargo;
        private Button btnNovoCargo;
        private DataGridView gvCargo;
        private Label label1;
        private Button btnRecarregar;
    }
}