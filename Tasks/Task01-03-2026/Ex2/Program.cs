class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de q: ");
        int q = int.Parse(Console.ReadLine());

        ExibirMultiplos(n, q);
    }

    static void ExibirMultiplos(int n, int q)
    {
        if (q == 0)
            return;

        ExibirMultiplos(n, q - 1);

        Console.WriteLine($"{q} múltiplo: {n} x {q} = {n * q}");
    }
}