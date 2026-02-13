class Program
{
    static void Main()
    {
        Console.WriteLine($"Register a password: ");
        string password = Console.ReadLine();

        Console.WriteLine($"Confirm password: ");
        string confirm = Console.ReadLine();

        var A = Confirm(password, confirm);
        if(A)
            Console.WriteLine($"Password confirmed!");
        else
            Console.WriteLine($"Passwords are not the same!");
    }

    static bool Confirm(string password, string confirm)
    {
        if(password == confirm)
            return true;
        else
            return false;
    }   
}
