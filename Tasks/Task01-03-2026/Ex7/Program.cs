class Vet
{
    private int[] dados;

    public Vet(int tamanho)
    {
        dados = new int[tamanho];
    }

    public bool Inserir(int posicao, int valor)
    {
        if (posicao >= 0 && posicao < dados.Length)
        {
            dados[posicao] = valor;
            return true;
        }

        return false;
    }

    public int Recuperar(int posicao)
    {
        if (posicao >= 0 && posicao < dados.Length)
            return dados[posicao];

        return -1;
    }

    public bool Existe(int valor)
    {
        foreach (int item in dados)
        {
            if (item == valor)
                return true;
        }
        return false;
    }

    public int SomaPares()
    {
        int soma = 0;
        foreach (int item in dados)
        {
            if (item % 2 == 0)
                soma += item;
        }
        return soma;
    }

    public int SomaImpares()
    {
        int soma = 0;
        foreach (int item in dados)
        {
            if (item % 2 != 0)
                soma += item;
        }
        return soma;
    }

    public int SomaTotal()
    {
        int soma = 0;
        foreach (int item in dados)
            soma += item;

        return soma;
    }

    public void Listar()
    {
        for (int i = 0; i < dados.Length; i++)
            Console.WriteLine($"Posição {i}: {dados[i]}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tamanho = int.Parse(Console.ReadLine());

        Vet vetor = new Vet(tamanho);

        int opcao;

        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1 - Inserir valor");
            Console.WriteLine("2 - Recuperar valor");
            Console.WriteLine("3 - Consultar existência");
            Console.WriteLine("4 - Soma pares");
            Console.WriteLine("5 - Soma ímpares");
            Console.WriteLine("6 - Soma total");
            Console.WriteLine("7 - Listar elementos");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Posição: ");
                    int pos = int.Parse(Console.ReadLine());

                    Console.Write("Valor: ");
                    int valor = int.Parse(Console.ReadLine());

                    if (vetor.Inserir(pos, valor))
                        Console.WriteLine("Inserido com sucesso.");
                    else
                        Console.WriteLine("Posição inválida.");
                    break;

                case 2:
                    Console.Write("Posição: ");
                    int posRec = int.Parse(Console.ReadLine());

                    try
                    {
                        int resultado = vetor.Recuperar(posRec);
                        Console.WriteLine($"Valor na posição {posRec}: {resultado}");
                    }
                    catch
                    {
                        Console.WriteLine("Posição inválida.");
                    }
                    break;

                case 3:
                    Console.Write("Valor para buscar: ");
                    int busca = int.Parse(Console.ReadLine());

                    if (vetor.Existe(busca))
                        Console.WriteLine("Valor encontrado.");
                    else
                        Console.WriteLine("Valor não encontrado.");
                    break;

                case 4:
                    Console.WriteLine($"Soma pares: {vetor.SomaPares()}");
                    break;

                case 5:
                    Console.WriteLine($"Soma ímpares: {vetor.SomaImpares()}");
                    break;

                case 6:
                    Console.WriteLine($"Soma total: {vetor.SomaTotal()}");
                    break;

                case 7:
                    vetor.Listar();
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