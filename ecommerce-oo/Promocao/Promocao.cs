using System;
namespace ecommerce_oo.Promocao
{
    public class Promocao
    {
        private List<Produto> _produtos;
        private List<CategoriaProduto> _categorias;
        public double Desconto { get; set; }

        public Promocao(List<Produto> produtos, List<CategoriaProduto> categorias, double desconto)
        {
            _produtos = produtos;
            _categorias = categorias;
            Desconto = desconto;
        }

        public double CalcularDesconto(List<Produto> produtos)
        {
            double desconto = 0;

            foreach (Produto produto in produtos)
            {
                if (_produtos.Contains(produto) || _categorias.Contains(produto.Categoria))
                {
                    desconto += produto.Preco * Desconto / 100;
                }
            }

            return desconto;
        }
    }
}

