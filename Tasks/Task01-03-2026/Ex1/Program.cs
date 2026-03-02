class Program
{
    static void Main()
    {
        Console.WriteLine($"Digite o primeiro valor: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Digite o valor a ser multiplicado: ");
        int m = int.Parse(Console.ReadLine());

        var A = SomaRecursiva(n, m);

        Console.WriteLine($"O resultado da multiplicação de {n} x {m} é: {A}");
    
    }

    static int SomaRecursiva(int n, int m)
    {
        if(m == 0)
            return 0;
        else
            return n + SomaRecursiva(n, m - 1);
    }
}