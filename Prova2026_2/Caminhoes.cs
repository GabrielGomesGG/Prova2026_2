// Questão 01
public class Caminhoes: Veiculos
{
    public int quantidadeEixos {  get; set; }
    public double capacidadeCarga { get; set; }
    public string tipoCarroceria { get; set; }
    public double comprimento { get; set; }
    public double altura {  get; set; }

    public Caminhoes(int id, string descricao, string nomeMarca, string anoFabricacao, double valorAluguel, int quantidadeEixos, double capacidadeCarga, string tipoCarroceria, double comprimento, double altura) : base(id, descricao, nomeMarca, anoFabricacao, valorAluguel)
    {
        this.quantidadeEixos = quantidadeEixos;
        this.capacidadeCarga = capacidadeCarga;
        this.tipoCarroceria = tipoCarroceria;
        this.comprimento = comprimento;
        this.altura = altura;
    }



    // Questão 03
    public override double calcularAluguel(int quantidadeDias)
    {
        if (capacidadeCarga > 10000)
        {
            double valorTotal = (quantidadeDias * valorDiaria);
            double valorAcrescimo = valorTotal * 1.2;
            
            return valorAcrescimo;
        }
        else
            return base.calcularAluguel(quantidadeDias);
    }
}