using System;

namespace ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade,num, In = 0, Out = 0, cont;
            Console.WriteLine("Digite um valor: ");
            quantidade = int.Parse(Console.ReadLine());
            for(cont = 0; cont < quantidade; cont++){
                Console.WriteLine("Digite mais um valor: ");
                num = int.Parse(Console.ReadLine());
                if(num >= 10 && num <= 20){
                    In++;
                } else {
                    Out++;
                }
            }
            Console.WriteLine("{0} in", In);
            Console.WriteLine("{0} out", Out);
        }
    }
}
