using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_dinamica
{

    internal class Indica
    {
        public int elemento;
        public Indica prox;
        public Indica() { }
        public Indica(int elemento) {
            this.elemento = elemento;
            this.prox = null;
        }
    }


    internal class Pilha
    {
        public Indica sentinela;

        public Pilha()
        {
            sentinela = null;
        }

        public void insere (int aux2)
        {
            Indica aux1 = new Indica(aux2);
            aux1.prox = sentinela;
            sentinela = aux1;
            aux1 =  null;
        }

        public void remove()
        {
            int elemento = sentinela.elemento;
            Indica aux = sentinela;
            sentinela = sentinela.prox;
            aux = null;
        }
    }
}
