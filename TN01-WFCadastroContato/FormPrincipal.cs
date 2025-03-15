namespace TN01_WFCadastroContato
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            CarregarLista();
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

        private void CarregarLista()
        {

            Contato.ListaContatos.Add(
                new Contato
                {
                    Codigo = 1,
                    Nome = "Ana",
                    Sobrenome = "Silva",
                    Ddd = "11",
                    Telefone = "987654321",
                    TipoTelefone = ETipoTelefone.Pessoal,
                    Email = "ana.silva@email.com"
                }
            );

            Contato.ListaContatos.Add(new Contato { Codigo = 2, Nome = "João", Sobrenome = "Santos", Ddd = "21", Telefone = "998877665", TipoTelefone = ETipoTelefone.Pessoal, Email = "joao.santos@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 3, Nome = "Maria", Sobrenome = "Oliveira", Ddd = "31", Telefone = "999123456", TipoTelefone = ETipoTelefone.Pessoal, Email = "maria.oliveira@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 4, Nome = "Carlos", Sobrenome = "Pereira", Ddd = "41", Telefone = "986543210", TipoTelefone = ETipoTelefone.Pessoal, Email = "carlos.pereira@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 5, Nome = "Fernanda", Sobrenome = "Costa", Ddd = "51", Telefone = "988776655", TipoTelefone = ETipoTelefone.Pessoal, Email = "fernanda.costa@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 6, Nome = "Pedro", Sobrenome = "Almeida", Ddd = "61", Telefone = "991122233", TipoTelefone = ETipoTelefone.Comercial, Email = "pedro.almeida@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 7, Nome = "Julia", Sobrenome = "Mendes", Ddd = "71", Telefone = "992233344", TipoTelefone = ETipoTelefone.Comercial, Email = "julia.mendes@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 8, Nome = "Lucas", Sobrenome = "Rodrigues", Ddd = "81", Telefone = "995544332", TipoTelefone = ETipoTelefone.Comercial, Email = "lucas.rodrigues@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 9, Nome = "Patricia", Sobrenome = "Souza", Ddd = "91", Telefone = "997788665", TipoTelefone = ETipoTelefone.Comercial, Email = "patricia.souza@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 10, Nome = "Ricardo", Sobrenome = "Nascimento", Ddd = "11", Telefone = "981234567", TipoTelefone = ETipoTelefone.Pessoal, Email = "ricardo.nascimento@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 11, Nome = "Gabriela", Sobrenome = "Lima", Ddd = "21", Telefone = "996655443", TipoTelefone = ETipoTelefone.Comercial, Email = "gabriela.lima@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 12, Nome = "Marcos", Sobrenome = "Gomes", Ddd = "31", Telefone = "977788991", TipoTelefone = ETipoTelefone.Pessoal, Email = "marcos.gomes@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 13, Nome = "Camila", Sobrenome = "Silveira", Ddd = "41", Telefone = "999877665", TipoTelefone = ETipoTelefone.Comercial, Email = "camila.silveira@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 14, Nome = "Juliano", Sobrenome = "Ferreira", Ddd = "51", Telefone = "986543321", TipoTelefone = ETipoTelefone.Pessoal, Email = "juliano.ferreira@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 15, Nome = "Renata", Sobrenome = "Martins", Ddd = "61", Telefone = "993311443", TipoTelefone = ETipoTelefone.Comercial, Email = "renata.martins@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 16, Nome = "Eduardo", Sobrenome = "Barbosa", Ddd = "71", Telefone = "991144557", TipoTelefone = ETipoTelefone.Pessoal, Email = "eduardo.barbosa@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 17, Nome = "Luana", Sobrenome = "Moura", Ddd = "81", Telefone = "994455668", TipoTelefone = ETipoTelefone.Pessoal, Email = "luana.moura@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 18, Nome = "Thiago", Sobrenome = "Costa", Ddd = "91", Telefone = "999022233", TipoTelefone = ETipoTelefone.Comercial, Email = "thiago.costa@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 19, Nome = "Adriana", Sobrenome = "Dias", Ddd = "11", Telefone = "987123456", TipoTelefone = ETipoTelefone.Pessoal, Email = "adriana.dias@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 20, Nome = "Gustavo", Sobrenome = "Vasquez", Ddd = "21", Telefone = "988334455", TipoTelefone = ETipoTelefone.Comercial, Email = "gustavo.vasquez@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 21, Nome = "Isabela", Sobrenome = "Martins", Ddd = "31", Telefone = "988887766", TipoTelefone = ETipoTelefone.Pessoal, Email = "isabela.martins@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 22, Nome = "Fábio", Sobrenome = "Azevedo", Ddd = "41", Telefone = "994422778", TipoTelefone = ETipoTelefone.Comercial, Email = "fabio.azevedo@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 23, Nome = "Simone", Sobrenome = "Macedo", Ddd = "51", Telefone = "983344556", TipoTelefone = ETipoTelefone.Recado, Email = "simone.macedo@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 24, Nome = "Rodrigo", Sobrenome = "Martins", Ddd = "61", Telefone = "992211334", TipoTelefone = ETipoTelefone.Recado, Email = "rodrigo.martins@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 25, Nome = "Priscila", Sobrenome = "Nunes", Ddd = "71", Telefone = "991122334", TipoTelefone = ETipoTelefone.Recado, Email = "priscila.nunes@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 26, Nome = "Felipe", Sobrenome = "Gonçalves", Ddd = "81", Telefone = "996633442", TipoTelefone = ETipoTelefone.Recado, Email = "felipe.goncalves@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 27, Nome = "Renato", Sobrenome = "Soares", Ddd = "91", Telefone = "998877664", TipoTelefone = ETipoTelefone.Recado, Email = "renato.soares@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 28, Nome = "Tatiane", Sobrenome = "Ribeiro", Ddd = "11", Telefone = "987654321", TipoTelefone = ETipoTelefone.Recado, Email = "tatiane.ribeiro@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 29, Nome = "Alberto", Sobrenome = "Pinto", Ddd = "21", Telefone = "993311225", TipoTelefone = ETipoTelefone.Pessoal, Email = "alberto.pinto@email.com" });
            Contato.ListaContatos.Add(new Contato { Codigo = 30, Nome = "Claudia", Sobrenome = "Cavalcante", Ddd = "31", Telefone = "988991122", TipoTelefone = ETipoTelefone.Comercial, Email = "claudia.cavalcante@email.com" });

        }

    }
}
