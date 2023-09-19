namespace WindownsForms.telas.Funcioarios
{
    partial class Funcionario
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
            lblNomeCompleto = new Label();
            lblDataNascimento = new Label();
            label1 = new Label();
            txtNomeCompleto = new TextBox();
            txtCpf = new TextBox();
            dtpDataNascimento = new DateTimePicker();
            pictureBox1 = new PictureBox();
            txtTelefone = new TextBox();
            label2 = new Label();
            txtCidade = new TextBox();
            label3 = new Label();
            btnSalvar = new Button();
            cbCargo = new ComboBox();
            label4 = new Label();
            cbGenero = new ComboBox();
            label5 = new Label();
            txtDepartamento = new TextBox();
            label6 = new Label();
            txtRg = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtNacionalidade = new TextBox();
            label10 = new Label();
            cmbEstadoCivil = new ComboBox();
            label11 = new Label();
            dtpDataAdmissao = new DateTimePicker();
            chkAtivo = new CheckBox();
            label9 = new Label();
            cbEstado = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            txtRua = new TextBox();
            label14 = new Label();
            txtBairro = new TextBox();
            label15 = new Label();
            txtNumero = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeCompleto.Location = new Point(130, 6);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(122, 21);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome completo";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataNascimento.Location = new Point(130, 257);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(147, 21);
            lblDataNascimento.TabIndex = 1;
            lblDataNascimento.Text = "Data de nascimento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(348, 63);
            label1.Name = "label1";
            label1.Size = new Size(37, 21);
            label1.TabIndex = 2;
            label1.Text = "CPF";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(130, 30);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(455, 23);
            txtNomeCompleto.TabIndex = 3;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(348, 87);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(198, 23);
            txtCpf.TabIndex = 4;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(130, 281);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(178, 23);
            dtpDataNascimento.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.simbolo_de_interface_de_camera_fotografica_para_botao;
            pictureBox1.Location = new Point(12, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(593, 87);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(161, 23);
            txtTelefone.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(593, 63);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 7;
            label2.Text = "Telefone";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(127, 460);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(248, 23);
            txtCidade.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(127, 334);
            label3.Name = "label3";
            label3.Size = new Size(161, 21);
            label3.TabIndex = 9;
            label3.Text = "Informe seu endereço";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(566, 540);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(83, 31);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(404, 154);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(245, 23);
            cbCargo.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(404, 130);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 15;
            label4.Text = "Cargo";
            // 
            // cbGenero
            // 
            cbGenero.FormattingEnabled = true;
            cbGenero.Location = new Point(425, 210);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(236, 23);
            cbGenero.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(428, 186);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 17;
            label5.Text = "Genero";
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(680, 154);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(161, 23);
            txtDepartamento.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(680, 130);
            label6.Name = "label6";
            label6.Size = new Size(110, 21);
            label6.TabIndex = 19;
            label6.Text = "Departamento";
            // 
            // txtRg
            // 
            txtRg.Location = new Point(130, 87);
            txtRg.Name = "txtRg";
            txtRg.Size = new Size(198, 23);
            txtRg.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(130, 63);
            label7.Name = "label7";
            label7.Size = new Size(31, 21);
            label7.TabIndex = 21;
            label7.Text = "RG";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(130, 130);
            label8.Name = "label8";
            label8.Size = new Size(109, 21);
            label8.TabIndex = 23;
            label8.Text = "Nacionalidade";
            // 
            // txtNacionalidade
            // 
            txtNacionalidade.Location = new Point(130, 154);
            txtNacionalidade.Name = "txtNacionalidade";
            txtNacionalidade.Size = new Size(248, 23);
            txtNacionalidade.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(127, 186);
            label10.Name = "label10";
            label10.Size = new Size(87, 21);
            label10.TabIndex = 28;
            label10.Text = "Estado civíl";
            // 
            // cmbEstadoCivil
            // 
            cmbEstadoCivil.FormattingEnabled = true;
            cmbEstadoCivil.Location = new Point(130, 210);
            cmbEstadoCivil.Name = "cmbEstadoCivil";
            cmbEstadoCivil.Size = new Size(245, 23);
            cmbEstadoCivil.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(348, 257);
            label11.Name = "label11";
            label11.Size = new Size(114, 21);
            label11.TabIndex = 30;
            label11.Text = "Data Admissão";
            // 
            // dtpDataAdmissao
            // 
            dtpDataAdmissao.Format = DateTimePickerFormat.Short;
            dtpDataAdmissao.Location = new Point(342, 281);
            dtpDataAdmissao.Name = "dtpDataAdmissao";
            dtpDataAdmissao.Size = new Size(147, 23);
            dtpDataAdmissao.TabIndex = 31;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Location = new Point(709, 214);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(54, 19);
            chkAtivo.TabIndex = 32;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(127, 377);
            label9.Name = "label9";
            label9.Size = new Size(56, 21);
            label9.TabIndex = 33;
            label9.Text = "Estado";
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(130, 401);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(236, 23);
            cbEstado.TabIndex = 34;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(127, 436);
            label12.Name = "label12";
            label12.Size = new Size(58, 21);
            label12.TabIndex = 35;
            label12.Text = "Cidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(413, 377);
            label13.Name = "label13";
            label13.Size = new Size(37, 21);
            label13.TabIndex = 37;
            label13.Text = "Rua";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(413, 401);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(248, 23);
            txtRua.TabIndex = 36;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(401, 436);
            label14.Name = "label14";
            label14.Size = new Size(52, 21);
            label14.TabIndex = 39;
            label14.Text = "Bairro";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(401, 460);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(248, 23);
            txtBairro.TabIndex = 38;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(127, 499);
            label15.Name = "label15";
            label15.Size = new Size(68, 21);
            label15.TabIndex = 41;
            label15.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(127, 523);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(93, 23);
            txtNumero.TabIndex = 40;
            // 
            // Funcionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 616);
            Controls.Add(label15);
            Controls.Add(txtNumero);
            Controls.Add(label14);
            Controls.Add(txtBairro);
            Controls.Add(label13);
            Controls.Add(txtRua);
            Controls.Add(label12);
            Controls.Add(cbEstado);
            Controls.Add(label9);
            Controls.Add(chkAtivo);
            Controls.Add(dtpDataAdmissao);
            Controls.Add(label11);
            Controls.Add(cmbEstadoCivil);
            Controls.Add(label10);
            Controls.Add(txtNacionalidade);
            Controls.Add(label8);
            Controls.Add(txtRg);
            Controls.Add(label7);
            Controls.Add(txtDepartamento);
            Controls.Add(label6);
            Controls.Add(cbGenero);
            Controls.Add(label5);
            Controls.Add(cbCargo);
            Controls.Add(label4);
            Controls.Add(btnSalvar);
            Controls.Add(txtCidade);
            Controls.Add(label3);
            Controls.Add(txtTelefone);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(dtpDataNascimento);
            Controls.Add(txtCpf);
            Controls.Add(txtNomeCompleto);
            Controls.Add(label1);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblNomeCompleto);
            Name = "Funcionario";
            Text = "FuncionarioCadastado";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeCompleto;
        private Label lblDataNascimento;
        private Label label1;
        private TextBox txtNomeCompleto;
        private TextBox txtCpf;
        private DateTimePicker dtpDataNascimento;
        private PictureBox pictureBox1;
        private TextBox txtTelefone;
        private Label label2;
        private TextBox txtCidade;
        private Label label3;
        private Button btnSalvar;
        private ComboBox cbCargo;
        private Label label4;
        private ComboBox cbGenero;
        private Label label5;
        private TextBox txtDepartamento;
        private Label label6;
        private TextBox txtRg;
        private Label label7;
        private Label label8;
        private TextBox txtNacionalidade;
        private Label label10;
        private ComboBox cmbEstadoCivil;
        private Label label11;
        private DateTimePicker dtpDataAdmissao;
        private CheckBox chkAtivo;
        private Label label9;
        private ComboBox cbEstado;
        private Label label12;
        private Label label13;
        private TextBox txtRua;
        private Label label14;
        private TextBox txtBairro;
        private Label label15;
        private TextBox txtNumero;
    }
}