int[] pilha = new int[5];
int[] pilha2 = new int[5];
int pos1 = 5;
char op;


insere(pilha, pos1);

Console.Write("Pilha 1 -> ");
imprimeVet(pilha);

Console.Write("Pilha 2 -> ");
imprimeVet(pilha2);

Console.WriteLine("Deseja transferir para a segunda pilha? ");
Console.WriteLine("Se sim digite S se não digite N ");
op = char.Parse(Console.ReadLine());

if (op == 'S')
{
    for(int i = 0; i < pilha.Length; i++){
        pilha2[i] = pilha[i];
    }
    Console.Write("Pilha1 -> ");
    imprimeVet(pilha);
    Console.Write("Pilha2 -> ");
    imprimeVet(pilha2);
}
else
{
    Console.WriteLine("Ate mais!!!");
}




static void insere(int[] pilha, int aux)
{
    Random rnd = new Random();
    for (int i = 0; i < aux; i++)
    {
        pilha[i] = rnd.Next(0, 10);
    }
}


static void imprimeVet(int[] vet)
{
    for (int i = 0; i < vet.Length; i++)
    {
        Console.Write("\t" + vet[i]);
    }
    Console.WriteLine();
}
