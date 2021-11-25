using System;
using System.Collections.Generic;
using System.Linq;

#nullable enable
namespace Lojinha.Modelos
{
    public class Pedido
    {
        private List<Produto> _itensPedido;

        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            _itensPedido ??= new List<Produto>();
        }

        public Pedido(
            Cliente cliente, 
            List<Produto> itensPedido)
        {
            Cliente = cliente;
            _itensPedido = itensPedido;
        }

        public Cliente Cliente { get; private set; }
        public Pagamento? Pagamento { get; private set; }
        public IReadOnlyList<Produto> ItensPedido => _itensPedido;

        public void AdicionarProduto(Produto produto)
        {
            if (produto is null)
                throw new Exception("Produto deve ser informado");
            if (produto.Quantidade <= 0)
                throw new Exception("Quantidade do produto não pode ser menor ou igual a zero");
            if (produto.Preco <= 0)
                throw new Exception("Preço do produto não pode ser menor ou igual a zero");
            
            _itensPedido.Add(produto);
        }

        public void RemoverProduto(Produto produto) => _itensPedido.Remove(produto);

        public void AlterarQuantidade(Produto produto, double quantidade)
        {
            var prod = _itensPedido.Where(p => p.Nome == produto.Nome).FirstOrDefault();
            prod?.AlterarQuantidade(quantidade);
        }

        public void FinalizarCompra(Pagamento pagamento)
        {
            if(pagamento.Valido)
            {
                Pagamento = pagamento;
                Console.WriteLine("Compra finalizada!!!");
            }
            else
            {
                throw new Exception("Forma de pagamento inválida!!");
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
