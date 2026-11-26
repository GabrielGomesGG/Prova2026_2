// Questão 07

try
{
    Carros c = new Carros(1, "Passeio", "JEEP", "2026", 250, 4, 450);
    Motos m = new Motos(2, "esportiva", "Yamaha", "2026", 100, 600, "Sim", 800, 50);
    Caminhoes cm = new Caminhoes(3, "Transporte", "Mercedez-Benz", "2023", 500, 9, 5000, "Extendida", 25, 4);

    Aluguel a = new Aluguel(4, "Transporte", "Mercedez-Benz", "2023", 500, c, new DateOnly(2026,10,25), new DateOnly(2026,11,25));

    

    Console.WriteLine(c.GetValorDiaria());
}
catch(Exception ex)
{
    Console.WriteLine("Dados Inválidos");
}