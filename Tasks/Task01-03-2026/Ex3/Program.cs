class Program
{
    static void Main()
    {
        Console.Write("Digite o número de termos: ");
        int n = int.Parse(Console.ReadLine());

        double resultado = Serie(n);

        Console.WriteLine($"Resultado da série com {n} termos: {resultado}");
    }

    static double Serie(int n)
    {
        if (n == 1)
            return 1.0;

        return (1.0 / n) + Serie(n - 1);
    }
}