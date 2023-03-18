int [] lista1 = new int[5];
int [] lista2 = new int[5];
int []listas_juntas = new int[10];
int i = 0, j = 0;


int ref1 = 5, ref2 = 5;
insere(ref lista1, ref1);
Console.Write("Lista1 -> ");
imprimeVet(lista1);
insere(ref lista2, ref2);
Console.Write("Lista2 -> ");
imprimeVet(lista2);



for(i = 0; j < listas_juntas.Length; i = (++i % lista1.Length)){
    if(j < lista1.Length){
        listas_juntas[j] = lista1[i];
    } else {
        listas_juntas[j] = lista2[i];
    }

    j++;
}

Console.Write("Listas Juntas");
imprimeVet(listas_juntas);

static void insere(ref int[] lista, int aux)
{
    Random rnd = new Random();
    for (int i = 0; i < aux; i++)
    {
        lista[i] = rnd.Next(0, 10);
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