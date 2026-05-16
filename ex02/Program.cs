using System;

class Pagamento
{
    public string NomeCliente { get; set; }
    public double Valor { get; set; }
    public string Aviso { get; set; }

    public void ReceberDados()
    {
        Console.Write("Nome: ");
        NomeCliente = Console.ReadLine();

        Console.Write("Valor Pagamento: ");
        Valor = double.Parse(Console.ReadLine());
    }

        public virtual void ProcessarPagamento()
    {
        Aviso = "Pagamento Processado!";
    }

    public virtual void MostrarPagamento()
    {
        Console.WriteLine("Nome: " + NomeCliente);
        Console.WriteLine("Valor: " + Valor);
    }
}

class PagamentoPix : Pagamento
{
    public string ChavePix { get; set; } 

    public void ReceberDadosPix() 
    {
        base.ReceberDados(); 

        Console.Write("Chave Pix: ");
        ChavePix = Console.ReadLine();
    }

    public override void ProcessarPagamento() 
    {
        Aviso = "Pagamento via Pix aprovado instantaneamente!";
    }

    public override void MostrarPagamento()
    {
        Console.WriteLine("Nome: " + NomeCliente);
        Console.WriteLine("Valor: " + Valor);
        Console.WriteLine("Chave Pix: " + ChavePix);
        Console.WriteLine(Aviso);
    }
}

class PagamentoCartaoCredito : Pagamento 
{
    public int QuantidadeParcelas { get; set; }
    public double ValorParcela { get; set; }

    public void ReceberDadosCartao()
    {
        base.ReceberDados(); 

        Console.Write("Quantidade de Parcelas: ");
        QuantidadeParcelas = int.Parse(Console.ReadLine());

        if (QuantidadeParcelas <= 0)
            QuantidadeParcelas = 1;
    }

    public override void ProcessarPagamento() 
    {
        ValorParcela = Valor / QuantidadeParcelas;
        Aviso = "Pagamento aprovado no cartão!";
    }

    public override void MostrarPagamento()
    {
        Console.WriteLine("Nome: " + NomeCliente);
        Console.WriteLine("Valor Total: " + Valor);
        Console.WriteLine("Quantidade de Parcelas: " + QuantidadeParcelas);
        Console.WriteLine("Valor Parcela: " + ValorParcela);
        Console.WriteLine(Aviso);
    }
}

class Program
{
    static void Main()
    {
        PagamentoPix p1 = new PagamentoPix();

        Console.WriteLine("===================================");
        Console.WriteLine("            PAGAMENTO PIX");
        Console.WriteLine("===================================");

        p1.ReceberDadosPix(); // nome correto
        Console.WriteLine("===================================");

        p1.ProcessarPagamento();
        p1.MostrarPagamento();
        Console.WriteLine("===================================\n");

        PagamentoCartaoCredito p2 = new PagamentoCartaoCredito(); 

        Console.WriteLine("===================================");
        Console.WriteLine("        CARTÃO DE CRÉDITO");
        Console.WriteLine("===================================");

        p2.ReceberDadosCartao();
        Console.WriteLine("===================================");

        p2.ProcessarPagamento();
        p2.MostrarPagamento();
        Console.WriteLine("===================================");
    }
}