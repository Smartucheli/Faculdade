internal class harley : moto {
    protected string cor;
    protected string modelo; 

    protected int potencia;

    public harley(string placa, int documento, string dono): base(placa, documento, dono){
        cor = "cinza";
        modelo = "Exterminador do futuro";
        potencia = 300;
        tamanho = Tamanho.grande;
        cilindrada = Cilindrada.media;
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nCor: {cor}\nModelo: {modelo}\nPotencia: {potencia}";
    }
}