class Filme
{
    public string titulo;
    public string diretor;
    public int anoLancamento;
    public bool emprestado;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {titulo}");
        Console.WriteLine($"Diretor: {diretor}");
        Console.WriteLine($"Ano de lançamento: {anoLancamento}");
        Console.WriteLine($"Emprestado: {emprestado}");
    }

    public void Emprestar()
    {
        Console.WriteLine();
        if(emprestado == false)
        {
            emprestado = true;
            Console.WriteLine($"Filme emprestado com sucesso!");
        }
        else
            Console.WriteLine($"O filme já está emprestado!");
    }

    public void Devolver()
    {
        Console.WriteLine();
        if(emprestado == true)
        {
            emprestado = false;
            Console.WriteLine($"Filme devolvido!");
        }
        else
            Console.WriteLine($"O filme não está emprestado e está disponível!");
    }
}

class TesteFilme
{
    static void Main()
    {
        Console.WriteLine($"Quantos filmes deseja cadastrar? ");
        int qtd = int.Parse(Console.ReadLine());
        
        Filme[] filmes = new Filme[qtd];

        for(int i = 0; i < filmes.Length; i++)
        {
            filmes[i] = new Filme();

            Console.WriteLine($"Título do filme: ");
            filmes[i].titulo = Console.ReadLine();

            Console.WriteLine($"Diretor do filme: ");
            filmes[i].diretor = Console.ReadLine();

            Console.WriteLine($"Ano de lançamento do filme: ");
            filmes[i].anoLancamento = int.Parse(Console.ReadLine());
            
            filmes[i].emprestado = false;
        }

        Console.Clear();

        Console.WriteLine($"<====== Filmes cadastrados ======>");
        for(int i = 0; i < filmes.Length; i++)
        {
            Console.WriteLine($"\nFilme {i + 1}: ");
            filmes[i].ExibirInformacoes();
        }

        Console.ReadKey();
        Console.Clear();

        if(qtd > 0)
        {
            Console.WriteLine("\nTestando empréstimo dos filmes: ");
            for(int i = 0; i < filmes.Length; i++)
            {
                filmes[i].Emprestar();
                filmes[i].ExibirInformacoes();
            }

            Console.WriteLine("\n Testando devolução dos filmes: ");
            for(int i = 0; i < filmes.Length; i++)
            {
                filmes[i].Devolver();
                filmes[i].ExibirInformacoes();
            }

        }
    }
}