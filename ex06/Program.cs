using System;
using System.Collections.Generic;

class Produto
{
    static void Main()
    {
        List<Cliente> clientes = new List<Cliente>();
        bool rodando = true;

        while (rodando)
        {
            Console.WriteLine("=== MENU DE OPÇÕES ===");
            Console.WriteLine(" 1. Cadastrar Cliente");
            Console.WriteLine(" 2. Listar Clientes");
            Console.WriteLine(" 3. Buscar Cliente");
            Console.WriteLine(" 4. Remover Cliente");
            Console.WriteLine(" 5. Sair");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Cliente c = new Cliente(); 

                    Console.Write("Nome Cliente: ");
                    c.Nome = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(c.Nome)) 
                    {
                        Console.WriteLine("Nome de cliente não permitido!");
                        break;
                    }

                    Console.Write("Telefone: ");
                    c.Telefone = Console.ReadLine();

                    Console.Write("Cidade: ");
                    c.Cidade = Console.ReadLine();

                    clientes.Add(c);
                    Console.WriteLine("Cliente cadastrado com sucesso!");
                    break;

                case 2:
                    if (clientes.Count == 0) 
                    {
                        Console.WriteLine(" Nenhum Cliente Cadastrado!");
                        break;
                    }

                    Console.WriteLine(" ===== Lista Clientes =====");
                    foreach (Cliente cliente in clientes) 
                    {
                        Console.WriteLine($"Cliente: {cliente.Nome.PadRight(5)} Telefone: {cliente.Telefone.PadLeft(5)} Cidade: {cliente.Cidade.PadLeft(5)}");
                    }
                    break;

                case 3:
                    if (clientes.Count == 0) 
                    {
                        Console.WriteLine(" Nenhum Cliente Cadastrado!");
                        break;
                    }

                    Console.Write("Buscar Cliente: ");
                    string buscar = Console.ReadLine();

                    Cliente encontrado = clientes.Find(x => x.Nome.Equals(buscar, StringComparison.OrdinalIgnoreCase));

                    if (encontrado != null)
                    {
                        Console.WriteLine($"Cliente: {encontrado.Nome.PadRight(5)} Telefone: {encontrado.Telefone.PadRight(5)} Cidade: {encontrado.Cidade.PadRight(5)}");
                    }
                    else
                    {
                        Console.WriteLine("Cliente não encontrado!");
                    }
                    break;

                case 4:
                    if (clientes.Count == 0) 
                    {
                        Console.WriteLine(" Nenhum Cliente Cadastrado!");
                        break;
                    }

                    Console.Write("Remover Cliente: ");
                    string remover = Console.ReadLine();

                    Cliente aRemover = clientes.Find(x => x.Nome.Equals(remover, StringComparison.OrdinalIgnoreCase));

                    if (aRemover != null)
                    {
                        clientes.Remove(aRemover);
                        Console.WriteLine($"Cliente {aRemover.Nome} removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Cliente não encontrado!");
                    }
                    break;

                case 5:
                    Console.WriteLine("Saindo...");
                    rodando = false;
                    break;

                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }
    }
}

class Cliente
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Cidade { get; set; }
}