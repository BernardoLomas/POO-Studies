class Program
{
    public static void Main()
    {
        int n;

        Console.WriteLine($"Write a value for N: ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Print numbers from 1 to {n}: ");
        for (int i = 1; i <= n; i++)
            Console.Write($"{i} - ");

        var A = CountPar(n);
        var B = Sum(n);

        Console.WriteLine($"Number of pairs among 1 and {n}: {A}");
        Console.WriteLine($"Sum of numbers among 1 and {n}: {B}");
    }

    static int CountPar(int n)
    {
        int countPar = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i / 2)
                countPar++;
        }

        return countPar;
    }

    static int Sum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        return sum;
    }

}