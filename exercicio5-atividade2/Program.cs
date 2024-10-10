using System;

class Program
{
    public static void Main(string[] args)
    {
        // Entrada de valores pelo usuário
        Console.Write("Digite o valor futuro : ");
        double valorFuturo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a taxa de juros ao ano: ");
        double taxaJuros = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.Write("Digite o número de períodos: ");
        int numeroPeriodos = Convert.ToInt32(Console.ReadLine());

        // Cálculo do Valor Presente (VP)
        double valorPresente = valorFuturo / Math.Pow(1 + taxaJuros, numeroPeriodos);

        // Exibindo os resultados
        Console.WriteLine($"\nValor Futuro: R$ {valorFuturo}");
        Console.WriteLine($"Taxa de Juros: {taxaJuros * 100}%");
        Console.WriteLine($"Número de Períodos: {numeroPeriodos} anos");
        Console.WriteLine($"Valor Presente: R$ {Math.Round(valorPresente, 2)}");
    }
}
