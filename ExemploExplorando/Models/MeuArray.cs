using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploExplorando.Models;
using Models;

namespace Models
{
    public class MeuArray<T>
    {
        private static int capacidade = 10;
        private T[] _array = new T[capacidade];
        private int contador = 0;

        public void AdicionarElementoArray(T elemento)
        {
            if (contador < capacidade)
            {
                _array[contador] = elemento;
                contador++;
            }
        }

        public T this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }
        
    }
}