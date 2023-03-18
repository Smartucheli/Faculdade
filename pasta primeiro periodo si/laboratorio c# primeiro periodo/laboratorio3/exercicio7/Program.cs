using System;

namespace exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Digite 3 numeros: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            
            int soma;
            if(n3<n1 && n1>n2){
                soma = n1 + n2;
                Console.WriteLine("A soma dos maiores valores é: " + soma);
            } else if(n2<n1 && n3>n2){
                soma = n1+n3;
                Console.WriteLine("A soma dos maiores valores é: " + soma);
            } else {
                soma = n2+n3;
                Console.WriteLine("A soma dos maiores valores é: " + soma);
            }
            
        }
    }
}
