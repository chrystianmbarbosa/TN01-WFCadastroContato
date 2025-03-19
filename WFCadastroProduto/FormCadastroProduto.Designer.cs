namespace WFCadastroProduto
{
    partial class FormCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            lblCodigo = new Label();
            mtbCodigo = new MaskedTextBox();
            lblCategoria = new Label();
            cbxCategoria = new ComboBox();
            lblNomeProduto = new Label();
            txtNomeProduto = new TextBox();
            nudPreco = new NumericUpDown();
            lblPreco = new Label();
            lblDataVencimento = new Label();
            dtpDataVencimento = new DateTimePicker();
            lblObservacao = new Label();
            rtbObservacao = new RichTextBox();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPreco).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(36, 27);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // mtbCodigo
            // 
            mtbCodigo.Location = new Point(36, 45);
            mtbCodigo.Mask = "0000";
            mtbCodigo.Name = "mtbCodigo";
            mtbCodigo.Size = new Size(81, 23);
            mtbCodigo.TabIndex = 1;
            mtbCodigo.ValidatingType = typeof(int);
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(138, 28);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Items.AddRange(new object[] { "Açougue", "Hortaliças", "Eletrônicos", "Limpeza", "Padaria", "Frios", "Laticínios", "Peixaria", "Cesta Básica" });
            cbxCategoria.Location = new Point(142, 47);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(168, 23);
            cbxCategoria.TabIndex = 3;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(36, 93);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(103, 15);
            lblNomeProduto.TabIndex = 4;
            lblNomeProduto.Text = "Nome do Produto";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(38, 111);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(272, 23);
            txtNomeProduto.TabIndex = 5;
            // 
            // nudPreco
            // 
            nudPreco.DecimalPlaces = 2;
            nudPreco.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            nudPreco.Location = new Point(38, 175);
            nudPreco.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudPreco.Name = "nudPreco";
            nudPreco.Size = new Size(120, 23);
            nudPreco.TabIndex = 6;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(36, 157);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 7;
            lblPreco.Text = "Preço";
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Location = new Point(169, 157);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new Size(113, 15);
            lblDataVencimento.TabIndex = 8;
            lblDataVencimento.Text = "Data de Vencimento";
            // 
            // dtpDataVencimento
            // 
            dtpDataVencimento.Format = DateTimePickerFormat.Short;
            dtpDataVencimento.Location = new Point(174, 178);
            dtpDataVencimento.Name = "dtpDataVencimento";
            dtpDataVencimento.Size = new Size(136, 23);
            dtpDataVencimento.TabIndex = 9;
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Location = new Point(38, 230);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(69, 15);
            lblObservacao.TabIndex = 10;
            lblObservacao.Text = "Observação";
            // 
            // rtbObservacao
            // 
            rtbObservacao.Location = new Point(39, 263);
            rtbObservacao.Name = "rtbObservacao";
            rtbObservacao.Size = new Size(271, 96);
            rtbObservacao.TabIndex = 11;
            rtbObservacao.Text = "";
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.Location = new Point(221, 377);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(89, 44);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // FormCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 450);
            Controls.Add(btnSalvar);
            Controls.Add(rtbObservacao);
            Controls.Add(lblObservacao);
            Controls.Add(dtpDataVencimento);
            Controls.Add(lblDataVencimento);
            Controls.Add(lblPreco);
            Controls.Add(nudPreco);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblNomeProduto);
            Controls.Add(cbxCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(mtbCodigo);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produto";
            ((System.ComponentModel.ISupportInitialize)nudPreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private MaskedTextBox mtbCodigo;
        private Label lblCategoria;
        private ComboBox cbxCategoria;
        private Label lblNomeProduto;
        private TextBox txtNomeProduto;
        private NumericUpDown nudPreco;
        private Label lblPreco;
        private Label lblDataVencimento;
        private DateTimePicker dtpDataVencimento;
        private Label lblObservacao;
        private RichTextBox rtbObservacao;
        private Button btnSalvar;
    }
}