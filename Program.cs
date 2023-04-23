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
            Console.WriteLine("Por favor escolha uma da opcoes...");
            Console.WriteLine("1. Deposito");
            Console.WriteLine("2. Resgate");
            Console.WriteLine("3. Mostrar saldo");
            Console.WriteLine("4. Sair");
        }

        void Deposito(titularCartao UsuarioAtual)
        {
            Console.WriteLine("Qual sera a quantia a ser depositada?");
            double Deposito = Double.Parse(Console.ReadLine());
            UsuarioAtual.SetSaldo(UsuarioAtual.GetSaldo() + Deposito);
            Console.WriteLine("Obrigado por realizar o deposito conosco. Seu novo saldo e:" + UsuarioAtual.GetSaldo());
        }

        void Resgate(titularCartao UsuarioAtual)
        {
            Console.WriteLine("Qual sera a quantia a ser resgatada?");
            double Resgate = Double.Parse(Console.ReadLine());
            if (UsuarioAtual.GetSaldo() < Resgate)
            {
                Console.WriteLine("Saldo insulficiente, saldo atual: " + UsuarioAtual.GetSaldo());
            }
            else
            {
                UsuarioAtual.SetSaldo(UsuarioAtual.GetSaldo() - Resgate);
                Console.WriteLine("Resgate concluido, obrigado!");

            }
        }

        void Saldo(titularCartao UsuarioConta)
        {
            Console.WriteLine("Seu saldo: " + UsuarioConta.GetSaldo());
        }

        List<titularCartao> titularesCartao = new List<titularCartao>();
        titularesCartao.Add(new titularCartao("132890389012890", 1234, "Leo", "Martins", 1230.09));
        titularesCartao.Add(new titularCartao("132890389112890", 1234, "Marcella", "Reis", 120.09));

        Console.WriteLine("Bem-vindo ao MazeBank");
        Console.WriteLine("Por favor insira seu cartao: ");
        string Cartao = "";
        titularCartao UsuarioAtual;

        while (true)
        {
            try
            {
                Cartao = Console.ReadLine();

                UsuarioAtual = titularesCartao.FirstOrDefault(a => a.numCartao == Cartao);
                if (UsuarioAtual != null) { break; }
                else { Console.WriteLine("Cartao nao encontrado. Tente novamente"); }
            }
            catch { Console.WriteLine("Cartao nao encontrado. Tente novamente"); }

        }

        Console.WriteLine("Por favor digite o seu pin:");
        int userPin = 0;
        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (UsuarioAtual.GetPin() == userPin) { break; }
                else { Console.WriteLine("Pin incorreto. Por favor digite o pin correto"); }
            }
            catch { Console.WriteLine("Pin incorreto. Por favor digite o pin correto"); }

        }

        Console.WriteLine("Bem-vindo " + UsuarioAtual.GetNome() + " :)");
        int opcao = 0;
        do
        {
            Opcoes();
            try
            {
                opcao = int.Parse(Console.ReadLine());
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
        Console.WriteLine("Obrigado, tenha um bom dia :)");
    }



}
