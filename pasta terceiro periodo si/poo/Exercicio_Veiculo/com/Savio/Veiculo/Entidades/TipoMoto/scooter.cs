internal class scooter : moto {
    protected string cor;
    protected string modelo;
    protected int potencia;

    public scooter(string placa, int documento, string dono): base (placa, documento, dono){
        cor = "preta";
        modelo = "Honda ADV";
        potencia = 150;
        tamanho = Tamanho.pequena;
        cilindrada = Cilindrada.pouca;
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nCor: {cor}\nModelo: {modelo}\nPotencia: {potencia}";
    }
}