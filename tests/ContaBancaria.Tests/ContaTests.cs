namespace ContaBancaria.Tests;

public class ContaTests
{
    [Fact]
    public void CriarConta_ComSaldoInicial_DefineTitularESaldo()
    {
        var conta = new Conta("Lucas", 100m);

        Assert.Equal("Lucas", conta.Titular);
        Assert.Equal(100m, conta.Saldo);
    }

    [Fact]
    public void Depositar_AumentaSaldo()
    {
        var conta = new Conta("Lucas", 100m);

        var novoSaldo = conta.Depositar(50m);

        Assert.Equal(150m, novoSaldo);
        Assert.Equal(150m, conta.Saldo);
    }

    [Fact]
    public void Depositar_ValorInvalido_GeraErro()
    {
        var conta = new Conta("Lucas", 100m);

        Assert.Throws<ArgumentException>(() => conta.Depositar(-10m));
    }

    [Fact]
    public void Sacar_DiminuiSaldo()
    {
        var conta = new Conta("Lucas", 100m);

        Assert.Equal(70m, conta.Sacar(30m));
    }

    [Fact]
    public void Sacar_AcimaDoSaldo_GeraErro()
    {
        var conta = new Conta("Lucas", 100m);

        Assert.Throws<SaldoInsuficienteException>(() => conta.Sacar(200m));
        Assert.Equal(100m, conta.Saldo);
    }
}