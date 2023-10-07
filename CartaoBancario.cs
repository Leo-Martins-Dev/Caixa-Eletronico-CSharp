namespace CaixaEletronico
{
    public class CartaoBancario
    {
        public TitularCartao Autenticar(List<TitularCartao> titularesCartao)
        {
            TitularCartao? usuarioAtual = null;


            Console.Write("Por favor insira seu cartão: ");
            string? cartao = Console.ReadLine();

            while (true)
            {
                if (cartao == null)
                {
                    Console.Write("Por favor insira seu cartão: ");
                    cartao = Console.ReadLine();
                }

                usuarioAtual = titularesCartao.FirstOrDefault(a => a?.NumeroCartao == cartao);

                if (usuarioAtual != null)
                {
                    break;
                }
                else
                {
                    Menu.ExibirMensagem("Cartão não encontrado. Tente novamente.");
                    Console.Write("Por favor insira seu cartão: ");
                    cartao = Console.ReadLine();
                }
            }

            Console.Write("Digite o PIN: ");
            int userPin = 0;

            while (true)
            {
                string? pinInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(pinInput) && int.TryParse(pinInput, out userPin))
                {
                    break;
                }
                else
                {
                    Menu.ExibirMensagem("PIN incorreto. Por favor digite o PIN correto.");
                    Console.Write("Digite o PIN: ");
                }
            }

            if (usuarioAtual != null)
            {
                Menu.ExibirMensagem($"Bem-vindo {usuarioAtual.PrimeiroNome} :)");
            }

            return usuarioAtual ?? throw new Exception("Usuário atual é nulo.");
        }

        internal TitularCartao Autenticar(object titularesCartao)
        {
            throw new NotImplementedException();
        }
    }

}