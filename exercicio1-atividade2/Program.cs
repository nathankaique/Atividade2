class Program
{
    static void Main(string[] args)
    {
        // Dados fornecidos
        decimal valorPresente = 1000m;    // R$ 1.000,00
        decimal taxaJuros = 5.30m / 100;  // 5,30% ao mês convertido para decimal
        int periodoMes = 10;              // Período de 10 meses

        // Cálculo do valor futuro usando a fórmula dos juros compostos
        decimal valorFuturo = valorPresente * (decimal)Math.Pow((double)(1 + taxaJuros), periodoMes);

        Console.WriteLine($"Valor Futuro: R$ {valorFuturo:f2}");
    }
}
