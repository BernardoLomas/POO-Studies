using System;

class Curso
{
    public string Nome;
    public int CargaHoraria;

    public Curso(string nome)
    {
        Nome = nome;
        CargaHoraria = 40;
    }
    public Curso(string nome, int cargaHoraria)
    {
        Nome = nome;
        CargaHoraria = cargaHoraria;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome do curso: {Nome} | Carga horária: {CargaHoraria}");
    }

    public void Confirmar()
    {
        Console.WriteLine($"Curso {Nome} criado!");
    }

    ~Curso()
    {
        Console.WriteLine($"O curso {Nome} foi removido da memória!");
    }
}

class Program
{
    static void Main()
    {
        Curso novo = new Curso("Sistemas de Informação");
        novo.Confirmar();

        Console.WriteLine("Digite o nome do curso:");
        string nomeCurso = Console.ReadLine();

        Console.WriteLine("Digite a carga horária:");
        int carga = int.Parse(Console.ReadLine());

        Curso novo2 = new Curso(nomeCurso, carga);
        novo2.Confirmar();

        novo.ExibirDados();
        novo2.ExibirDados();
    }
}