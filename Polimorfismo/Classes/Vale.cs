using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Classes
{
    public class Vale
    {
        public virtual void valeAlimentacao(double salario)
        {
            var resultado = salario * 0.1;
            Console.Write($"Valor do vale alimentacao: {resultado}\n");
        }

        public virtual void valeTransporte(double salario)
        {
            var resultado = salario * 0.1;
            Console.Write($"Valor do vale transporte: {resultado}\n");

        }


    }
}
