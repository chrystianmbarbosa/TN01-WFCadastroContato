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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroProduto form = new FormCadastroProduto();
            form.ShowDialog();
        }

        private void mnsListar_Click(object sender, EventArgs e)
        {
            FormListaProduto form = new FormListaProduto();
            form.ShowDialog();
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta =
                MessageBox.Show("Você deseja realmente sair?", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
