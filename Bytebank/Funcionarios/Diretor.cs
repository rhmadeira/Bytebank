using Bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Funcionarios
{
    public class Diretor:FuncionarioAutenticavel
    {

        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public Diretor(string cpf, string nome):base(cpf, 5000, nome)
        {
        }

        
    }
}
