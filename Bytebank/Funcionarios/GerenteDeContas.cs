using Bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Funcionarios
{
    public class GerenteDeContas: FuncionarioAutenticavel
    {

        public GerenteDeContas(string cpf, string nome) : base(cpf, 4000, nome)
        {

        }
        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }


    }
}


