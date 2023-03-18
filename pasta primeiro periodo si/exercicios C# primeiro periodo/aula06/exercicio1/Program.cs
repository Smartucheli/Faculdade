using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3;
            Console.WriteLine("Escreva 3 lados de triangulo");
            n1 =int.Parse(Console.ReadLine());
            n2 =int.Parse(Console.ReadLine());
            n3 =int.Parse(Console.ReadLine());
            if(n1+n2>=n3 && n2+n3>=n1 && n3+n1>=n2) {
                Console.WriteLine("é triangulo");
            }else {
               Console.WriteLine("Não é triangulo");
            }
        }
    }
}
