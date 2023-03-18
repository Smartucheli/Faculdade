using System;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ndigitado;
            Console.WriteLine("Digite um valor qualquer: ");
            Ndigitado = int.Parse(Console.ReadLine());
            if(primo(Ndigitado) == 1){
                Console.WriteLine("{0} é um numero primo: ", Ndigitado);
            } else {
                Console.WriteLine("{0} não é primo", Ndigitado);
            }

            
            
        }

        static int primo(int n){
            int cont = 0;
            for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                cont++;
            }
        }
        return cont;
    }
}
}
