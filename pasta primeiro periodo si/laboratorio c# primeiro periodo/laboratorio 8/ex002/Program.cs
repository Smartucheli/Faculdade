using System;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um valor: ");
            numero = int.Parse(Console.ReadLine());
            primo(numero);
        }

        static int primo(int x){
            int i, resultado = 0;
            for(i = 2; i <= x / 2; i++){
                if(x % i == 0)
                resultado++;
            }
            if(resultado == 0)
            Console.WriteLine("1");
            else{
                Console.WriteLine("0");
            }
            return resultado;
    }

    }
}
