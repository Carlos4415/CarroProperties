class Carro
{
    private int ano;
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public int Ano { 
        get => ano; 
        set
        {
            if (value < 1960 || value > 2025)
            {
                Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2023");
            }
            else
            {
                ano = value;
            }
        }
    }
    public int QuantidadePortas { get; set; }
    public int Velocidade { get; set; } = 0;
    public string DescricaoDetalhada => $"Modelo do carro: {this.Fabricante} {this.Modelo} {this.Ano}";

    public void exibirInformacoes()
    {
        Console.WriteLine($"\nInformações do carro: {this.Fabricante} {this.Modelo}, {this.QuantidadePortas} portas, {this.Ano}");
    }

    public void acelerar()
    {
        Console.WriteLine("\nAcelerando...");

        if (Velocidade < 100)
        {
            Velocidade = Velocidade + 5;
        }
    }

    public void frear()
    {
        Console.WriteLine("\nFreando...");

        if (Velocidade > 0)
        {
            Velocidade = Velocidade - 5;
        }
    }

    public void buzinar()
    {
        Console.WriteLine("\nBi Bi");
    }
}
