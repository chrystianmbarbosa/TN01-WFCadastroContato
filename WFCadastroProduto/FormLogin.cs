namespace WFCadastroProduto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Atencao(string mensagem)
        {
            MessageBox.Show(mensagem, "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Info(string mensagem)
        {
            MessageBox.Show(mensagem, "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Codigo = 001;
            user.Login = "admin";
            user.Senha = "123456";
            user.DtCadastro =
                DateTime.Parse("18/03/2025 18:30");
            user.Cadastrar();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            foreach (Usuario us in Usuario.TodosOsUsuarios())
            {
                if ((txtLogin.Text == us.Login)
                    && (txtSenha.Text == us.Senha))
                {
                    FormMenu form = new FormMenu();
                    form.ShowDialog();

                    //Limpa os dados dos componentes
                    txtLogin.Clear();
                    txtSenha.Clear();

                    return;
                }
            }

            txtSenha.Clear();
            Erro("Úsuário e Senha não se encontram na base!");
            return;
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAcessar_Click(sender, e);
            }
        }
    }
}
