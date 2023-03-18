static void shiftEsq(int[]vet, int esquerda, int direita){
    for(int i = esquerda; i <= direita; i++){
        vet[i - 1] = vet[i]; 
    }
}

static void insere(int []vet, int aux, ref int pos){
    vet[pos] = aux;
    pos++;
}

static int tira (int []vet, ref int pos){
    int aux = vet[0];
    shiftEsq(vet, 1, pos-1);
    pos--;
    return aux;
}

static void imprimeVetor(int[] vet,ref int pos){
    int aux;
    for(int i = pos; i > 0; i--){
        aux = tira(vet, ref pos);
        Console.Write(aux + "\t");
        insere(vet, aux, ref pos);
     }
}

int pos = 0;
int num = 1;
int []vet = new int[5];
Console.Write("Fila de tamanho 5 -> ");
Console.Write("Escolha qual operação deseja fazer ");
while(num >= 1 && num <= 4){
    int NumMenu;
    Console.WriteLine("\n 1 - insere, 2 - tira um numero da fila, 3 - imprime a fila, 4 - sair");
    NumMenu = int.Parse(Console.ReadLine());


    if(NumMenu == 1){
        int NumeroEscolhido;
        Console.Write("digite um numero para ser inserido: ");
        NumeroEscolhido = int.Parse(Console.ReadLine());
        insere(vet, NumeroEscolhido, ref pos);
    }

    else if(NumMenu == 2){
        Console.WriteLine("O Primeiro valor sera removido.");
        tira(vet, ref pos);
    }
    else if(NumMenu == 3){
        Console.Write("Mostrando a fila no atual momento: ");
        imprimeVetor(vet, ref pos);
    } 

    else{
        break;
    }
}
