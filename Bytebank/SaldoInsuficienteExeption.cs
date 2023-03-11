using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank
{
    public class SaldoInsuficienteExeption : Exception
    {
        public SaldoInsuficienteExeption(string mensagem) : base(mensagem)
        {

        }
    }
}
