namespace ContaBancaria.Tests;

public class TransferenciaTests
{
    [Fact]
    public void Transferir_AtualizaOsDoisSaldos()
    {
        var origem = new Conta("Eduardo", 100m);
        var destino = new Conta("João", 0m);

        Transferencia.Transferir(origem, destino, 50m);

        Assert.Equal(50m, origem.Saldo);
        Assert.Equal(50m, destino.Saldo);
    }

    [Fact]
    public void Transferir_SemSaldo_NaoAlteraContas()
    {
        var origem = new Conta("Eduardo", 20m);
        var destino = new Conta("João", 0m);

        Assert.Throws<SaldoInsuficienteException>(
            () => Transferencia.Transferir(origem, destino, 50m));

        Assert.Equal(20m, origem.Saldo);
        Assert.Equal(0m, destino.Saldo);
    }

    [Fact]
    public void Transferir_ParaAMesmaConta_GeraErro()
    {
        var conta = new Conta("Eduardo", 100m);

        Assert.Throws<ArgumentException>(
            () => Transferencia.Transferir(conta, conta, 10m));
    }
}