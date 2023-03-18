using System;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1, soma = 0;
            while(cont <= 1000){
                if(cont % 2 == 0){
                 soma += cont;
                 cont++;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
