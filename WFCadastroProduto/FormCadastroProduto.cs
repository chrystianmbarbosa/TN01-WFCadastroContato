using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastroProduto
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
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

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            mtbCodigo.Text = "00" + Produto.ObterLista().Count + 1;
            dtpDataVencimento.Value = DateTime.Today;
        }

        public bool CamposNaoPreenchidos()
        {
            if (string.IsNullOrEmpty(mtbCodigo.Text))
                return true;
            if (cbxCategoria.SelectedIndex == -1)
                return true;
            if (string.IsNullOrEmpty(txtNomeProduto.Text))
                return true;
            if (nudPreco.Value <= 0)
                return true;
            if (dtpDataVencimento.Value == DateTime.Today)
                return true;
            if (string.IsNullOrEmpty(rtbObservacao.Text))
                return true;

            return false;
        }

        private void LimparCampos()
        {
            mtbCodigo.Clear();
            txtNomeProduto.Clear();
            rtbObservacao.Clear();
            dtpDataVencimento.Value = DateTime.Today;
            cbxCategoria.SelectedIndex = -1;
            nudPreco.Value = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (CamposNaoPreenchidos() == true)
            {
                Erro("Os Campos Obrigatórios devem ser Preenchidos");
                return;
            }

            Produto prod = new Produto();
            prod.Codigo = int.Parse(mtbCodigo.Text);
            prod.Nome = txtNomeProduto.Text;
            prod.Preco = Convert.ToDouble(nudPreco.Value);
            prod.DataVencimento = dtpDataVencimento.Value;
            prod.Categoria = cbxCategoria.SelectedItem!.ToString();
            prod.Observacao = rtbObservacao.Text;

            prod.Cadastrar();

            Info("Cadastro Efetuado com Sucesso!");

            LimparCampos();
            int totalLista = Produto.ObterLista().Count + 1;
            mtbCodigo.Text = "000" + totalLista;


        }
    }
}
