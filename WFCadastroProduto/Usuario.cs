using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastroProduto
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public DateTime DtCadastro { get; set; }

        private static List<Usuario>
            ListaUsuarios = new List<Usuario>();

        public void Cadastrar()
        {
            ListaUsuarios.Add(this);
        }

        public static List<Usuario> TodosOsUsuarios()
        {
            return ListaUsuarios;
        }

    }
}
