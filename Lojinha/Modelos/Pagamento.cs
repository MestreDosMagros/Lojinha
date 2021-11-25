using System.Collections.Generic;

namespace Lojinha.Modelos
{
    public abstract class Pagamento
    {
        public bool Valido { get; protected set; }
        public List<string> Erros = new List<string>();
        public EFormaPagamento FormaPagamento { get; protected set; }

        public abstract void Validar();
    }
}
