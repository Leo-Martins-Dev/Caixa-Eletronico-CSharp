
namespace CaixaEletronico
{
    // TitularCartao.cs

    public class TitularCartao
    {
        public string NumeroCartao { get; set; }
        public int Pin { get; set; }
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public double Saldo { get; set; }

        public TitularCartao(string numeroCartao, int pin, string primeiroNome, string sobrenome, double saldo)
        {
            NumeroCartao = numeroCartao;
            Pin = pin;
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Saldo = saldo;
        }

        internal static TitularCartao FirstOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }

}