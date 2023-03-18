using System;

namespace ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            int h1, m1, s1;
            Console.WriteLine("Digite um horario: ");
            h1 = int.Parse(Console.ReadLine());
            m1 = int.Parse(Console.ReadLine());
            s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tempo em segundos é igual a = {0}", Converte_Segundo(h1, m1, s1));
        }

        static int Converte_Segundo(int h, int m, int s){
            return h*3600+m*60+s;
        }
    }
}
