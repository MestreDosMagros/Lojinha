using System;

namespace Lojinha.Modelos
{
    public class CartaoDebito : Pagamento
    {
        public CartaoDebito(
            string cVV,
            string numero,
            string titular,
            decimal saldo,
            DateTime validade)
        {
            CVV = cVV;
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            Validade = validade;
        }

        public string CVV { get; private set; }
        public string Numero { get; private set; }
        public string Titular { get; private set; }
        public decimal Saldo { get; private set; }
        public DateTime Validade { get; private set; }

        public override void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
