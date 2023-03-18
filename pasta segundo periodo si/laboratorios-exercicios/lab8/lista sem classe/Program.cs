Console.WriteLine("Bem vindo a sua lista de tamanho 5");
int pos = 0;
int num = 1;
int[] vet = new int[5];

Console.WriteLine("Escolha qual operação deseja fazer");
while (num >= 1 && num <= 4)
{
    int num_escolhido;
    Console.WriteLine("1 - insere um numero, 2 - tira um numero, 3 - imprime a lista, 4 - sair");
    num_escolhido = int.Parse(Console.ReadLine());

    if (num_escolhido == 1)
    {
        Console.WriteLine("Digite a posição que o valor deve ser inserido: ");
        pos = int.Parse(Console.ReadLine());
        if (pos > vet.Length || pos < 0)
        {
            Console.WriteLine("Essa posição não existe");
            Console.WriteLine("Tente executar o programa novamente");
            break;
        }
        insere(vet, ref pos);

    }
    else if (num_escolhido == 2)
    {
        remove_lista(vet, ref pos);
        Console.WriteLine("Seu valor foi removido.");
    }
    else if (num_escolhido == 3)
    {
        Console.WriteLine("Seu vetor esta assim: ");
        imprime(vet);
    }
    else
    {
        break;
    }
}


static void insere(int[] vet, ref int Ref)
{
    Console.WriteLine("Qual o valor deseja inserir: ");
    if (vet[Ref] != 0)
    {
        shift_dir(vet, 0, Ref);
        vet[Ref] = int.Parse(Console.ReadLine());
    }
    else
    {
        vet[Ref] = int.Parse(Console.ReadLine());
    }

}


static void imprime(int[] vet)
{
    for (int i = 0; i < vet.Length; i++)
    {
        Console.Write("\t" + vet[i]);
    }
    Console.WriteLine();
}


static void shift_dir(int[] vet, int esquerda, int direita)
{
    for (int i = esquerda; i <= direita; i++)
    {
        vet[i + 1] = vet[i];
    }
}


static void remove_lista(int[] vet, ref int Ref)
{
    Console.Write("Selecione a posição que deseja remover: ");
    int rem = int.Parse(Console.ReadLine());
    if (rem < 1 || rem > Ref)
    {
        Console.WriteLine("Valor invalido!");
    }
    int auxR = vet[rem - 1];
    for (int i = rem - 1; i < vet.Length - 1; i++)
    {
        vet[i] = vet[i + 1];
    }
    Ref--;
}
