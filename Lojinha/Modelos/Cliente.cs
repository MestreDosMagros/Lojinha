#nullable enable
namespace Lojinha.Modelos
{
    public class Cliente
    {
        public Cliente(
            string nome, 
            string documento)
        {
            Nome = nome;
            Documento = documento;
            Pedido ??= new Pedido(this);
        }

        public string Nome { get; private set; }
        public Pedido? Pedido { get; private set; }
        public string Documento { get; private set; }
    }
}
