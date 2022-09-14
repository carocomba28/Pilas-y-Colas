using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_2
{
    class Pila : lCollection
    {
        object[] array = new object[10];

        public bool agregar(object obj)
        {
            
        }

        public bool estaVacia()
        {
            if (array.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object extraer()
        {

        }

        public object primero()
        {
            return array[0];
        }
    }
}
