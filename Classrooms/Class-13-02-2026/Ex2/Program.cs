class Program
{
    static void Main()
    {
        int[,] headquarter = new int[3, 3];

        for (int i = 0; i < headquarter.GetLength(0); i++)
        {
            for (int j = 0; j < headquarter.GetLength(1); j++)
            {
                Console.WriteLine($"Write the element of position {i}/{j}: ");
                headquarter[i, j] = int.Parse(Console.ReadLine());
            }
        }

        var A = CountPositives(headquarter);
        var B = CountNegatives(headquarter);
        var C = SumElements(headquarter);

        Console.WriteLine($"Number of positives elements: {A}");
        Console.WriteLine($"Number of negatives elements: {B}");
        Console.WriteLine($"Sum of all elements: {C}");
    }

    static int CountPositives(int[,] headquarter)
    {
        int countPositive = 0;

        for (int i = 0; i < headquarter.GetLength(0); i++)
        {
            for (int j = 0; j < headquarter.GetLength(1); j++)
            {
                if (headquarter[i, j] >= 0)
                    countPositive++;
            }
        }

        return countPositive;
    }

    static int CountNegatives(int[,] headquarter)
    {
        int countNegative = 0;

        for (int i = 0; i < headquarter.GetLength(0); i++)
        {
            for (int j = 0; j < headquarter.GetLength(1); j++)
            {
                if (headquarter[i, j] < 0)
                    countNegative++;
            }
        }

        return countNegative;
    }

    static int SumElements(int[,] headquarter)
    {
        int sum = 0;

        for (int i = 0; i < headquarter.GetLength(0); i++)
        {
            for (int j = 0; j < headquarter.GetLength(1); j++)
            {
                sum += headquarter[i,j];
            }
        }

        return sum;
    }
}