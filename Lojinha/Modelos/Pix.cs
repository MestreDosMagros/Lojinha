using System;

namespace Lojinha.Modelos
{
    public class Pix : Pagamento
    {
        public Pix(
            string agencia,
            string nomeTitular,
            string numeroConta,
            string instituicao,
            ETipoChavePix tipoChave)
        {
            Agencia = agencia;
            NomeTitular = nomeTitular;
            NumeroConta = numeroConta;
            Instituicao = instituicao;
            TipoChave = tipoChave;
        }

        public string Agencia { get; private set; }
        public string NomeTitular { get; private set; }
        public string NumeroConta { get; private set; }
        public string Instituicao { get; private set; }
        public ETipoChavePix TipoChave { get; private set; }

        public override void Validar()
        {
            throw new NotImplementedException();
        }
    }
}
