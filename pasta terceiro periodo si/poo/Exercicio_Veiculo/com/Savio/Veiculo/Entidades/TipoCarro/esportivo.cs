internal class Esportivo : carro {
    protected string cor;
    protected string modelo;
    protected bool ar_cond;
    protected bool radio;
    protected cavalo cavalos;
    protected Tipo_combustivel tipo_comb;

    public Esportivo(string placa, int documento, string dono): base(placa, documento, dono){
        cor = "Branco";
        modelo = "porshe";
        ar_cond = true;
        radio = true;
        cavalos = cavalo.muito;
        tipo_comb = Tipo_combustivel.aditivada;
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nCor: {cor}\nModelo: {modelo}\nAr_condicionado: {ar_cond}\nradio: {radio}\nCavalos: {cavalos}\nTipo_combustivel {tipo_comb}";
    }

}