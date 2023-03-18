namespace arvore
{
    internal class Program
    {
        class Nodo
        {
            public Nodo pai = null;
            public Nodo fDireito = null;
            public Nodo fEquerdo = null;
            public int valorNodo;
        }

        class Arvore
        {
            public void inserir(int valor, Nodo nodo)
            {
                if (valor > nodo.valorNodo)
                {
                    if (nodo.fDireito == null)
                    {
                        Nodo filho = new Nodo();
                        filho.pai = nodo;
                        filho.valorNodo = valor;
                        nodo.fDireito = filho;
                    }
                    else
                    {
                        inserir(valor, nodo.fDireito);
                    }
                }
                else
                {
                    if (nodo.fEquerdo == null)
                    {
                        Nodo filho = new Nodo();
                        filho.pai = nodo;
                        filho.valorNodo = valor;
                        nodo.fEquerdo = filho;
                    }
                    else
                    {
                        inserir(valor, nodo.fEquerdo);
                    }
                }
            }
            static void Main(string[] args)
            {
                            
            }

    }
}