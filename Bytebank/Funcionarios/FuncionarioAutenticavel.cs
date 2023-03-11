using Bytebank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticavel(string cpf, double salario, string nome) : base(cpf, salario, nome)
        {
        }

        public string Senha {get; set;}
        public bool Autenticar(string senha)
        {
            return this.Senha.Equals(senha);
        }
    }
}
