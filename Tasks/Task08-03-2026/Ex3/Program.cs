using System;

class Jogo
{
    public string titulo;
    public string plataforma;
    public int anoLancamento;
    public bool emprestado;

    public void ExibirInformacoes()
    {
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Plataforma: " + plataforma);
        Console.WriteLine("Ano de Lançamento: " + anoLancamento);
        Console.WriteLine("Emprestado: " + emprestado);
    }

    public void Emprestar()
    {
        if (emprestado == false)
        {
            emprestado = true;
            Console.WriteLine("Jogo emprestado com sucesso.");
        }
        else
        {
            Console.WriteLine("O jogo já está emprestado.");
        }
    }

    public void Devolver()
    {
        if (emprestado == true)
        {
            emprestado = false;
            Console.WriteLine("Jogo devolvido com sucesso.");
        }
        else
        {
            Console.WriteLine("O jogo já está disponível.");
        }
    }
}

class TesteJogo
{
    static void Main()
    {
        Console.Write("Quantos jogos deseja cadastrar? ");
        int quantidade = int.Parse(Console.ReadLine());

        Jogo[] jogos = new Jogo[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            jogos[i] = new Jogo();

            Console.WriteLine($"\nCadastro do jogo {i + 1}:");

            Console.Write("Título: ");
            jogos[i].titulo = Console.ReadLine();

            Console.Write("Plataforma: ");
            jogos[i].plataforma = Console.ReadLine();

            Console.Write("Ano de lançamento: ");
            jogos[i].anoLancamento = int.Parse(Console.ReadLine());

            jogos[i].emprestado = false;
        }

        Console.WriteLine("\n--- JOGOS CADASTRADOS ---");
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"\nJogo {i + 1}:");
            jogos[i].ExibirInformacoes();
        }

        if (quantidade > 0)
        {
            Console.WriteLine("\nTestando empréstimo do primeiro jogo:");
            jogos[0].Emprestar();
            jogos[0].ExibirInformacoes();

            Console.WriteLine("\nTestando devolução do primeiro jogo:");
            jogos[0].Devolver();
            jogos[0].ExibirInformacoes();
        }
    }
}