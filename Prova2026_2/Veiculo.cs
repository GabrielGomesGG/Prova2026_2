// Questão 01
public abstract class Veiculos
{
    public int ID { get; set; }
    public string descricao { get; set; }
    public string nomeMarca { get; set; }
    public string anoFabricacao { get; set; }
    protected double valorDiaria { get; set; }

    public Veiculos(int id, string descricao, string nomeMarca, string anoFabricacao, double valorAluguel)
    {
        this.ID = id;
        this.descricao = descricao;
        this.nomeMarca = nomeMarca;
        this.anoFabricacao = anoFabricacao;

        SetValorDiaria(valorAluguel);
    }



    // Questão 02
    public double GetValorDiaria()
    {
        return valorDiaria;
    }

    public void SetValorDiaria(double valorDiaria)
    {
        if (valorDiaria < 0)
            throw new Exception("O valor da diária deve ser igual ou maior que zero");
        else
            this.valorDiaria = valorDiaria;
    }

    // Questão 03
    public virtual double calcularAluguel(int quantidadeDias)
    {
        double valorAluguel = this.valorDiaria * quantidadeDias;

        return valorAluguel;
    }

}