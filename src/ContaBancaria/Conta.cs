namespace ContaBancaria;

public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException(string mensagem) : base(mensagem) { }
}

public class Conta
{
    public string Titular { get; }
    public decimal Saldo { get; private set; }

    public Conta(string titular, decimal saldoInicial = 0)
    {
        if (string.IsNullOrWhiteSpace(titular))
            throw new ArgumentException("O titular é obrigatório.");
        if (saldoInicial < 0)
            throw new ArgumentException("O saldo inicial não pode ser negativo.");

        Titular = titular;
        Saldo = saldoInicial;
    }

    public decimal Depositar(decimal valor)
    {
        if (valor <= 0)
            throw new ArgumentException("O valor do depósito deve ser maior que zero.");

        Saldo += valor;
        return Saldo;
    }

    public decimal Sacar(decimal valor)
    {
        if (valor <= 0)
            throw new ArgumentException("O valor do saque deve ser maior que zero.");
        if (valor > Saldo)
            throw new SaldoInsuficienteException("Saldo insuficiente.");

        Saldo -= valor;
        return Saldo;
    }
}
