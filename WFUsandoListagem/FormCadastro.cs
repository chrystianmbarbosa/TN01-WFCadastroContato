using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFUsandoListagem
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNovoLogin.Text))
            {
                Erro("O login não podem ser vazio!");
                return;
            }

            if (string.IsNullOrEmpty(txtNovaSenha.Text))
            {
                Erro("As Senhas não podem ser vazias!");
                return;
            }

            if(txtNovaSenha.Text != txtConfirmeNovaSenha.Text)
            {
                Erro("As Senhas devem ser iguais!");
                return;
            }

            Usuario novoUs = new Usuario();
            novoUs.Codigo = Usuario.ListaUsuarios.Count + 1;
            novoUs.Login = txtNovoLogin.Text;
            novoUs.Senha = txtNovaSenha.Text;
            novoUs.DtCadastro = DateTime.Now;

            Usuario.ListaUsuarios.Add(novoUs);

            Close();

            FormListagem form = new FormListagem();
            form.ShowDialog();

        }
    }
}
