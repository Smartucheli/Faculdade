internal class ninja : moto {
    protected string cor;
    protected string modelo;
    protected int potencia;

    public ninja (string placa, int documento, string dono) : base(placa, documento, dono){
        cor = "Verde";
        modelo = "Ninja ZX-10R";
        potencia = 500;
        tamanho = Tamanho.media;
        cilindrada = Cilindrada.muita;
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nCor: {cor}\nModelo: {modelo}\nPotencia: {potencia}";
    }
}