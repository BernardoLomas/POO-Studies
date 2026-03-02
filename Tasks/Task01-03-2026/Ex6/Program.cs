class Data
{
    public int Dia;
    public int Mes;
    public int Ano;

    public Data(int dia, int mes, int ano)
    {
        Dia = dia;
        Mes = mes;
        Ano = ano;
    }

    public string MostrarData()
    {
        return $"{Dia}/{Mes}/{Ano}";
    }
}

class Funcionario
{
    public int Matricula;
    public string Nome;
    public string Departamento;
    public double Salario;
    public Data DataAdmissao;

    public Funcionario(int matricula, string nome, string departamento, double salario, Data dataAdmissao)
    {
        Matricula = matricula;
        Nome = nome;
        Departamento = departamento;
        Salario = salario;
        DataAdmissao = dataAdmissao;
    }

    public void Exibir()
    {
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Departamento: {Departamento}");
        Console.WriteLine($"Salário: {Salario}");
        Console.WriteLine($"Data de Admissão: {DataAdmissao.MostrarData()}");
        Console.WriteLine("----------------------------");
    }
}

class Program
{
    static void Main()
    {
        Funcionario[] funcionarios = new Funcionario[50];
        int contador = 0;

        Console.Write("Quantos funcionários deseja cadastrar? ");
        int qtd = int.Parse(Console.ReadLine());

        for (int i = 0; i < qtd; i++)
        {
            Console.WriteLine("\nCadastro do funcionário:");

            Console.Write("Matrícula: ");
            int matricula = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Departamento: ");
            string departamento = Console.ReadLine();

            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Dia de admissão: ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Mês de admissão: ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Ano de admissão: ");
            int ano = int.Parse(Console.ReadLine());

            Data data = new Data(dia, mes, ano);

            funcionarios[contador] = new Funcionario(matricula, nome, departamento, salario, data);
            contador++;
        }

        Console.Write("\nDigite o departamento para listar: ");
        string BuscaDepartamento = Console.ReadLine();

        Console.WriteLine("\nFuncionários encontrados:\n");

        for (int i = 0; i < contador; i++)
        {
            if (funcionarios[i].Departamento == BuscaDepartamento)
            {
                funcionarios[i].Exibir();
            }
        }
    }
}