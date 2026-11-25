namespace ContaBancaria;

public static class Transferencia
{
    public static void Transferir(Conta origem, Conta destino, decimal valor)
    {
        if (ReferenceEquals(origem, destino))
            throw new ArgumentException("Origem e destino devem ser contas diferentes.");

        origem.Sacar(valor);
        destino.Depositar(valor);
    }
}