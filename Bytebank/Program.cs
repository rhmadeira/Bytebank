using Bytebank.Contas;
using Bytebank.Titular;

Cliente cliente01 = new Cliente();
cliente01.nome = "Rafael Madeira";
cliente01.cpf = "4564654645";
cliente01.profissao = "Analista";

ContaCorrente conta01 = new ContaCorrente();
conta01.Numero_agencia = 123;
conta01.Conta = "123123-1";

ContaCorrente conta02 = new ContaCorrente();


conta01.SetSaldo(100);

Console.WriteLine(conta01.GetSaldo());
Console.WriteLine(conta01.Numero_agencia);
Console.WriteLine(conta01.Conta);