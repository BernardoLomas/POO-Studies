class ContaBancaria
{
    private string Titular;
    private double Saldo;
    public string GetTitular()
    {
        return Titular;
    }

    public double GetSaldo()
    {
        return Saldo;
    }

    public void SetTitular(string titular)
    {
        Titular = titular;
    }

    public void SetSaldo(double saldo)
    {
        Saldo = saldo;
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine($"Saldo insuficiente para realizar o saque!");
        }
        else 
            Saldo -= valor;
    }
}

class Program
{
    public static void Main()
    {
        ContaBancaria conta = new ();

        Console.WriteLine($"Digite o nome do titular: ");
        string nome = Console.ReadLine();
        conta.SetTitular(nome);

        Console.WriteLine($"Digite o saldo inicial: ");
        double saldo = double.Parse(Console.ReadLine());
        conta.SetSaldo(saldo);

        Console.WriteLine("Digite o valor para depósito: ");
        double deposito = double.Parse(Console.ReadLine());
        conta.Depositar(deposito);

        Console.WriteLine($"Digite o valor para saque: ");
        double saque = double.Parse(Console.ReadLine());
        conta.Sacar(saque);

        Console.WriteLine($"Titular: " + conta.GetTitular());
        Console.WriteLine($"Saldo: " + conta.GetSaldo());

    }
}