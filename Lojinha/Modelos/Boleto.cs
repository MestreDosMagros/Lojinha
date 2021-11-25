using System;

namespace Lojinha.Modelos
{
    public class Boleto : Pagamento
    {
        public Boleto(
            string banco,
            string titular,
            string agencia,
            DateTime dataVencimento)
        {
            Banco = banco;
            Titular = titular;
            Agencia = agencia;
            DataVencimento = dataVencimento;
            CodigoBarras = Guid.NewGuid().ToString();
        }

        public string Banco { get; private set; }
        public string Titular { get; private set; }
        public string Agencia { get; private set; }
        public string CodigoBarras { get; private set; }
        public DateTime DataVencimento { get; private set; }

        public override void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
