namespace CaixaEletronico
{
    public class Processando
    {
        public void ExibirProcessando()
        {
            Console.Write("Processando");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(700);
            }
        }

        public void ExibirIniciando()
        {
            Console.Write("Buscando");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(700);
            }
        }

        public void ExibirFinalizando()
        {
            Console.Write("Finalizando");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(700);
            }
        }

        public void ExecutarOpcao(Action acao)
        {
            ExibirProcessando();
            Console.WriteLine();
            acao.Invoke();
            ExibirProcessando();
            Console.WriteLine();
        }
    }
}