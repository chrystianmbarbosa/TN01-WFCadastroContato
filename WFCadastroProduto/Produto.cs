using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCadastroProduto
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
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
