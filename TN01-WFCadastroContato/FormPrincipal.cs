namespace TN01_WFCadastroContato
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormContato form = new FormContato();
            form.ShowDialog();
        }

        private void mnsListagem_Click(object sender, EventArgs e)
        {
            FormListagem form = new FormListagem();
            form.ShowDialog();
        }

        private void mnsSobre_Click(object sender, EventArgs e)
        {

        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
