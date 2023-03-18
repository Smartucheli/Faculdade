// Fila pra FIla inversa 
int[] fila = new int[5] {1,2,3,4,5};
int[] novaFila = new int[fila.Length];

Console.WriteLine("Fila");
Imprime(fila);

novaFila = Copia_e_inverte(fila, fila.Length);

Console.WriteLine("");
Console.WriteLine("Fila invertida");
Imprime(novaFila);

static int remove_fila(int[] vet){
    int aux = vet[0]; 
    for(int i=0; i<vet.Length-1; i++) 
        vet[i] = vet[i+1];
    
    return aux;
}

static int remove_pilha(int[] vet, ref int pos){
    pos--; 
    return vet[pos];
}

static void Insere(int[] vet, ref int pos, int num){
    vet[pos] = num;
    pos++;
}

static int[] Copia_e_inverte(int[] vet, int pos){
    int[] pilha = new int[pos];
    int[] aux = new int[pos];

    int i = 0;
    while(i < vet.Length)
        Insere(pilha, ref i, remove_fila(vet));

    
    int j = 0;
    while(j < vet.Length)
        Insere(aux, ref j, remove_pilha(pilha, ref pos));

    return aux;
}

static void Imprime(int[] Vetor){
    for(int i=0; i<Vetor.Length; i++){
        Console.Write(Vetor[i] + " ");
    }
}
