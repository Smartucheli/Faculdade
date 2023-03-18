using System;

namespace ex001
{
    class Program
    {

        static int le_no_intervalo(int a, int b)
        {
            int ler = 0;
            do
            {
                ler = int.Parse(Console.ReadLine());
            } while (ler <= a || ler >= b);
            return ler;
        }

        static void Main(String[] args)
        {
            int dia, mes;
            Console.WriteLine("Informe o dia entre 1 e 31: ");
            dia = le_no_intervalo(1, 31);
            Console.WriteLine("Informe o mes entre 1 e 12: ");
            mes = le_no_intervalo(1, 12);
            Console.WriteLine("Data: {0}/{1}", dia, mes);
        }
    }
}
