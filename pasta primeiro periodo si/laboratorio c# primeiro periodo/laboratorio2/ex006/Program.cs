using System;

namespace ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            double cateto1, cateto2, SomaCatetos, hipotenusa;
            Console.WriteLine("digite dois catetos de um triangulo: ");
            cateto1 = double.Parse(Console.ReadLine());
            cateto2 = double.Parse(Console.ReadLine());
            SomaCatetos = Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2);
            hipotenusa = Math.Sqrt(SomaCatetos);
            Console.WriteLine("O valor da hipotenusa do triangulo é de: " + hipotenusa);
        }
    }
}
