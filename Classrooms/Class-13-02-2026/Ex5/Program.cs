class Program
{
    public static void Main()
    {
        Console.Write("Number of voters: ");
        int totalVoters = int.Parse(Console.ReadLine());
        
        int[] votes = new int[totalVoters];
        int currentVoter = 0;

        do
        {
            Console.Clear();
            Console.WriteLine($"Voter {currentVoter + 1} of {totalVoters}");
            Console.WriteLine("1 - Candidate A");
            Console.WriteLine("2 - Candidate B");
            Console.WriteLine("3 - White vote");
            Console.WriteLine("0 - Exit system");
            Console.Write("Select your option: ");
            
            int option = int.Parse(Console.ReadLine());

            if (option == 0) Environment.Exit(0);

            if (option >= 1 && option <= 3)
            {
                votes[currentVoter] = option; 
                currentVoter++;
                Console.WriteLine("Vote registered successfully!");
            }
            else
            {
                Console.WriteLine("Invalid option! Press any key to try again...");
                Console.ReadKey();
            }

        } while (currentVoter < totalVoters);

        int A = CountVotes(votes, 1);
        int B = CountVotes(votes, 2);
        int White = CountVotes(votes, 3);

        Console.Clear();
        Console.WriteLine("--- Results ---");
        Console.WriteLine($"Candidate A: {A}");
        Console.WriteLine($"Candidate B: {B}");
        Console.WriteLine($"White Votes: {White}");
        Console.WriteLine("---------------");

        if (A > B) Console.WriteLine("Winner: Candidate A!");
        else if (B > A) Console.WriteLine("Winner: Candidate B!");
        else Console.WriteLine("Result: Tie or no clear winner.");
    }

    static int CountVotes(int[] votes, int target)
    {
        int count = 0;
        foreach (int v in votes)
        {
            if (v == target) count++;
        }
        return count;
    }
}