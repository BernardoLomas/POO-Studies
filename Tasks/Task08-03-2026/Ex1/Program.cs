class Carro
{
    public string Marca;
    public string Modelo;
    public string Cor;
    public int anoFabricacao;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Cor: {Cor}");
        Console.WriteLine($"Ano de fabricação: {anoFabricacao}");
    }

    public void Buzinar()
    {
        Console.WriteLine("Beep Beeeeeep");
    }
}

class Program
{
    public static void Main()
    {
        Carro carro1 = new ();
        carro1.Marca = "Porsche";
        carro1.Modelo = "Porsche 911 GT RS";
        carro1.Cor = "Preto";
        carro1.anoFabricacao = 2020;

        Carro carro2 = new ();
        carro2.Marca = "Ferrari";
        carro2.Modelo = "Ferrari Purosangue";
        carro2.Cor = "Vermelho";
        carro2.anoFabricacao = 2025;

        Carro carro3 = new ();
        carro3.Marca = "Ford";
        carro3.Modelo = "Fusion Titanium";
        carro3.Cor = "Branco";
        carro3.anoFabricacao = 2015;

        carro1.ExibirInformacoes();
        carro1.Buzinar();
        Console.WriteLine();

        carro2.ExibirInformacoes();
        carro2.Buzinar();
        Console.WriteLine();

        carro3.ExibirInformacoes();
        carro3.Buzinar();
        Console.WriteLine();
    }
}