using System;

class Program {
    public static void Main(string[] args) {
        // Definindo valores diretamente pelo usuário
        double[] rendimentos = new double[12]; // Array para armazenar rendimentos mensais

        // Entrada de valores iniciais pelo usuário
        Console.Write("Digite o valor presente: ");
        double valorPresente = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a taxa de juros ao mês: ");
        double taxaJuros = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o período: ");
        int periodo = Convert.ToInt32(Console.ReadLine());

        // Cálculo do valor futuro
        double valorFuturo = valorPresente * (Math.Pow((taxaJuros / 100) + 1, periodo));

        // Cálculo da renda líquida
        double rendaLiquida = valorFuturo - valorPresente;
        Console.WriteLine($"Renda líquida após {periodo} meses: R$ {Math.Round(rendaLiquida, 2)}");

        // Cálculo da renda acumulada
        double rendaAcumulada = valorFuturo + rendaLiquida;
        Console.WriteLine($"Renda acumulada após {periodo} meses: R$ {Math.Round(rendaAcumulada, 2)}");

        // Entrada do valor de saque
        Console.Write("Digite o valor do saque: ");
        double saque = Convert.ToDouble(Console.ReadLine());

        // Cálculo do saldo após o saque
        double saldo = rendaAcumulada - saque;
        Console.WriteLine($"Saldo após o saque: R$ {Math.Round(saldo, 2)}");
    }
}
