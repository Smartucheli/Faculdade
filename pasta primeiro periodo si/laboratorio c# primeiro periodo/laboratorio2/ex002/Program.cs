using System;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, MediaPond;
            Console.WriteLine("EScreva sua primeira e segunda nota: ");
            nota1 = int.Parse(Console.ReadLine());
            nota2 = int.Parse(Console.ReadLine());
            MediaPond = (nota1*2 + nota2*3)/2;
            Console.WriteLine("A media ponderada das notas é de: " + MediaPond);
        }
    }
}
