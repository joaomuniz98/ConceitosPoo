using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao.Classes
{
    public  class Pessoa : Pagamento
    {
        public override bool Pagar(double valor)
        {
            throw new NotImplementedException();
        }

        public void PagarBoleto()
        {
          
        }
    }
}
