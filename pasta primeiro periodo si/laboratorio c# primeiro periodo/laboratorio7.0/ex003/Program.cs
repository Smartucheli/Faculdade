using System;

namespace ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, grau = 0;
            for (i = 0; i <= 360; i += 15)
            {
                grau = (Math.PI * i) / 180;
                Console.WriteLine("Sen = {0} \t cos = {1}", Math.Sin(grau), Math.Cos(grau));
            }
        }
    }
}