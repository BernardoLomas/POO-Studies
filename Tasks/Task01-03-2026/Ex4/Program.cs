class Program
{
    static void Main()
    {
        int[] vetor = { 1, 1, 1, 1 };

        int soma = SomaVetor(vetor, 0);

        Console.WriteLine($"Soma dos elementos: {soma}");
    }

    static int SomaVetor(int[] vetor, int indice)
    {
        if (indice == vetor.Length)
            return 0;

        return vetor[indice] + SomaVetor(vetor, indice + 1);
    }
}