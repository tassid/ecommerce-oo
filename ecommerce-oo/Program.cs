using System;
using ecommerce_oo.CarrinhoDeCompras;
using ecommerce_oo.Clientes;
using ecommerce_oo.Models;
using ecommerce_oo.Pagamento;

namespace LojaVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Adicionar produto");
                Console.WriteLine("2 - Ver carrinho de compras");
                Console.WriteLine("3 - Finalizar compra");
                Console.WriteLine("0 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    break;
                }
                else if (opcao == 1)
                {
                    Console.WriteLine("Digite o nome do produto:");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Digite o preço do produto:");
                    double preco = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a categoria do produto:");
                    Console.WriteLine("1 - Camiseta");
                    Console.WriteLine("2 - Calça");
                    Console.WriteLine("3 - Sapato");
                    Console.WriteLine("4 - Bolsa");
                    Console.WriteLine("5 - Acessório");
                    CategoriaProduto categoria = (CategoriaProduto)int.Parse(Console.ReadLine());

                    Produto produto = null;

                    switch (categoria)
                    {
                        case CategoriaProduto.Camiseta:
                            Console.WriteLine("Digite o tamanho da camiseta:");
                            string tamanho = Console.ReadLine();
                            produto = new Camiseta(nome, preco, tamanho);
                            break;
                        case CategoriaProduto.Calca:
                            Console.WriteLine("Digite o tamanho da calça:");
                            int tamanhoCalca = int.Parse(Console.ReadLine());
                            produto = new Calca(nome, preco, tamanhoCalca);
                            break;
                        case CategoriaProduto.Sapato:
                            Console.WriteLine("Digite o tamanho do sapato:");
                            int tamanhoSapato = int.Parse(Console.ReadLine());
                            produto = new Sapato(nome, preco, tamanhoSapato);
                            break;
                        case CategoriaProduto.Bolsa:
                            Console.WriteLine("Digite o material da bolsa:");
                            string material = Console.ReadLine();
                            produto = new Bolsa(nome, preco, material);
                            break;
                        case CategoriaProduto.Acessorio:
                            Console.WriteLine("Digite a cor do acessório:");
                            string cor = Console.ReadLine();
                            produto = new Acessorio(nome, preco, cor);
                            break;
                    }

                    carrinho.AdicionarProduto(produto);
                }
                else if (opcao == 2)
                {
                    carrinho.VerCarrinhoDeCompras();
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Digite o nome do cliente:");
                    string nomeCliente = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do cliente:");
                    string cpfCliente = Console.ReadLine();

                    Console.WriteLine("Digite o endereço do cliente:");
                    string enderecoCliente = Console.ReadLine();

                    Console.WriteLine("Digite o método de pagamento:");
                    Console.WriteLine("1 - Cartão de crédito");
                    Console.WriteLine("2 - Boleto bancário");
                    MetodoPagamento metodoPagamento = (MetodoPagamento)int.Parse(Console.ReadLine());

                    Pagamento pagamento = new Pagamento(carrinho, new Cliente(nomeCliente, cpfCliente, enderecoCliente), metodoPagamento);
                    pagamento.GerarNotaFiscal();

                    carrinho = new CarrinhoDeCompras();
                }
            }
        }
    }
}
