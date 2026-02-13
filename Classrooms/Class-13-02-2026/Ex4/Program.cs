class Program
{
    static void Main()
    {
        Console.WriteLine($"Type the integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Type the expoent: ");
        int exponent = int.Parse(Console.ReadLine());

        var A = Calc(number, exponent);
        Console.WriteLine($"The result of {number} to the power of {exponent} is: {A}");

    }

    static int Calc(int number, int exponent)
    {
        int cont = 1;
        int result = number;

        while(cont != exponent)
        {
            result = result * number;
            cont++;
        }

        return result;
    }
}