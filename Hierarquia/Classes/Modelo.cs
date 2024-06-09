using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Classes
{
    public class Modelo 
    {
        private string Nome;

        private string Cor;

        private int Cavalos;

        public void Criar(string nome, string cor , int cavalos)
        {
            this.Nome = nome;
            this.Cor = cor;
            this.Cavalos = cavalos;
        }


        public void Show()
        {
            Console.WriteLine($"Nome:  {this.Nome}");
            Console.WriteLine($"Cor: {this.Cor}");
            Console.WriteLine($"Cavalos: {this.Cavalos}");
        }
    }
}
