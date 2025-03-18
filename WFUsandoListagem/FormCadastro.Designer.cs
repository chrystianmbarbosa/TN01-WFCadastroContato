namespace WFUsandoListagem
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            txtNovoLogin = new TextBox();
            txtNovaSenha = new TextBox();
            txtConfirmeNovaSenha = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // txtNovoLogin
            // 
            txtNovoLogin.Location = new Point(35, 33);
            txtNovoLogin.Name = "txtNovoLogin";
            txtNovoLogin.PlaceholderText = "Digite o novo login...";
            txtNovoLogin.Size = new Size(277, 23);
            txtNovoLogin.TabIndex = 0;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(35, 91);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.PasswordChar = '*';
            txtNovaSenha.PlaceholderText = "Digite uma senha...";
            txtNovaSenha.Size = new Size(277, 23);
            txtNovaSenha.TabIndex = 1;
            // 
            // txtConfirmeNovaSenha
            // 
            txtConfirmeNovaSenha.Location = new Point(35, 151);
            txtConfirmeNovaSenha.Name = "txtConfirmeNovaSenha";
            txtConfirmeNovaSenha.PasswordChar = '*';
            txtConfirmeNovaSenha.PlaceholderText = "Confirme a nova senha...";
            txtConfirmeNovaSenha.Size = new Size(277, 23);
            txtConfirmeNovaSenha.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.Location = new Point(197, 198);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(115, 44);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 264);
            Controls.Add(btnCadastrar);
            Controls.Add(txtConfirmeNovaSenha);
            Controls.Add(txtNovaSenha);
            Controls.Add(txtNovoLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Novo Usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNovoLogin;
        private TextBox txtNovaSenha;
        private TextBox txtConfirmeNovaSenha;
        private Button btnCadastrar;
    }
}