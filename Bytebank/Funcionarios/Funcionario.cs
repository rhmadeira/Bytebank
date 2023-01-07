using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; set; }
        public static int TotalFuncionarios { get; private set;}

        public virtual double GetBonificacao()
        {
            return this.Salario * 0.10;
        }

        public Funcionario(string cpf)
        {
            this.Cpf = cpf;
            TotalFuncionarios++;
        }

    }
}
