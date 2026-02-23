class Program
{
    static void Main()
    {
        Console.WriteLine($"Type the number which you want to know the multiples: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"How many multiples of {n} you want? ");
        int q = int.Parse(Console.ReadLine());
        
        var A = Multiples(n, q);
        Console.WriteLine($"Result: {A}");

    }

    static int Multiples(int n, int q)
    {
        if (n <= 1)
            return Multiples(n);
        else 
            return Multiples(n) * Multiples(q - 1);
    }
}