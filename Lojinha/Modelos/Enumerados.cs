namespace Lojinha.Modelos
{
    public enum EFormaPagamento
    {
        CartaoCredito = 0,
        CartaoDebito = 1,
        Boleto = 2,
        Pix = 3
    }

    public enum ETipoChavePix
    {
        CPF = 0,
        CNPJ = 1,
        Telefone = 2,
        Email = 3,
        Aleatoria = 4
    }
}
