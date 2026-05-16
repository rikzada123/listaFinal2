using System;

class Veiculo
{
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public double ValorBaseManutencao { get; set; }
    public double CustoManutencao { get; set; }

    public void ReceberDados()
    {
        Console.Write("Digite o modelo: ");
        Modelo = Console.ReadLine();

        Console.Write("Digite o ano: ");
        Ano = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor base de manutenção: ");
        ValorBaseManutencao = double.Parse(Console.ReadLine());
    }

    public virtual double CalcularCustoManutencao()
    {
        return CustoManutencao = ValorBaseManutencao;
    }

    public virtual void MostrarDados()
    {
        System.Console.WriteLine("MODELO: " + Modelo);
        System.Console.WriteLine("ANO: " + Ano);
        System.Console.WriteLine("VALOR MANUTENÇÃO: " + CustoManutencao);
    }
}

class Carro : Veiculo
{
    public int QuantidadePortas { get; set; }

    public void ReceberDadosCarro()
    {
        base.ReceberDados();

        Console.Write("Quantidade de Portas: ");
        QuantidadePortas = int.Parse(Console.ReadLine());
    }

    public override double CalcularCustoManutencao()
    {
        return CustoManutencao = ValorBaseManutencao + 200;
    }

    public override void MostrarDados()
    {
        base.MostrarDados();
        System.Console.WriteLine("QUANTIDADE DE PORTAS: " + QuantidadePortas);
    }   
}

class Moto : Veiculo
{
    public double Cilindradas { get; set; }

    public void ReceberDadosMoto()
    {
        base.ReceberDados();

        Console.Write("Digite quantidade de Cilindradas: ");
        Cilindradas = double.Parse(Console.ReadLine());
    }

    public override double CalcularCustoManutencao()
    {
        return CustoManutencao = ValorBaseManutencao + 100;
    }

    public override void MostrarDados()
    {
        base.MostrarDados();
        
        System.Console.WriteLine("CILINDRADAS: " + Cilindradas);
    }
}

class Caminhao : Veiculo
{
    public double CapacidadeCarga { get; set; }

    public void ReceberDadosCaminhao()
    {
        base.ReceberDados();

        Console.Write("Capacidade de carga: ");
        CapacidadeCarga = double.Parse(Console.ReadLine());
    }

    public override double CalcularCustoManutencao()
    {
        return CustoManutencao = ValorBaseManutencao + 500;
    }

    public override void MostrarDados()
    {
        base.MostrarDados();

        System.Console.WriteLine("CAPACIDADE CARGA: " + CapacidadeCarga);
    }
}

class Program
{
    static void Main()
    {
        System.Console.WriteLine("===============================");
        System.Console.WriteLine("          VEICULOS");
        System.Console.WriteLine("===============================");
        System.Console.WriteLine();
        
        Carro v1 = new Carro();

        System.Console.WriteLine("           CARRO");
        System.Console.WriteLine("===============================");

        v1.ReceberDadosCarro();
        v1.CalcularCustoManutencao();

        System.Console.WriteLine();
        v1.MostrarDados();

        System.Console.WriteLine("===============================");
        System.Console.WriteLine();

        Moto v2 = new Moto();

        System.Console.WriteLine("            MOTO");
        System.Console.WriteLine("===============================");

        v2.ReceberDadosMoto();
        v2.CalcularCustoManutencao();

        System.Console.WriteLine();
        v2.MostrarDados();

        System.Console.WriteLine("===============================");
        System.Console.WriteLine();
        
        Caminhao v3 = new Caminhao();

        System.Console.WriteLine("          CAMINHÃO");
        System.Console.WriteLine("===============================");

        v3.ReceberDadosCaminhao();
        v3.CalcularCustoManutencao();

        System.Console.WriteLine();
        v3.MostrarDados();
    }
}