using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fila_dinamica
{
    public class fila
    {
        private divs primeiro, ultimo, aux;
        class divs
        {
            public string elementos;
            public divs proximo;
        }

        public fila()
        {
            this.primeiro = new divs();
            this.primeiro.elementos = null;
            this.primeiro.proximo = null;
            this.ultimo = this.primeiro;
        }

        public void insere(string elementos)
        {
            if(this.primeiro.proximo == this.ultimo)
            {
                this.ultimo = this.primeiro.proximo; 
            }

            divs New = new divs();
            this.ultimo.proximo = New;
            New.elementos = elementos;
            New.proximo = null;
            this.ultimo = New;
        }


        public void remove()
        {
            if(this.primeiro.proximo.proximo == null)
            {
                Console.WriteLine("Fila vazia");
            } else
            {
                while(this.aux != null)
                {
                    if(this.aux.proximo == this.ultimo)
                    {
                        Console.WriteLine("Fila cheia");
                    }
                    this.aux = this.aux.proximo;
                }
            }
        }

        public void ImprimeFila()
        {
            this.aux = this.primeiro.proximo;

            Console.WriteLine("Itens da Fila:");

            while (this.aux != null)
            {
                Console.Write($"{this.aux.elementos} | ");
                this.aux = this.aux.proximo;
            }

            Console.WriteLine(" ");
            
        }

    }  
}
