namespace WindownsForms.telas.clientes
{
    partial class ClienteCadastado
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
            txtEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cbBolsadeEstudos = new ComboBox();
            chkResponsavel = new CheckBox();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.AutoSize = true;
            lblNomeCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeCompleto.Location = new Point(130, 44);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(122, 21);
            lblNomeCompleto.TabIndex = 0;
            lblNomeCompleto.Text = "Nome completo";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataNascimento.Location = new Point(130, 103);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(147, 21);
            lblDataNascimento.TabIndex = 1;
            lblDataNascimento.Text = "Data de nascimento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(484, 44);
            label1.Name = "label1";
            label1.Size = new Size(37, 21);
            label1.TabIndex = 2;
            label1.Text = "CPF";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(130, 68);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(330, 23);
            txtNomeCompleto.TabIndex = 3;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(484, 68);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(198, 23);
            txtCpf.TabIndex = 4;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(130, 127);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(147, 23);
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
            txtTelefone.Location = new Point(130, 181);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(161, 23);
            txtTelefone.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(130, 157);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 7;
            label2.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(311, 181);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 23);
            txtEmail.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(311, 157);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 9;
            label3.Text = "E-mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(130, 222);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 11;
            label4.Text = "Bolsa de estudos";
            // 
            // cbBolsadeEstudos
            // 
            cbBolsadeEstudos.FormattingEnabled = true;
            cbBolsadeEstudos.Location = new Point(130, 255);
            cbBolsadeEstudos.Name = "cbBolsadeEstudos";
            cbBolsadeEstudos.Size = new Size(121, 23);
            cbBolsadeEstudos.TabIndex = 12;
            // 
            // chkResponsavel
            // 
            chkResponsavel.AutoSize = true;
            chkResponsavel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chkResponsavel.Location = new Point(130, 296);
            chkResponsavel.Name = "chkResponsavel";
            chkResponsavel.Size = new Size(220, 25);
            chkResponsavel.TabIndex = 13;
            chkResponsavel.Text = "Cliente é responsável legal?";
            chkResponsavel.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(484, 329);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // ClienteCadastado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 427);
            Controls.Add(btnSalvar);
            Controls.Add(chkResponsavel);
            Controls.Add(cbBolsadeEstudos);
            Controls.Add(label4);
            Controls.Add(txtEmail);
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
            Name = "ClienteCadastado";
            Text = "ClienteCadastado";
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
        private TextBox txtEmail;
        private Label label3;
        private Label label4;
        private ComboBox cbBolsadeEstudos;
        private CheckBox chkResponsavel;
        private Button btnSalvar;
    }
}