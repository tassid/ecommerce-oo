using System;
using ecommerce_oo.Clientes;

namespace ecommerce_oo.NotaFiscal
{
    public class NotaFiscal
    {
        public Cliente Cliente { get; set; }
        public CarrinhoDeCompras Carrinho { get; set; }
        public double ValorTotal { get; set; }

        public NotaFiscal(Cliente cliente, CarrinhoDeCompras carrinho, double valorTotal)
        {
            Cliente = cliente;
            Carrinho = carrinho;
            ValorTotal = valorTotal;
        }

        public override string ToString()
        {
            // Lógica para gerar a representação da nota fiscal como string
        }
    }
}

