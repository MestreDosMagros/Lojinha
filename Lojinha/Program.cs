using Lojinha.Modelos;
using System;
using System.Collections.Generic;

namespace Lojinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrando na loja...");

            var produtos = new List<Produto>()
            {
                new Produto("Alicate", 10m, 1),
                new Produto("Martelo", 8.5m, 1),
                new Produto("Pá", 45m, 1),
                new Produto("Corda", 12m, 1),
            };

            var cliente = new Cliente("Daniel", "123456789");

            Console.WriteLine("Adicionando produtos...");

            cliente.Pedido.AdicionarProduto(produtos[1]);
            cliente.Pedido.AdicionarProduto(produtos[0]);
            cliente.Pedido.AdicionarProduto(produtos[2]);
            cliente.Pedido.RemoverProduto(produtos[1]);
            cliente.Pedido.AlterarQuantidade(produtos[2], 2);

            Console.WriteLine("Finalizando compra...");

            var formaPagamento = new CartaoCredito("000", "123456789", "DANIEL", 180000, DateTime.Now.AddYears(1));

            if (!formaPagamento.Valido)
                formaPagamento.Erros.ForEach((x) => Console.WriteLine(x));

            cliente.Pedido.FinalizarCompra(formaPagamento);
        }
    }
}
