static class ConversorTemperatura
{
    static public double CelsiusParaFahrenheit(double c)
    {
        return (c * 9/5) + 32;
    }

    static public double FahrenheitParaCelsius(double f)
    {
        return (f - 32) * 5/9;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Escreva um valor para converter de Celsius para Fahrenheit: ");
        double c = double.Parse(Console.ReadLine());
        double resultadoF = ConversorTemperatura.CelsiusParaFahrenheit(c);
        Console.WriteLine($"Resultado: {resultadoF} graus Fahrenheit");
        

        Console.WriteLine($"Escreva um valor para converter de Fahrenheit para Celsius: ");
        double f = double.Parse(Console.ReadLine());
        double resultadoC = ConversorTemperatura.FahrenheitParaCelsius(f);
        Console.WriteLine($"Resultado: {resultadoC} graus Celsius");
        


    }
}