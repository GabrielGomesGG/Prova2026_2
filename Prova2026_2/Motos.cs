// Questão 01
public class Motos: Veiculos
{
    public int cilidradas {  get; set; }
    public string partidaEletrica { get; set; }
    public int peso { get; set; }
    public int capacidadeTanque {  get; set; }

    public Motos(int id, string descricao, string nomeMarca, string anoFabricacao, double valorAluguel, int cilidradas, string partidaEletrica, int peso, int capacidadeTanque):base(id, descricao, nomeMarca, anoFabricacao, valorAluguel)
    {
        this.cilidradas = cilidradas;
        this.partidaEletrica = partidaEletrica;
        this.peso = peso;
        this.capacidadeTanque = capacidadeTanque;
    }





    // Questão 03
    public override double calcularAluguel(int quantidadeDias)
    {
        if (quantidadeDias > 5)
        {
            double valorTotal = (quantidadeDias * valorDiaria) * 0.85;
            return valorTotal;
        }
        else
            return base.calcularAluguel(quantidadeDias);
    }
}