using System;

public class titularCartao
{
    string numCartao;
    int pin;
    string primeiroNome;
    string sobrenome;
    double saldo;

    public titularCartao(string numCartao, int pin, string primeiroNome, string sobrenome, double saldo)
    {
        this.numCartao = numCartao;
        this.pin = pin;
        this.primeiroNome = primeiroNome;
        this.sobrenome = sobrenome;
        this.saldo = saldo;
    }

    public string GetNum()
    {
        return numCartao;
    }

    public int GetPin()
    {
        return pin;
    }

    public string GetNome()
    {
        return primeiroNome;
    }

    public string GetSobrenome()
    {
        return sobrenome;
    }

    public double GetSaldo()
    {
        return saldo;
    }

    public void SetNum(string newNumCartao)
    {
        numCartao = newNumCartao;
    }

    public void SetPin(int newPin)
    {
        pin = newPin;
    }

    public void SetPrimeiroNome(string newPrimeiroNome)
    {
        primeiroNome = newPrimeiroNome;
    }

    public void SetSobrenome(string newSobrenome)
    {
        sobrenome = newSobrenome;
    }

    public void SetSaldo(double newSaldo)
    {
        saldo = newSaldo;
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

        void Deposito(titularCartao UsuarioAtual)
        {
            Console.WriteLine("Quanto deseja depositar?");
            double Deposito = Double.Parse(Console.ReadLine()!);
            UsuarioAtual.SetSaldo(UsuarioAtual.GetSaldo() + Deposito);
            Console.WriteLine("Obrigado por realizar o depósito conosco. Seu novo saldo é: " + UsuarioAtual.GetSaldo());
        }

        void Resgate(titularCartao UsuarioAtual)
        {
            Console.Write("Informe o valor da quantia que deseja resgatar: ");
            double Resgate = Double.Parse(Console.ReadLine()!);
            if (UsuarioAtual.GetSaldo() < Resgate)
            {
                Console.WriteLine("Saldo insulficiente, saldo atual: " + UsuarioAtual.GetSaldo());
            }
            else
            {
                UsuarioAtual.SetSaldo(UsuarioAtual.GetSaldo() - Resgate);
                Console.WriteLine("Resgate concluído, obrigado!");

            }
        }

        void Saldo(titularCartao UsuarioConta)
        {
            Console.WriteLine($"Obrigado por aguardar {UsuarioConta.GetNome()}, Seu saldo é: {UsuarioConta.GetSaldo()}");
        }

        List<titularCartao> titularesCartao = new List<titularCartao>();
        titularesCartao.Add(new titularCartao("5572096890324397", 1234, "Gabriela", "Silva", 4598.31));
        titularesCartao.Add(new titularCartao("4084007130021262", 1234, "Rafael", "Souza", 210.43));
        titularesCartao.Add(new titularCartao("5552302721676165", 1234, "Julia", "Pereira", 1023.56));
        titularesCartao.Add(new titularCartao("4024007190705357", 1234, "Lucas", "Oliveira", 7500.00));
        titularesCartao.Add(new titularCartao("5299406269141087", 1234, "Mariana", "Santos", 15.75));
        titularesCartao.Add(new titularCartao("5168756196701991", 1234, "Isabela", "Ferreira", 503.00));

        Console.WriteLine("Bem-vindo/a ao MazeBank");
        Console.Write("Por favor insira seu cartão : ");
        string Cartao = "";
        titularCartao UsuarioAtual;

        while (true)
        {
            try
            {
                Cartao = Console.ReadLine()!;

                UsuarioAtual = titularesCartao.FirstOrDefault(a => a.numCartao == Cartao)!;
                if (UsuarioAtual != null) { break; }
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
                if (UsuarioAtual.GetPin() == userPin) { break; }
                else { Console.WriteLine("Pin incorreto. Por favor digite o pin correto"); }
            }
            catch { Console.WriteLine("Pin incorreto. Por favor digite o pin correto"); }

        }

        Console.WriteLine("Bem-vindo/a " + UsuarioAtual.GetNome() + " :)");
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
                Deposito(UsuarioAtual);
            }
            else if (opcao == 2)
            {
                Resgate(UsuarioAtual);
            }
            else if (opcao == 3)
            {
                Saldo(UsuarioAtual);
            }
            else if (opcao == 4)
            {
                break;
            }
            else
            {
                opcao = 0;
            }

        }
        while (opcao != 4);
        Console.WriteLine("Obrigado, tenha uma boa viagem :)");
    }



}
