using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Carro
    {
        // 1 -  Conceito de encapsulamento é deixar os atributos da classes privados 
        private  Guid _id;
        private string _name;
        private int _quantidade;

        private void show()
        {

            Console.WriteLine($"Carro Id : {_id}");
            Console.WriteLine($"Carro Nome: {_name}");
            Console.WriteLine($"Carro Quantidade: {_quantidade}");
        }

        // 2 - Acessalos e atribuilos apartir de algum metodo dentro da classe .
        public void mensagem()
        {
            _id = Guid.NewGuid();

            Console.WriteLine("Informe o nome do veiculo");
            _name = Console.ReadLine();
            Console.WriteLine("Informe a quantidade em estoque");
            _quantidade =  Convert.ToInt32(Console.ReadLine());

            show();
        }

         // 3 - Tornando assim o conceito de encapsulamento , motivos  torna-se mais seguro o código e mais facil de manuseio.

    }
}
