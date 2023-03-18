using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_dinamica
{
    internal class Lista
    {
        public int value;
        public int pos;
        public Lista proximo;

        public void Insere(Lista lista, int value, int pos)
        {
            if(lista.proximo == null)
            {
                lista.proximo = new Lista();
                lista.proximo.value = value;
                lista.proximo.pos = pos + 1;
            } else
            {
                lista.Insere(lista, value, pos);
            }
        }

        public void Tira(Lista lista)
        {
            if(lista.proximo == null){
                lista = null;
            }
            else
            {
                lista.Tira(lista);
            }
        }

        
    }
}
