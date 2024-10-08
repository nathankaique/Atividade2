using System;

class Program
{
    static void Main(string[] args)
    {
        // Defina os valores diretamente no código
        double valor = 68.00;      // Valor a ser investido
        double taxa1 = 2.00/100;         // Taxa de juros (%)// Converte para decimal (taxa de 5.30% = 0.053)
        int meses = 3;              // Tempo de investimento em meses

        // Exibir valores iniciais
        Console.WriteLine($"Valor investido: R$ {valor}");
        Console.WriteLine($"Taxa de juros: {taxa1*100}%");
        Console.WriteLine($"Tempo de investimento: {meses} meses");

        // Cálculo do valor futuro com juros compostos
        double valorFuturo = valor * Math.Pow(1 + taxa1, meses);

        // Exibe o valor futuro arredondado com 2 casas decimais
        Console.WriteLine($"Valor Futuro: R$ {Math.Round(valorFuturo, 2)}");
    }
}
