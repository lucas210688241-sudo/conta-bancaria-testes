# Conta Bancária: Testes Automatizados

## Domínio
Sistema bancário simples, sem interface gráfica: criar conta, depositar, sacar, transferir e simular rendimento.

## Framework
C# (.NET) e xUnit.

## Como executar os testes
    dotnet restore
    dotnet test

## Testes implementados

### Conta (Lucas)
- Criar conta com titular "Lucas" e saldo 100: titular e saldo são guardados.
- Depositar 50 em saldo 100: novo saldo é 150.
- Depositar -10: gera ArgumentException.
- Sacar 30 de saldo 100: novo saldo é 70.
- Sacar 200 de saldo 100: gera SaldoInsuficienteException e o saldo continua 100.

### Transferência (Eduardo)
A preencher.

### Rendimento (João)
A preencher.

## Gitflow
main (estável), develop (desenvolvimento), feature/* (novas funcionalidades), release/* (preparação de versão) e hotfix/* (correções emergenciais).

## Equipe
Lucas, Eduardo e João.