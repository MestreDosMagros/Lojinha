using System;

namespace Lojinha.Modelos
{
    public class CartaoCredito : Pagamento
    {
        public CartaoCredito(
            string cVV,
            string numero,
            string titular,
            decimal limite,
            DateTime validade)
        {
            CVV = cVV;
            Numero = numero;
            Titular = titular;
            Limite = limite;
            Validade = validade;

            Validar();
        }

        public string CVV { get; private set; }
        public string Numero { get; private set; }
        public string Titular { get; private set; }
        public decimal Limite { get; private set; }
        public DateTime Validade { get; private set; }

        public override void Validar()
        {
            Valido = true;
            if (CVV.Length != 3)
            {
                Valido = false;
                Erros.Add("CVV inválido!");
            }
            if (Numero.Length != 9)
            {
                Valido = false;
                Erros.Add("Numero inválido!");
            }
            if (Limite <= 0)
            {
                Valido = false;
                Erros.Add("Limite inválido!");
            }
            if (DateTime.Now >= Validade)
            {
                Valido = false;
                Erros.Add("Validade inválido!");
            }
        }
    }
}
