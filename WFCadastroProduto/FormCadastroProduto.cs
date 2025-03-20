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
            int totalLista = Produto.ObterLista().Count + 1;
            mtbCodigo.Text = totalLista.ToString("D4");
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

            switch (cbxCategoria.SelectedItem?.ToString())
            {
                case "Açougue":
                    prod.Categoria = ECategoria.Açougue;
                    break;
                case "Hortifruti":
                    prod.Categoria = ECategoria.Hortifruti;
                    break;
                case "Eletrônicos":
                    prod.Categoria = ECategoria.Eletrônicos;
                    break;
                case "Limpeza":
                    prod.Categoria = ECategoria.Limpeza;
                    break;
                case "Padaria":
                    prod.Categoria = ECategoria.Padaria;
                    break;
                case "Frios":
                    prod.Categoria = ECategoria.Frios;
                    break;
                case "Laticínios":
                    prod.Categoria = ECategoria.Laticínios;
                    break;
                case "Peixaria":
                    prod.Categoria = ECategoria.Peixaria;
                    break;
                case "Cesta Básica":
                    prod.Categoria = ECategoria.CestaBasica;
                    break;
                default:
                    prod.Categoria = ECategoria.Outros;
                    break;
            }

            prod.Observacao = rtbObservacao.Text;

            prod.Cadastrar();

            Info("Cadastro Efetuado com Sucesso!");

            LimparCampos();
            int totalLista = Produto.ObterLista().Count + 1;
            mtbCodigo.Text = totalLista.ToString("D4");


        }
    }
}
