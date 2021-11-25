using System;

namespace Lojinha.Modelos
{
    public class Produto
    {
        public Produto(
            string nome, 
            decimal preco, 
            double quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public double Quantidade { get; private set; }

        public void AlterarQuantidade(double quantidade)
        {
            if (quantidade <= 0)
                throw new Exception("Quantidade deve ser maior que zero!");

            Quantidade = quantidade;
        }
    }
}
