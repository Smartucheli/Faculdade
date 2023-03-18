using System;

namespace ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, menor, maior, cont, soma = 0;
            Console.WriteLine("Digite 2 valores: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            if (n1 < n2) {
                menor = n1;
                maior = n2;
            } else {
                menor = n2;
                maior = n1;
            }
            for(cont = menor + 1; cont < maior; cont++){
                if(cont % 2 != 0){
                    soma += cont;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
