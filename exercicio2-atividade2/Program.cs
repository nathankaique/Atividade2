using System;

class Program
{
    static void Main(string[] args)
    {
        // Dados fornecidos
        double valorPresente = 3800.00;   // Valor inicial R$ 1.000,00
        double taxaJuros = 1.25 / 100;    // Taxa de juros 5,30% ao mês
        int meses = 6;                    // Período de 6 meses

        // Exibir o valor inicial no mês 0
        Console.WriteLine("====== RENDIMENTOS ======");
        Console.WriteLine($"0° Mês   |   R$ {valorPresente:F2}");

        // Cálculo do valor futuro mês a mês
        for (int mes = 1; mes <= meses; mes++)
        {
            valorPresente *= (1 + taxaJuros);  // Atualiza o valor presente com o rendimento do mês
            Console.WriteLine($"{mes}° Mês   |   R$ {Math.Round(valorPresente, 2)}");
        }
    }
}
