using CaixaEletronico;

public class Program
{
    public static void Main(string[] args)
    {

        Banco banco = new Banco();
        CartaoBancario cartaoBancario = new CartaoBancario();
        TitularCartao usuarioAtual = cartaoBancario.Autenticar(banco.titularesCartao);
        Processando processando = new Processando();

        Console.WriteLine("Bem-vindo ao MazeBank");

        int opcao;
        do
        {
            Menu.ExibirOpcoes();

            try
            {
                opcao = int.Parse(Console.ReadLine()!);

            }
            catch
            {
                opcao = 0;
            }

            switch (opcao)
            {
                case 1:
                    processando.ExibirIniciando();
                    processando.ExecutarOpcao(() => OperacoesBancarias.Deposito(usuarioAtual));
                    break;
                case 2:
                    processando.ExibirIniciando();
                    processando.ExecutarOpcao(() => OperacoesBancarias.Resgate(usuarioAtual));
                    break;
                case 3:
                    processando.ExibirIniciando();
                    processando.ExecutarOpcao(() => OperacoesBancarias.Saldo(usuarioAtual));
                    break;
                case 4:
                    processando.ExibirFinalizando();
                    Console.WriteLine("Obrigado, tenha uma boa viagem :)");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;
            }
        } while (opcao != 4);
    }
}


