class Program
{
    static void Main()
    {
        Console.Write("Digite um número natural: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write($"{n} convertido para binário: ");
        ConverteBinario(n);
    }

    static void ConverteBinario(int n)
    {
        if (n == 0)
            return;

        ConverteBinario(n / 2);

        Console.Write(n % 2);
    }
}