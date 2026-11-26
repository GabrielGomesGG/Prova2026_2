// Questão 04
public class Aluguel: Veiculos
{
    public Veiculos veiculo {  get; set; }
    public DateOnly dataInicio { get; set; }
    public DateOnly dataFim {  get; set; }
    public int totalDias { get; set; }
    public double valorTotalAluguel { get; set; }

    public double CalcularTotalAluguel(double valorDiaria)
    {
        valorTotalAluguel = veiculo.calcularAluguel(totalDias);

        return valorTotalAluguel;
    }

    //Questão 05
    public Aluguel(int id, string descricao, string nomeMarca, string anoFabricacao, double valorAluguel, Carros veiculo, DateOnly dataInicio, DateOnly dataFim) : base(id, descricao, nomeMarca, anoFabricacao, valorAluguel)
    {
        this.veiculo = veiculo;
        this.dataInicio = dataInicio;
        this.dataFim = dataFim;

        totalDias = (dataFim.DayNumber - dataInicio.DayNumber);

        // Questão 06

        if(dataInicio >= dataFim)
        {
            throw new Exception("A data de fim deve ser posterior a data de inicio, revise as datas informadas");
        }
    }
}