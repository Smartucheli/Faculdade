class conta_premium{

    public static void Conta_Premium(){
        Gerente gerente1 = new Gerente("Gerente", 120);
        Console.WriteLine("Qual a importancia da sua conta");
        Console.WriteLine("conta normal - 1/ conta especial - 2");
        int importancia = int.Parse(Console.ReadLine());
        Conta conta1 = new Conta("Savio", 15698766390, importancia);
        Qual_gerente(gerente1, importancia);
    }


    public static void Qual_gerente(Gerente nome, int importancia){
        if(importancia == 1){
            Console.WriteLine("Sua conta não precisa de gerente");
        } else {
            Console.WriteLine("Voce tem uma conta premium, que tem como gerente o: {0}", nome.Nome);
        }
    }
}