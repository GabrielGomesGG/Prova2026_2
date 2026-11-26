// Questão 01
public class Carros: Veiculos
{
    public int quantidadePortas {  get; set; }
    public int tamanhoBagageiro { get; set; }

    public Carros(int id, string descricao, string nomeMarca, string anoFabricacao, double valorAluguel, int quantidadePortas, int tamanhoBagageiro): base(id, descricao, nomeMarca, anoFabricacao, valorAluguel)
    {
        this.quantidadePortas = quantidadePortas;
        this.tamanhoBagageiro = tamanhoBagageiro;
    }



    // Questão 03
    public override double calcularAluguel(int quantidadeDias)
    {
        if (quantidadeDias > 7)
        {
            double valorTotal = (quantidadeDias * valorDiaria) * 0.90;
            return valorTotal;
        }
        else
            return base.calcularAluguel(quantidadeDias);
    }
}