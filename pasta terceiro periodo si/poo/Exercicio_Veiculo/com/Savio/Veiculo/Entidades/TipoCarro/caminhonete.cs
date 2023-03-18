internal class Caminhonete : carro {
    protected string cor;
    protected string modelo;
    protected bool ar_cond;
    protected bool radio;
    protected cavalo cavalos;
    protected Tipo_combustivel tipo_comb;

    public Caminhonete(string placa, int documento, string dono): base(placa, documento, dono){
        cor = "preto";
        modelo = "hilux 2014";
        ar_cond = true;
        radio = true;
        cavalos = cavalo.medio;
        tipo_comb = Tipo_combustivel.gasolina;
    }
    public override string ToString()
    {
        return $"{base.ToString()} \nCor: {cor}\nModelo: {modelo}\nAr_condicionado: {ar_cond}\nradio: {radio}\nCavalos: {cavalos}\nTipo_combustivel {tipo_comb}";
    }
}