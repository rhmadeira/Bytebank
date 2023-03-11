using Bytebank.Contas;
using Bytebank.Funcionarios;
using Bytebank.Titular;
using Bytebank.Utilitario;

#region

#endregion

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

CalcularBonificao();