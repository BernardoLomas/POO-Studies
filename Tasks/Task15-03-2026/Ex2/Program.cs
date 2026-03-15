class Funcionario
{
    private string NomeFuncionario;
    private double SalarioAtual;

    public string GetNome()
    {
        return NomeFuncionario;
    }

    public double GetSalario()
    {
        return SalarioAtual;
    }

    public void SetNome(string nome)
    {
        NomeFuncionario = nome;
    }

    public void SetSalario(double salario)
    {
        SalarioAtual = salario;
    }

    public void AumentoSalarial(double percentual)
    {
        SalarioAtual += SalarioAtual * (percentual / 100);
    }
}

class Program
{
    public static void Main()
    {
        Funcionario novo = new ();
        Console.WriteLine($"Digite o nome do funcionário: ");
        string nome = Console.ReadLine();
        novo.SetNome(nome);

        Console.WriteLine($"Digite o salário inicial: ");
        double salario = double.Parse(Console.ReadLine());
        novo.SetSalario(salario);

        Console.WriteLine("Digite o percentual de aumento: ");
        double percentual = double.Parse(Console.ReadLine());
        novo.AumentoSalarial(percentual);

        Console.WriteLine($"Funcionário: " + novo.GetNome());
        Console.WriteLine($"Salário inicial: " + salario);
        Console.WriteLine($"Percentual aplicado: " + percentual);
        Console.WriteLine($"Novo salário: " + novo.GetSalario());

    }
}