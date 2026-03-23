class Aluno
{
    public string Nome;
    static int TotalAlunos = 0;

    public Aluno(string nome)
    {
        Nome = nome;
        TotalAlunos++;
    }

    public static void ExibirTotalAlunos()
    {
       Console.WriteLine($"Total de alunos cadastrados: {TotalAlunos}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Quantos alunos deseja cadastrar? ");
        int qtd = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < qtd; i++)
        {
            Console.WriteLine($"Digite o nome do aluno a ser cadastrado: ");
            string nome = Console.ReadLine();

            Aluno novo = new Aluno(nome);
            Console.WriteLine($"Aluno cadastrado: {novo.Nome}");
        }

        Aluno.ExibirTotalAlunos();
    }
}