using System;

class Program
{
    static void Main()
    {
        IDesconto desconto = new DescontoClienteComum();
        decimal resultado = desconto.Calcular(100);

        IDesconto desconto1 = new DescontoClienteVip();
        decimal resultado1 = desconto1.Calcular(100);

        Console.WriteLine($"Preço Normal: {100:C2}");
        Console.WriteLine($"Cliente Normal: {resultado:C2}");
        Console.WriteLine($"Cliente Vip: {resultado1:C2}");
    }
}

interface IDesconto
{
    public decimal Calcular(decimal valor);
}

class DescontoClienteComum : IDesconto
{
    public decimal Calcular(decimal valor)
    {
        return valor * 0.95m;
    }
}

class DescontoClienteVip : IDesconto
{
    public decimal Calcular(decimal valor)
    {
        return valor * 0.90m;
    }
}
