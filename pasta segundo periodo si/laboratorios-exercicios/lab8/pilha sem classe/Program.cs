int pos = 0;
int num = 1;
int[] vet = new int[5];
Console.Write("Fila de tamanho 5 -> ");
Console.Write("Escolha qual operação deseja fazer ");
while (num >= 1 && num <= 4)
{
    int NumMenu;
    Console.WriteLine("\n 1 - insere, 2 - tira um numero da pilha, 3 - imprime a pilha, 4 - sair");
    NumMenu = int.Parse(Console.ReadLine());
    if (NumMenu == 1){
        int NumeroEscolhido;
        Console.Write("digite um numero para ser inserido: ");
        NumeroEscolhido = int.Parse(Console.ReadLine());
        insere(vet, NumeroEscolhido, ref pos);
    }
    else if (NumMenu == 2){
        Console.WriteLine("O ultimo valor sera removido.");
        tira(vet, ref pos);
    }
    else if (NumMenu == 3){
        Console.Write("Mostrando a pilha no atual momento: ");
        imprimeVetor(vet, ref pos);
    }
    else{
        break;
    }
}

static void shift_dir(int[] vet, int esquerda, int direita)
{
    for (int i = esquerda; i <= direita; i++)
    {
        vet[i + 1] = vet[i];
    }
}
static void insere(int[] vet, int aux, ref int pos)
{
    vet[pos] = aux;
    pos++;
}
static int[] tira(int[] vet, ref int pos)
{
    int aux = vet[pos];
    shift_dir(vet, pos, 0);
    pos--;
    return vet;
}
static void imprimeVetor(int[] vet, ref int pos)
{
    for (int i = 0; i < pos; i++)
    {
        Console.Write(vet[i] + "\t");
        //insere(vet, aux, ref pos);
    }
}
