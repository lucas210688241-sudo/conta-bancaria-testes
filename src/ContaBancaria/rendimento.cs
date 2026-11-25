namespace ContaBancaria;

public static class Rendimento
{
    public static decimal Calcular(decimal saldo, decimal taxaMensal, int meses)
    {
        if (saldo < 0)
            throw new ArgumentException("O saldo não pode ser negativo.");
        if (taxaMensal < 0)
            throw new ArgumentException("A taxa não pode ser negativa.");
        if (meses <= 0)
            throw new ArgumentException("O número de meses deve ser maior que zero.");

        decimal fator = 1m;
        for (int i = 0; i < meses; i++)
        {
            fator *= 1 + taxaMensal;
        }

        return Math.Round(saldo * fator, 2);
    }
}
