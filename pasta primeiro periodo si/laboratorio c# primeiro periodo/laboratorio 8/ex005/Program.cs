using System;

namespace ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;
            Console.WriteLine("Digite um dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um ano: ");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine("A quantidade de dias é {0}", receba(dia, mes, ano));
        }


        static int receba(int d, int m, int ano){
            int QuantDias = d;
            if(m == 02)
                QuantDias += 31;
            else if(m == 03)
                QuantDias += 31 + 30;
            else if(m == 04)
                QuantDias += 31 + 30 + 31;
            else if(m == 05)
                QuantDias += 31 + 30 + 31 + 30;
            else if(m == 06)
                QuantDias += 31 + 30 + 31 + 30 + 31;
            else if(m == 07)
                QuantDias += 31 + 30 + 31 + 30 + 31 + 30;
            else if(m == 08)
                QuantDias += 31 + 30 + 31 + 30 + 31 + 31 ;
            else if(m == 09)
                QuantDias += 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
            else if(m == 10)
                QuantDias += 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30;
            else if(m == 11)
                QuantDias += 31 + 30 + 31 + 30 + 31 + 31 + 30 +31 + 30 + 31;
            else if(m == 12)
                QuantDias += 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30 + 31;
        
        QuantDias += ano * 365;
        return QuantDias;
    }
    }
}

