namespace CaixaEletronico
{
    public class Menu
    {
        public static void ExibirOpcoes()
        {
            Console.WriteLine("Por favor escolha uma das opções...");
            Console.WriteLine("1. Depósito");
            Console.WriteLine("2. Resgate");
            Console.WriteLine("3. Mostrar saldo");
            Console.WriteLine("4. Sair");
        }

        public static void ExibirMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}