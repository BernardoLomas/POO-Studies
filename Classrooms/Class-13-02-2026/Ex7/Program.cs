class Program
{
    static void Main()
    {
        do
        {
            Console.WriteLine($"<==== MENU ====>");
            Console.WriteLine($"01 - DOUBLE");
            Console.WriteLine($"02 - TRIPLE");
            Console.WriteLine($"03 - PAIR VERIFY");
            Console.WriteLine($"00 - EXIT");
            int options = Console.ReadLine();

            switch (options)
            {
                case 1:
                    return num * 2;
                    break;

                case 2:
                    return num * 3;
                    break;

                case 3:
                    if (num % 2 == 0)
                    {
                        return Console.WriteLine($"Num {num} is pair!");
                    }
                    else
                        return Console.WriteLine($"Num {num} is not pair!");
                    break;

                default:
                    return Console.WriteLine($"System out...");
                    break;

            }
        } while (options != 0);
    }
}