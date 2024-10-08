using System;

class Program
{
    public static void Main(string[] args)
    {
        // Definindo os valores
        double valorFuturo = 7390.61; // Valor Futuro em R$
        double taxaJuros = 0.05; // Taxa de juros de 5% ao ano (0,05)
        int numeroPeriodos = 2; // Número de períodos (anos)

        // Cálculo do Valor Presente (VP)
        double valorPresente = valorFuturo / Math.Pow(1 + taxaJuros, numeroPeriodos);

        // Exibindo os resultados
        Console.WriteLine($"Valor Futuro: R$ {valorFuturo}");
        Console.WriteLine($"Taxa de Juros: {taxaJuros * 100}%");
        Console.WriteLine($"Número de Períodos: {numeroPeriodos} anos");
        Console.WriteLine($"Valor Presente: R$ {Math.Round(valorPresente, 2)}");
    }
}
