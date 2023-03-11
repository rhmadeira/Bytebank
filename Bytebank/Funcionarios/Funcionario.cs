using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalFuncionarios { get; private set;}
       

        public double SetSalario(double valor)
        {
            return this.Salario += valor;
        }

        public abstract double GetBonificacao();

        public abstract void AumentarSalario();

       


        public Funcionario(string cpf,double salario,string nome)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            this.Nome = nome;
            TotalFuncionarios++;
        }

    }
}
