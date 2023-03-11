using Bytebank;
using Bytebank.Contas;
using Bytebank.Funcionarios;
using Bytebank.Parceria;
using Bytebank.SistemaInterno;
using Bytebank.Titular;
using Bytebank.Utilitario;
using ByteBank;
using System.Numerics;

#region

#endregion

//UsarSistemaLogin();
//CalcularBonificao();

static void CalcularBonificao()
{
    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

    Diretor rafael = new("02002002020", "Rafael Madeira");
    Designer ramon = new("00011122233", "Ramon Madeira");
    Auxiliar ulisses = new("33322211100", "Ulisses");
    GerenteDeContas ruan = new("00011122233", "Ruan Madeira");

    gerenciador.RegistrarBonificacao(rafael);
    gerenciador.RegistrarBonificacao(ruan);
    gerenciador.RegistrarBonificacao(ulisses);
    gerenciador.RegistrarBonificacao(ramon);

    Console.WriteLine("total bonificação " + gerenciador.TotalBonificacao);

}

static void UsarSistemaLogin()
{

    SistemaInterno sistema = new();

    Diretor ingrid = new("10201201223", "Ingrid Guimaraes") { Senha = "1234" };

    GerenteDeContas israel = new("32132132143", "Israel Novais") { Senha = "3211" };

    sistema.Logar(ingrid, "1234");
    sistema.Logar(israel, "1234");

    ParceiroComercial parceiro = new();
    parceiro.Senha = "1234";
    sistema.Logar(parceiro, "1234");

}


#region
/*
try
{
    ContaCorrente conta03 = new(0, "3434-9");
    conta03.Sacar(5);
    Console.WriteLine(conta03.GetSaldo());
    conta03.Sacar(100);
    Console.WriteLine(conta03.GetSaldo());


}
catch (ArgumentException err)
{
    Console.WriteLine(err.ParamName);
    Console.WriteLine(err.StackTrace);
    Console.WriteLine(err.Message);
}
catch (SaldoInsuficienteExeption err)
{
    Console.WriteLine("operação Negada");
    Console.WriteLine(err.Message);
}
Console.WriteLine("taxa de operação " + ContaCorrente.TaxaOperacao);

*/

#endregion



    LeitorDeArquivo leitor = new("contas.txt");
try
{ 
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
}
catch (IOException)
{
    Console.WriteLine("Leitura de arquivo interrompida");
}
finally
{
    leitor.Dispose();

}