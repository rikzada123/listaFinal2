using System;
using System.Runtime.InteropServices;

class Aluno
{
    public string RA;
    public string Nome;
    public int Idade;

    public Aluno(string ra, string nome, int idade)
    {
        RA = ra;
        Nome = nome;
        Idade = idade;
    }
}

class Program
{
    static List<Aluno> alunos = new List<Aluno>();
    static void Main()
    {
        bool rodando = true;
        while (rodando)
        {
            System.Console.WriteLine("|===================================|");
            System.Console.WriteLine("|               MENU                |");
            System.Console.WriteLine("|===================================|");
            System.Console.WriteLine("|1. Cadastrar Aluno                 |");
            System.Console.WriteLine("|2. Listar Alunos                   |");
            System.Console.WriteLine("|3. Alterar Aluno                   |");
            System.Console.WriteLine("|4. Remover Aluno:                  |");
            System.Console.WriteLine("|0. Sair                            |");
            System.Console.WriteLine("|===================================|");
            System.Console.Write("Escolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1": Cadastrar(); break;
                case "2": Listar(); break;
                case "3": Alterar(); break;
                case "4": Remover(); break;
                case "0": rodando = false; System.Console.WriteLine("Saindo..."); break;
                default: System.Console.WriteLine("Opção invalida!"); break;
            }
        }
    }

    static void Cadastrar()
    {
        Console.Write("RA: ");
        string ra = Console.ReadLine();

        if (alunos.Exists(a => a.RA == ra))
        {
            System.Console.WriteLine("ERRO: Já existe um aluno com esse RA!");
            return;
        }

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        if (!int.TryParse(Console.ReadLine(), out int idade))
        {
            Console.WriteLine("Idade inválida!");
            return;
        }

        alunos.Add(new Aluno(ra, nome, idade));
        System.Console.WriteLine("Aluno cadastrado com sucesso!");
    }

    static void Listar()
    {
        if (alunos.Count == 0)
        {
            System.Console.WriteLine("Nenhum aluno cadastrado!");
            return;
        }

        else
        {
            System.Console.WriteLine($"  \n{"RA",-10} {"Nome",-10} {"Idade"}");
            System.Console.WriteLine(new string('-', 45));

            foreach (var aluno in alunos)
            {
                System.Console.WriteLine($"{aluno.RA,-10} {aluno.Nome,-10} {aluno.Idade}");
            }

            System.Console.WriteLine(new string('-', 45));
        }
    }

    static void Alterar()
    {
        Console.Write("Digite o RA que deseja alterar: ");
        string ra = Console.ReadLine();

        Aluno aluno = alunos.Find(a => a.RA == ra);

        if (aluno == null)
        {
            System.Console.WriteLine("Aluno não encontrado");
            return;
        }

        Console.Write($"Novo nome: (atual: {aluno.Nome})");
        string novoNome = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(novoNome))
            aluno.Nome = novoNome;

        Console.Write($"Nova idade: (atual: {aluno.Idade}): ");
        string entradaIdade = Console.ReadLine();

        if (int.TryParse(entradaIdade, out int novaIdade))
            aluno.Idade = novaIdade;
    }

    static void Remover()
    {
        Console.Write("Digite o RA do aluno que deseja remover: ");
        string ra = Console.ReadLine();

        Aluno aluno = alunos.Find(a => a.RA == ra);

        if (aluno == null)
        {
            System.Console.WriteLine("Aluno não encontrado.");
            return;
        }

        Console.Write($"Confirma a exclusão do aluno: {aluno.RA}: {aluno.Nome}?: [s/n]");
        if (Console.ReadLine().ToLower() == "s")
        {
            alunos.Remove(aluno);
            System.Console.WriteLine("Aluno removido com sucesso!");
        }

        else
        {
            System.Console.WriteLine("Remoção cancelada.");
        }
    }
}