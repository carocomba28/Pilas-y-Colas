using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_2
{
    class Colas : lCollection
    {
        List<object> lista = new List<object>();

        public bool agregar(object o)
        {
            lista.Add(o);
            if(lista.Contains(o))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool estaVacia()
        {
            if(lista.Count==0)
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
            object o = null;
            o = lista[0];
            lista.RemoveAt(0);
            return o;
        }

        public object primero()
        {
            return lista[0];
        }
    }
}
