namespace WFCadastroProduto
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAcessar = new Button();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            SuspendLayout();
            // 
            // btnAcessar
            // 
            btnAcessar.Location = new Point(133, 151);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(75, 23);
            btnAcessar.TabIndex = 5;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(27, 94);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Digite a sua senha...";
            txtSenha.Size = new Size(181, 23);
            txtSenha.TabIndex = 4;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(27, 34);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Digite o seu Login...";
            txtLogin.Size = new Size(181, 23);
            txtLogin.TabIndex = 3;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 211);
            Controls.Add(btnAcessar);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Acesso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAcessar;
        private TextBox txtSenha;
        private TextBox txtLogin;
    }
}
