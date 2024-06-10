using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao.Classes
{
    public abstract class Pagamento
    {
        public abstract bool Pagar(double valor)
        {
           return ExecutarPagamento(valor);
        }

        private bool ExecutarPagamento(double valor) {

            return true;
        
        }
    }
}
