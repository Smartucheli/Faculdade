using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, pesoA = 3.5, pesoB = 7.5, media;
            Console.WriteLine("Digite 2 notas");
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            media = (pesoA*A + pesoB*B)/11;
            Console.WriteLine("MEDIA = {0, 1 :0.00000}", media); 
        }
    }
}
