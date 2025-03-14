namespace TN01_WFCadastroContato
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            mnsCadastrar = new ToolStripMenuItem();
            mnsSobre = new ToolStripMenuItem();
            mnsSair = new ToolStripMenuItem();
            picMenu = new PictureBox();
            mnsListagem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnsCadastrar, mnsSobre, mnsListagem, mnsSair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(573, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnsCadastrar
            // 
            mnsCadastrar.Name = "mnsCadastrar";
            mnsCadastrar.Size = new Size(69, 20);
            mnsCadastrar.Text = "Cadastrar";
            mnsCadastrar.Click += mnsCadastrar_Click;
            // 
            // mnsSobre
            // 
            mnsSobre.Name = "mnsSobre";
            mnsSobre.Size = new Size(49, 20);
            mnsSobre.Text = "Sobre";
            mnsSobre.Click += mnsSobre_Click;
            // 
            // mnsSair
            // 
            mnsSair.Name = "mnsSair";
            mnsSair.Size = new Size(38, 20);
            mnsSair.Text = "Sair";
            mnsSair.Click += mnsSair_Click;
            // 
            // picMenu
            // 
            picMenu.Dock = DockStyle.Fill;
            picMenu.Image = (Image)resources.GetObject("picMenu.Image");
            picMenu.Location = new Point(0, 24);
            picMenu.Name = "picMenu";
            picMenu.Size = new Size(573, 366);
            picMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            picMenu.TabIndex = 1;
            picMenu.TabStop = false;
            // 
            // mnsListagem
            // 
            mnsListagem.Name = "mnsListagem";
            mnsListagem.Size = new Size(67, 20);
            mnsListagem.Text = "Listagem";
            mnsListagem.Click += mnsListagem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 390);
            Controls.Add(picMenu);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnsCadastrar;
        private ToolStripMenuItem mnsSobre;
        private ToolStripMenuItem mnsSair;
        private PictureBox picMenu;
        private ToolStripMenuItem mnsListagem;
    }
}
