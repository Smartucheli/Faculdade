using System;

namespace ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = 0, mes = 0, dia = 0, Dcorridos;
            Console.WriteLine("Digite os dias corridos: ");
            Dcorridos = int.Parse(Console.ReadLine());
            dias_converte(Dcorridos, ref ano, ref dia, ref mes);
            Console.WriteLine("Se passaram {0} Anos {1} meses {2} dias", ano, mes, dia);
        }

        static void dias_converte(int Dcorridos, ref int ano, ref int dia, ref int mes ){
            ano = Dcorridos/365;
            mes = (Dcorridos%365)/30;
            dia = (Dcorridos%365)%30;
        }
    }
}
