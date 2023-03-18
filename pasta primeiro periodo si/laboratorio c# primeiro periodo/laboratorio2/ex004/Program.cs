using System;

namespace ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            int Bmaior, Bmenor, Altura, Area;
            Console.WriteLine("esse programa ira calcular a area de um trapezio de Base maior 10, Base menor 5, e altura 2.");
            Bmaior = 10;
            Bmenor = 5;
            Altura = 2;
            Area = (Bmaior - Bmenor)*Altura/2;
            Console.WriteLine("A area desse trapezio é de: " + Area);
        }
    }
}
