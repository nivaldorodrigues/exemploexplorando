using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            Console.WriteLine("Início do método 1");
            Metodo2();
            Console.WriteLine("Fim do método 1");
        }

        private void Metodo2()
        {
            Console.WriteLine("Início do método 2");
            Metodo3();
            Console.WriteLine("Fim do método 2");
        }

        private void Metodo3()
        {
            Console.WriteLine("Início do método 3");
        }
        private void Metodo4()
        {
            Console.WriteLine("Início do método 4");
            Console.WriteLine("Fim do método 4");
        }
    }
}