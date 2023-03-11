using Bytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Utilitario
{
    public class GerenciadorBonificacao
    {
        public double TotalBonificacao { get; private set; } //somente leitura

        public void RegistrarBonificacao(Funcionario funcionario)
        {
            this.TotalBonificacao += funcionario.GetBonificacao();
        }
    }
}
