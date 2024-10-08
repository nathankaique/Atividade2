using System;

class Program {
    public static void Main(string[] args) {
        // Definindo valores diretamente
        double[] rendimentos = new double[12]; // Array para armazenar rendimentos mensais

        // Definindo valores iniciais
        double valorPresente = 2000.00; // Exemplo: R$ 1000,00
        double taxaJuros = 2.00; // Exemplo: 5% ao mês
        int periodo = 6; // Exemplo: 3 meses

        // Cálculo do valor futuro
        double valorFuturo = valorPresente * (Math.Pow((taxaJuros / 100) + 1, periodo));

        // Cálculo da renda líquida
        double rendaLiquida = valorFuturo - valorPresente;
        Console.WriteLine($"Renda líquida após {periodo} meses: R$ {Math.Round(rendaLiquida, 2)}");

        // Cálculo da renda acumulada
        double rendaAcumulada = valorFuturo + rendaLiquida;
        Console.WriteLine($"Renda acumulada após {periodo} meses: R$ {Math.Round(rendaAcumulada, 2)}");

        // Definindo valor do saque
        double saque = 200.00; // Exemplo: R$ 200,00
        Console.WriteLine($"saque de: R$ {Math.Round(saque, 2)}");

        // Cálculo do saldo após o saque
        double saldo = rendaAcumulada - saque;
        Console.WriteLine($"Saldo após o saque: R$ {Math.Round(saldo, 2)}");
    }
}
