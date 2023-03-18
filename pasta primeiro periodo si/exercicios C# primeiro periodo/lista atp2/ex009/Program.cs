using System;

namespace ex009
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, soma = 0, i;
            Console.WriteLine("Digite dois números: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if(x < y){
            for(i = x; i <= y; i++){
                if(i % 13 != 0){
                    soma+= i;
                }
            }
        } else{
            for(i = y; i <= x; i++){
                if(i % 13 != 0){
                    soma+= i;
                }
        }
        }
        Console.WriteLine(soma);
    }
}
}
