namespace WFUsandoListagem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Codigo = 1;
            us.Login = "user";
            us.Senha = "123456";
            us.DtCadastro =
                Convert.ToDateTime("10/01/2025 18:30");

            Usuario.ListaUsuarios.Add(us);
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                Erro("O Campo Login não pode estar vazio!");
                return;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                Erro("O Campo Senha não pode estar vazio!");
                return;
            }

            foreach (Usuario u in Usuario.ListaUsuarios)
            {
                if (u.Login == txtLogin.Text)
                {
                    if (u.Senha == txtSenha.Text)
                    {
                        FormMain form = new FormMain();
                        form.ShowDialog();

                        this.txtLogin.Clear();
                        this.txtSenha.Clear();

                        return;
                    }
                }

            }

            Erro("Usuario e Senha não se encontra na Base!");
            return ;
        }
    }
}
