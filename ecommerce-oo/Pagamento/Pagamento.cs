using System;
using ecommerce_oo.Clientes;

namespace ecommerce_oo.Pagamento
{
    public class Pagamento
    {
        public NotaFiscal RealizarPagamento(CarrinhoDeCompras carrinho, Cliente cliente)
        {
            double valorTotal = carrinho.CalcularValorTotal();

            // Lógica para realizar o pagamento

            NotaFiscal notaFiscal = new NotaFiscal(cliente, carrinho, valorTotal);

            return notaFiscal;
        }
    }
}

