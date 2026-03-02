using System;

struct Livro
{
    private string titulo;
    private string autor;
    private string genero;
    private int ano;

    public Livro(string titulo, string autor, string genero, int ano)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.genero = genero;
        this.ano = ano;
    }

    public string ObterTitulo() => titulo;
    public string ObterAutor() => autor;
    public string ObterGenero() => genero;
    public int ObterAno() => ano;

    public bool Modernismo()
    {
        return ano >= 1930 && ano <= 1945;
    }

    public bool Barroco()
    {
        return ano >= 1601 && ano <= 1768;
    }
}

class Program
{
    static void Main()
    {
        Livro livro = new Livro();
        bool livroCriado = false;

        int opcao;

        do
        {
            Console.WriteLine("\n--- MENU LIVRO ---");
            Console.WriteLine("1 - Criar Livro");
            Console.WriteLine("2 - Mostrar Dados");
            Console.WriteLine("3 - Verificar se é Modernismo");
            Console.WriteLine("4 - Verificar se é Barroco");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Título: ");
                    string titulo = Console.ReadLine();

                    Console.Write("Autor: ");
                    string autor = Console.ReadLine();

                    Console.Write("Gênero: ");
                    string genero = Console.ReadLine();

                    Console.Write("Ano: ");
                    int ano = int.Parse(Console.ReadLine());

                    livro = new Livro(titulo, autor, genero, ano);
                    livroCriado = true;

                    Console.WriteLine("Livro criado com sucesso!");
                    break;

                case 2:
                    if (livroCriado)
                    {
                        Console.WriteLine("\n--- Dados do Livro ---");
                        Console.WriteLine($"Título: {livro.ObterTitulo()}");
                        Console.WriteLine($"Autor: {livro.ObterAutor()}");
                        Console.WriteLine($"Gênero: {livro.ObterGenero()}");
                        Console.WriteLine($"Ano: {livro.ObterAno()}");
                    }
                    else
                    {
                        Console.WriteLine("Nenhum livro criado ainda.");
                    }
                    break;

                case 3:
                    if (livroCriado)
                        Console.WriteLine(livro.Modernismo()
                            ? "Pertence ao Modernismo."
                            : "Não pertence ao Modernismo.");
                    else
                        Console.WriteLine("Nenhum livro criado.");
                    break;

                case 4:
                    if (livroCriado)
                        Console.WriteLine(livro.Barroco()
                            ? "Pertence ao Barroco."
                            : "Não pertence ao Barroco.");
                    else
                        Console.WriteLine("Nenhum livro criado.");
                    break;

                case 0:
                    Console.WriteLine("Encerrando...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 0);
    }
}