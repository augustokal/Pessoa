using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    class Program
    {
        static void Main(string[] args)
            //Faça um projeto que armazene idade altura e peso
        {

            pessoa pessoa1 = new pessoa();

            Console.WriteLine("Insira seus dados");

            Console.WriteLine("Informe seus dados");



            Console.WriteLine("Informe seu nome");
            pessoa1.nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade");
            pessoa1.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe sua altura");
            pessoa1.altura = Convert.ToDouble(Console.ReadLine());

            pessoa1.sobreVoce();
            Console.ReadKey();


        }
    }
}
