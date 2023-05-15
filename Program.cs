namespace ConsoleApp1;

public class TitularCartao
{
    string _numCartao;
    int _pin;
    string _primeiroNome;
    string _sobrenome;
    double _saldo;

    public TitularCartao(string numCartao, int pin, string primeiroNome, string sobrenome, double saldo)
    {
        this._numCartao = numCartao;
        this._pin = pin;
        this._primeiroNome = primeiroNome;
        this._sobrenome = sobrenome;
        this._saldo = saldo;
    }

    public string GetNum()
    {
        return _numCartao;
    }

    public int GetPin()
    {
        return _pin;
    }

    public string GetNome()
    {
        return _primeiroNome;
    }

    public string GetSobrenome()
    {
        return _sobrenome;
    }

    public double GetSaldo()
    {
        return _saldo;
    }

    public void SetNum(string newNumCartao)
    {
        _numCartao = newNumCartao;
    }

    public void SetPin(int newPin)
    {
        _pin = newPin;
    }

    public void SetPrimeiroNome(string newPrimeiroNome)
    {
        _primeiroNome = newPrimeiroNome;
    }

    public void SetSobrenome(string newSobrenome)
    {
        _sobrenome = newSobrenome;
    }

    public void SetSaldo(double newSaldo)
    {
        _saldo = newSaldo;
    }

    public static void Main(string[] args)
    {
        void Opcoes()
        {
            Console.WriteLine("Por favor escolha uma da opções...");
            Console.WriteLine("1. Depósito");
            Console.WriteLine("2. Resgate");
            Console.WriteLine("3. Mostrar saldo");
            Console.WriteLine("4. Sair");
        }

        void ExibirProcessando()
        {
            Console.Write("Processando");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(700);
            }
        }
        
        void ExibirIniciando()
        {
            Console.Write("Buscando");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(700);
            }
        }
        
        void ExibirFinalizando()
        {
            Console.Write("Finalizando");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(700);
            }
        }
        
        void ExecutarOpcao(Action acao)
        {
            ExibirProcessando();
            Console.WriteLine();
            acao.Invoke();
            ExibirProcessando();
        }

        void Deposito(TitularCartao usuarioAtual)
        {
            Console.WriteLine("Quanto deseja depositar?");
            double deposito = Double.Parse(Console.ReadLine()!);
            usuarioAtual.SetSaldo(usuarioAtual.GetSaldo() + deposito);
            Console.WriteLine("Obrigado por realizar o depósito conosco. Seu novo saldo é: " + usuarioAtual.GetSaldo());
        }

        void Resgate(TitularCartao usuarioAtual)
        {
            Console.Write("Informe o valor da quantia que deseja resgatar: ");
            double resgate = Double.Parse(Console.ReadLine()!);
            if (usuarioAtual.GetSaldo() < resgate)
            {
                Console.WriteLine("Saldo insulficiente, saldo atual: " + usuarioAtual.GetSaldo());
            }
            else
            {
                usuarioAtual.SetSaldo(usuarioAtual.GetSaldo() - resgate);
                Console.WriteLine("Resgate concluído, obrigado!");

            }
        }

        void Saldo(TitularCartao usuarioConta)
        {
            Console.WriteLine($"Obrigado por aguardar {usuarioConta.GetNome()}, Seu saldo é: {usuarioConta.GetSaldo()}");
        }

        List<TitularCartao> titularesCartao = new List<TitularCartao>();
        titularesCartao.Add(new TitularCartao("5572096890324397", 1234, "Gabriela", "Silva", 4598.31));
        titularesCartao.Add(new TitularCartao("4084007130021262", 1234, "Rafael", "Souza", 210.43));
        titularesCartao.Add(new TitularCartao("5552302721676165", 1234, "Julia", "Pereira", 1023.56));
        titularesCartao.Add(new TitularCartao("4024007190705357", 1234, "Lucas", "Oliveira", 7500.00));
        titularesCartao.Add(new TitularCartao("5299406269141087", 1234, "Mariana", "Santos", 15.75));
        titularesCartao.Add(new TitularCartao("5168756196701991", 1234, "Isabela", "Ferreira", 503.00));

        Console.WriteLine("Bem-vindo ao MazeBank");
        Console.Write("Por favor insira seu cartão : ");
        string cartao = "";
        TitularCartao usuarioAtual;

        while (true)
        {
            try
            {
                cartao = Console.ReadLine()!;

                usuarioAtual = titularesCartao.FirstOrDefault(a => a._numCartao == cartao)!;
                if (usuarioAtual != null) { break; }
                else { Console.WriteLine("Cartão não encontrado. Tente novamente"); }
            }
            catch { Console.WriteLine("Cartão não encontrado. Tente novamente"); }

        }

        Console.Write("Digite o pin:");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine()!);
                if (usuarioAtual.GetPin() == userPin) { break; }
                else { Console.WriteLine("Pin incorreto. Por favor digite o pin correto"); }
            }
            catch { Console.WriteLine("Pin incorreto. Por favor digite o pin correto"); }

        }
        
        ExibirIniciando();
        Console.WriteLine();
        Console.WriteLine("Bem-vindo " + usuarioAtual.GetNome() + " :)");
        int opcao = 0;
        do
        {
            Opcoes();
            try
            {
                opcao = int.Parse(Console.ReadLine()!);
            }
            catch { }
            if (opcao == 1)
            {
                ExecutarOpcao(() => Deposito(usuarioAtual));
            }
            else if (opcao == 2)
            {
                ExecutarOpcao(() => Resgate(usuarioAtual));
            }
            else if (opcao == 3)
            {
                ExecutarOpcao(() => Saldo(usuarioAtual));
            }
            else if (opcao == 4)
            {
                ExibirProcessando();
                break;
            }
            else
            {
                opcao = 0;
            }
        }
        while (opcao != 4);
        ExibirFinalizando();
        Console.WriteLine("Obrigado, tenha uma boa viagem :)");
        Console.Clear();
    }



}