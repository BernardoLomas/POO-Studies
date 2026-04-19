class Aluno
{
    private string nome;

    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public Aluno(string nome)
    {
        this.nome = nome;
    }

    public void ExibirNome()
    {
        Console.WriteLine($"Nome do aluno: {nome}");
    }
}

class EscolaDependencia
{
    public void ExibirNomeReferencia(Aluno aluno)
    {
        Console.WriteLine($"Nome do aluno (Impresso por referência de classe): {aluno.GetNome()}");
    }
}

class Program
{
    static void Main()
    {
        EscolaDependencia escola = new EscolaDependencia();
        Aluno aluno1 = new Aluno("Bernardo Lomas");
        Aluno aluno2 = new Aluno("Otavio Lomas");

        aluno1.ExibirNome();
        aluno2.ExibirNome();

        escola.ExibirNomeReferencia(aluno1);
        escola.ExibirNomeReferencia(aluno2);

    }
}