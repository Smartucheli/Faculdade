using System;

namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            int conceitoA = 0, conceitoB = 0, conceitoC = 0, conceitoD = 0, conceitoE = 0, nota;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Entre com a nota do aluno : ");
                nota = int.Parse(Console.ReadLine());
                if (nota >= 8)
                    conceitoA++;
                else if (nota >= 7)
                    conceitoB++;
                else if (nota >= 6)
                    conceitoC++;
                else if (nota >= 4)
                    conceitoD++;
                else
                    conceitoE++;
            }
            Console.Write("\nConceitos A: " + conceitoA);
            Console.Write("\nConceitos B: " + conceitoB);
            Console.Write("\nConceitos C: " + conceitoC);
            Console.Write("\nConceitos D: " + conceitoD);
            Console.Write("\nConceitos E: " + conceitoE);
        }
    }
}

