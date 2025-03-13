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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Jeito 2 (Mantendo as máscaras do maskedTextBox)
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

            string tipoTelefone = "";
            //Se todos os radios estão desmarcados
            if (!rdbComercial.Checked && !rdbPessoal.Checked && !rdbRecado.Checked)
            {
                Erro("Deve-se marcar uma opção de Tipo de Telefone!");
                return;
            }
            else
            {
                if (rdbComercial.Checked)
                    tipoTelefone = "Comercial";
                else if (rdbPessoal.Checked)
                    tipoTelefone = "Pessoal";
                else
                    tipoTelefone = "Recado";
            }
            //Jeito 1 (Retirando as máscaras do maskedTextBox)
            //string dddTelefone =
            //    "(" + mtbDddTelefone.Text.Substring(0, 2) + ") "
            //    + mtbDddTelefone.Text.Substring(2, 5) + "-"
            //    + mtbDddTelefone.Text.Substring(7);

            
            string mensagem = @$"
                    Nome Completo: {txtNome.Text} {txtSobrenome.Text}
                    Tipo Telefone: {tipoTelefone}
                    DDD/Telefone: {mtbDddTelefone.Text}
                    Email: {txtEmail.Text}
                    ";

            Sucesso(mensagem);

        }
    }
}
