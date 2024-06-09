using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Classes
{
    public class Atendente : Vale
    {

        public override void valeAlimentacao(double salario)
        {
            var resultado = salario * 0.5;
            Console.WriteLine($"Valor do Vale alimentacao de {resultado}");
        }

        public override void valeTransporte(double salario)
        {
            var resultado = salario * 0.5;
            Console.WriteLine($"Valor do Vale transporte de {resultado}");
        }
    }
}
