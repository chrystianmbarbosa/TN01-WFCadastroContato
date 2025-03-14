namespace TN01_WFCadastroContato
{
    partial class FormContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContato));
            lblNome = new Label();
            txtNome = new TextBox();
            txtSobrenome = new TextBox();
            lblSobreNome = new Label();
            mtbDddTelefone = new MaskedTextBox();
            lblLinha = new Label();
            lblDddTelefone = new Label();
            lblLinha2 = new Label();
            gbxTipoTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbPessoal = new RadioButton();
            rdbComercial = new RadioButton();
            txtEmail = new TextBox();
            lblEmail = new Label();
            btnVoltar = new Button();
            btnSalvar = new Button();
            gbxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(27, 27);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(32, 50);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(238, 23);
            txtNome.TabIndex = 1;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(304, 50);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(266, 23);
            txtSobrenome.TabIndex = 3;
            // 
            // lblSobreNome
            // 
            lblSobreNome.AutoSize = true;
            lblSobreNome.Location = new Point(304, 27);
            lblSobreNome.Name = "lblSobreNome";
            lblSobreNome.Size = new Size(71, 15);
            lblSobreNome.TabIndex = 2;
            lblSobreNome.Text = "Sobrenome:";
            // 
            // mtbDddTelefone
            // 
            mtbDddTelefone.Location = new Point(31, 150);
            mtbDddTelefone.Mask = "(99) 00000-0000";
            mtbDddTelefone.Name = "mtbDddTelefone";
            mtbDddTelefone.Size = new Size(239, 23);
            mtbDddTelefone.TabIndex = 4;
            // 
            // lblLinha
            // 
            lblLinha.BorderStyle = BorderStyle.Fixed3D;
            lblLinha.Location = new Point(33, 91);
            lblLinha.Name = "lblLinha";
            lblLinha.Size = new Size(537, 1);
            lblLinha.TabIndex = 5;
            // 
            // lblDddTelefone
            // 
            lblDddTelefone.AutoSize = true;
            lblDddTelefone.Location = new Point(27, 132);
            lblDddTelefone.Name = "lblDddTelefone";
            lblDddTelefone.Size = new Size(83, 15);
            lblDddTelefone.TabIndex = 6;
            lblDddTelefone.Text = "DDD/Telefone:";
            // 
            // lblLinha2
            // 
            lblLinha2.BorderStyle = BorderStyle.Fixed3D;
            lblLinha2.Location = new Point(32, 214);
            lblLinha2.Name = "lblLinha2";
            lblLinha2.Size = new Size(537, 1);
            lblLinha2.TabIndex = 7;
            // 
            // gbxTipoTelefone
            // 
            gbxTipoTelefone.Controls.Add(rdbRecado);
            gbxTipoTelefone.Controls.Add(rdbPessoal);
            gbxTipoTelefone.Controls.Add(rdbComercial);
            gbxTipoTelefone.Location = new Point(334, 129);
            gbxTipoTelefone.Name = "gbxTipoTelefone";
            gbxTipoTelefone.Size = new Size(236, 55);
            gbxTipoTelefone.TabIndex = 8;
            gbxTipoTelefone.TabStop = false;
            gbxTipoTelefone.Text = "Tipo Telefone";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(164, 22);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 2;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(94, 22);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 1;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(9, 22);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 0;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(33, 263);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(537, 23);
            txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(27, 240);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "E-mail:";
            // 
            // btnVoltar
            // 
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(395, 328);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(79, 44);
            btnVoltar.TabIndex = 11;
            btnVoltar.Text = "Voltar";
            btnVoltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(489, 328);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 44);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 389);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(gbxTipoTelefone);
            Controls.Add(lblLinha2);
            Controls.Add(lblDddTelefone);
            Controls.Add(lblLinha);
            Controls.Add(mtbDddTelefone);
            Controls.Add(txtSobrenome);
            Controls.Add(lblSobreNome);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormContato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Contato";
            gbxTipoTelefone.ResumeLayout(false);
            gbxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtSobrenome;
        private Label lblSobreNome;
        private MaskedTextBox mtbDddTelefone;
        private Label lblLinha;
        private Label lblDddTelefone;
        private Label lblLinha2;
        private GroupBox gbxTipoTelefone;
        private RadioButton rdbRecado;
        private RadioButton rdbPessoal;
        private RadioButton rdbComercial;
        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnVoltar;
        private Button btnSalvar;
    }
}