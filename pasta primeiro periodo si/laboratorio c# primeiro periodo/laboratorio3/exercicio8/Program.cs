using System;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, nota4, MediaArit;
            Console.WriteLine("Digite 4 notas de 0 a 100: ");
            nota1 = int.Parse(Console.ReadLine());
            nota2 = int.Parse(Console.ReadLine());
            nota3 = int.Parse(Console.ReadLine());
            nota4 = int.Parse(Console.ReadLine());
            MediaArit = (nota1+nota2+nota3+nota4)/4;
            if(MediaArit>=60){
                Console.WriteLine("O aluno esta aprovado!");
            } else {
                Console.WriteLine("O aluno esta reprovado!");
            }
        }
    }
}
