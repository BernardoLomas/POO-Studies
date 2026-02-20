class Program
{
    static void Main()
    {
        Console.WriteLine($"What factorial number you want?");
        int factorial = int.Parse(Console.ReadLine());

        var A = Factorial(factorial);
        Console.WriteLine($"Result: {A}");
    }

    static int Factorial(int factorial)
    {
        if (factorial <= 1)
            return 1;
        else
            return factorial * Factorial(factorial - 1);
    }
}