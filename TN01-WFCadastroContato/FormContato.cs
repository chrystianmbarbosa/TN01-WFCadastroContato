using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01_WFCadastroContato
{
    public partial class FormContato : Form
    {
        public FormContato()
        {
            InitializeComponent();
        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Sucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LimparFormulario()
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            txtEmail.Clear();
            mtbDddTelefone.Clear();
            rdbComercial.Checked = false;
            rdbPessoal.Checked = false;
            rdbRecado.Checked = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Não usei o Exclude Prompt Literals
            string semMaskTelefone = mtbDddTelefone.Text
                .Replace("(", "")
                .Replace(")", "")
                .Replace(" ", "")
                .Replace("-", "");

            //Verifica Nome Vazio
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                Erro("Campo Nome não pode estar Vazio!");
                return;
            }
            //Verifica SobreNome Vazio
            else if (string.IsNullOrEmpty(txtSobrenome.Text))
            {
                Erro("Campo Sobrenome não pode estar Vazio!");
                return;
            }
            //Verifica DDD e o Telefone Vazios
            else if (string.IsNullOrEmpty(semMaskTelefone))
            {
                Erro("Campo Telefone não pode estar Vazio!");
                return;
            }
            //Verifica Email Vazios
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                Erro("Campo Email não pode estar Vazio!");
                return;
            }

            ETipoTelefone tipoTelefone;
            //Se todos os radios estão desmarcados
            if (!rdbComercial.Checked && !rdbPessoal.Checked && !rdbRecado.Checked)
            {
                Erro("Deve-se marcar uma opção de Tipo de Telefone!");
                return;
            }
            else
            {
                if (rdbComercial.Checked)
                    tipoTelefone = ETipoTelefone.Comercial;
                else if (rdbPessoal.Checked)
                    tipoTelefone = ETipoTelefone.Pessoal;
                else
                    tipoTelefone = ETipoTelefone.Recado;
            }

            Contato c1 = new Contato();
            c1.Codigo = 0;
            c1.Nome = txtNome.Text;
            c1.Sobrenome = txtSobrenome.Text;
            c1.Email = txtEmail.Text;
            c1.TipoTelefone = tipoTelefone;

            // Usou a Propriedade (Exclude Prompt Literals)
            //1 1 9 8 7 6 5 4 3 2 1  //Caracteres
            //0 1 2 3 4 5 6 7 8 9 10 //Index(posição)

            c1.Ddd = mtbDddTelefone.Text.Substring(0, 2);
            c1.Telefone = mtbDddTelefone.Text.Substring(2);

            // Não Usou a Propriedade (Exclude Prompt Literals)
            // E limpou os caracteres com o .Replace()
            //1 1 9 8 7 6 5 4 3 2 1  //Caracteres
            //0 1 2 3 4 5 6 7 8 9 10 //Index(posição)
            c1.Ddd = semMaskTelefone.Substring(0, 2);
            c1.Telefone = semMaskTelefone.Substring(2);

            Contato.ListaContatos.Add(c1);
            
            Sucesso("Cadastrado com Sucesso!");

            LimparFormulario();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
