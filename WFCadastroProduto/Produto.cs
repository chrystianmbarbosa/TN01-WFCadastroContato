using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastroProduto
{
    public enum ECategoria
    {
        Açougue = 10,
        Hortifruti = 25,
        Eletrônicos = 30,
        Limpeza = 35,
        Padaria = 40,
        Frios = 45,
        Laticínios = 50,
        Peixaria = 55,
        CestaBasica = 60,
        Outros = 100
    }

    public class Produto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public ECategoria Categoria { get; set; }
        public double Preco { get; set; }
        public DateTime DataVencimento { get; set; }
        public string? Observacao { get; set; }

        private static List<Produto> ListaProdutos =
            new List<Produto>();

        public void Cadastrar()
        {
            ListaProdutos.Add(this);
        }

        public static List<Produto> ObterLista()
        {
            return ListaProdutos;
        }

    }
}
