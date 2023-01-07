using Bytebank.Contas;
using Bytebank.Titular;

ContaCorrente conta01 = new ContaCorrente(2342, "1231-X");
Console.WriteLine("posição da conta " + ContaCorrente.TotalContasCriadas);
ContaCorrente conta02 = new ContaCorrente(2343, "1232-X");
ContaCorrente conta03 = new ContaCorrente(2344, "1233-X");
ContaCorrente conta04 = new ContaCorrente(2345, "1234-X");
ContaCorrente conta05 = new ContaCorrente(2346, "1235-X");
Console.WriteLine("posição da conta " + ContaCorrente.TotalContasCriadas);

