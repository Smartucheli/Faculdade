using System;

namespace ex006_B
{
    class Program
    {
        static void Main(string[] args)
        {
            double cima, baixo, conta = 0;
            for(cima = 21, baixo = 250; baixo >= 21; cima++, baixo--){
                conta = conta + cima/baixo;
            }
            Console.WriteLine(conta);
        }
    }
}

// cima <= 250 = 448,2955455102913
//baixo >= 21 = 448,2955455102913