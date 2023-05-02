using System;
namespace ecommerce_oo.CarrinhoDeCompras
{
    public class CarrinhoDeCompras
    {
        private List<Produto> _produtos;
        private List<Promocao> _promocoes;

        public CarrinhoDeCompras()
        {
            _produtos = new List<Produto>();
            _promocoes = new List<Promocao>();
        }

        public void AdicionarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public void AdicionarPromocao(Promocao promocao)
        {
            if (promocao is null)
            {
                throw new ArgumentNullException(nameof(promocao));
            }

            _promocoes.Add(promocao);
        }

        public double CalcularValorTotal()
        {
            double valorTotal = 0;

            foreach (Produto produto in _produtos)
            {
                valorTotal += produto.Preco;
            }

            foreach (Promocao promocao in _promocoes)
            {
                valorTotal -= promocao.CalcularDesconto(_produtos);
            }

            return valorTotal;
        }
    }
}

