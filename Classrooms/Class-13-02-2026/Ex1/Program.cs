class Program
{
    static void Main()
    {
        Console.WriteLine($"How many days does you want to register?");
        int days = int.Parse(Console.ReadLine());

        double[] temperature = new double[days];
        double cont = 0;

        for (int i = 0; i < temperature.Length; i++)
        {
            Console.WriteLine($"Write the temperature of day {i + 1}: ");
            temperature[i] = double.Parse(Console.ReadLine());
            cont += temperature[i];
        }

        var A = Media(cont, days);
        var B = Highest(temperature);
        var C = Smallest(temperature);

        Console.WriteLine($"Media: {A:F2}");
        Console.WriteLine($"Highest temperature: {B:F2}");
        Console.WriteLine($"Smallest temperature: {C:F2}");
    }

    static double Media(double cont, int days)
    {
        return cont / days;
    }

    static double Highest(double[] temperature)
    {
        double highest = temperature[0];

        for (int i = 0; i < temperature.Length; i++)
        {
            if (temperature[i] > highest)
                highest = temperature[i];
        }

        return highest;
    }
    static double Smallest(double[] temperature)
    {
        double smallest = temperature[0];

        for (int i = 0; i < temperature.Length; i++)
        {
            if (temperature[i] < smallest)
                smallest = temperature[i];
        }

        return smallest;
    }
}