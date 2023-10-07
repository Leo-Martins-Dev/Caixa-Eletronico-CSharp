namespace CaixaEletronico
{
    public class OperacoesBancarias
    {
        public static void Deposito(TitularCartao usuarioAtual)
        {
            Console.WriteLine("Quanto deseja depositar?");
            double deposito = double.Parse(Console.ReadLine()!);
            usuarioAtual.Saldo += deposito;
            Console.WriteLine("Obrigado por realizar o depósito conosco. Seu novo saldo é: " + usuarioAtual.Saldo);
        }

        public static void Resgate(TitularCartao usuarioAtual)
        {
            Console.Write("Informe o valor da quantia que deseja resgatar: ");
            double resgate = double.Parse(Console.ReadLine()!);
            if (usuarioAtual.Saldo < resgate)
            {
                Console.WriteLine("Saldo insuficiente, saldo atual: " + usuarioAtual.Saldo);
            }
            else
            {
                usuarioAtual.Saldo -= resgate;
                Console.WriteLine("Resgate concluído, obrigado!");
            }
        }

        public static void Saldo(TitularCartao usuarioConta)
        {
            Console.WriteLine($"Obrigado por aguardar {usuarioConta.PrimeiroNome}, Seu saldo é: {usuarioConta.Saldo}");
        }
    }
}