using System;

class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public double SalarioBase { get; set; }
    public double SalarioFinal { get; set; }

    public void ReceberDados()
    {
        Console.Write("Funcionario(a): ");
        Nome = Console.ReadLine();

        Console.Write("Cargo: ");
        Cargo = Console.ReadLine();

        Console.Write("Salário Base: ");
        SalarioBase = double.Parse(Console.ReadLine());
        System.Console.WriteLine("==========================================");
        System.Console.WriteLine();
    }

    public virtual double CalcularSalarioFinal()
    {
        return SalarioBase;
    }

    public virtual void MostrarDados()
    {
        System.Console.WriteLine("Funcionario(a): " + Nome);
        System.Console.WriteLine("Cargo: " + Cargo);
        System.Console.WriteLine("Salario Final: " + SalarioBase);
        System.Console.WriteLine("==========================================");
        System.Console.WriteLine();
    }
}

class FuncionarioCLT : Funcionario
{
    public double Bonus { get; set; }

    public void ReceberDados()
    {
        Console.Write("Funcionario(a): ");
        Nome = Console.ReadLine();

        Console.Write("Cargo: ");
        Cargo = Console.ReadLine();

        Console.Write("Salário Base: ");
        SalarioBase = double.Parse(Console.ReadLine());

        Console.Write("Bonus: ");
        Bonus = double.Parse(Console.ReadLine());
        System.Console.WriteLine("==========================================");
        System.Console.WriteLine();
    }

    public override double CalcularSalarioFinal()
    {
        return SalarioFinal = SalarioBase + Bonus;
    }

    public override void MostrarDados()
    {
        System.Console.WriteLine("Funcionario(a): " + Nome);
        System.Console.WriteLine("Cargo: " + Cargo);
        System.Console.WriteLine("Salario Final: " + SalarioFinal);
        System.Console.WriteLine("==========================================");
        System.Console.WriteLine();
    }
}

class FuncionarioComissionado : Funcionario
{
    public double TotalDeVendas { get; set; }
    public double PercentualComissao = 10;

    public void ReceberDadosComissionado()
    {
        Console.Write("Funcionario(a): ");
        Nome = Console.ReadLine();

        Console.Write("Cargo: ");
        Cargo = Console.ReadLine();

        Console.Write("Salário Base: ");
        SalarioBase = double.Parse(Console.ReadLine());

        Console.Write("Total de Vendas: ");
        TotalDeVendas = double.Parse(Console.ReadLine());
        System.Console.WriteLine("==========================================");
        System.Console.WriteLine();
    }

    public override double CalcularSalarioFinal()
    {
        return SalarioFinal = SalarioBase + (TotalDeVendas * PercentualComissao / 100);
    }

    public override void MostrarDados()
    {
        System.Console.WriteLine("Funcionario(a): " + Nome);
        System.Console.WriteLine("Cargo: " + Cargo);
        System.Console.WriteLine("Salario Final: " + SalarioFinal);
        System.Console.WriteLine("==========================================");
        System.Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        FuncionarioCLT f1 = new FuncionarioCLT();

        f1.ReceberDados();
        f1.CalcularSalarioFinal();
        f1.MostrarDados();

        FuncionarioComissionado f2 = new FuncionarioComissionado();

        f2.ReceberDadosComissionado();
        f2.CalcularSalarioFinal();
        f2.MostrarDados();
    }
}