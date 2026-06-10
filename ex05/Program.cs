using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Produto> produtos = new List<Produto>();

        for (int i = 0; i < 4; i++)
        {
            Produto p = new Produto();

            Console.Write($"Produto {i + 1}: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());

            produtos.Add(p);
            
        }

        Console.WriteLine("\n--- Produtos Cadastrados ---");
        double total = 0;

        foreach(Produto p in produtos)
        {
            Console.WriteLine($"Produto: {p.Nome} \nR${p.Preco:F2}");
            total += p.Preco;
        }

        Console.WriteLine($"\nValor Total: {total:F2}");
    }
}

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set;}

}