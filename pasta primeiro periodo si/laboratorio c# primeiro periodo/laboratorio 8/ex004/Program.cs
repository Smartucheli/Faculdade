using System;

namespace ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos, h = 0 , m = 0, s = 0;
            Console.WriteLine("Digite um horario em segundo: ");
            segundos = int.Parse(Console.ReadLine());
            Converte_horas(segundos, ref  h, ref  m, ref  s);
            Console.WriteLine("As horas em segundos são: {0} e em horas são: {1}:{2}:{3}", segundos, h, m, s );
        }

        static void Converte_horas( int segs, ref int h, ref int m, ref int s){
            h = segs/3600;
            m = (segs%3600)/60;
            s = segs%60;
        }
    }
}
