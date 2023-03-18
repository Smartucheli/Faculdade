using static System.Net.Mime.MediaTypeNames;

namespace fila_dinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            fila fila1 = new fila();


            do
            {
                Console.WriteLine("Digite a opção desejada: ");
                Console.Write("(1) para inserir\n(2) para retirar\n(3) para imprimir a fila (4) para sair \n\nInsira aqui a opção: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Console.Write("Insira o nome que deseja inserir: ");
                            string nome = Console.ReadLine();
                            fila1.insere(nome);
                            fila1.ImprimeFila();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Removendo");
                            fila1.remove();
                            fila1.ImprimeFila();
                            break;
                        }
                    case 3:
                        {
                            fila1.ImprimeFila();
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Ate mais");
                            break;
                        }
                }

            }
        }
    }
}