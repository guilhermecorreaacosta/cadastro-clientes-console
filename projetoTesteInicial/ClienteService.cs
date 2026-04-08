using projetoTesteInicial;
using System;
using System.Collections.Generic;

public class ClienteService
{
    private readonly List<Cliente> clientes = new();

    public void CadastrarCliente()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();

        var cliente = new Cliente
        {
            Id = clientes.Count + 1,
            Nome = nome,
            Email = email,
            Telefone = telefone
        };

        clientes.Add(cliente);

        Console.WriteLine("Cliente cadastrado com sucesso!");
        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.WriteLine("=== CLIENTES CADASTRADOS ===");

        if (clientes.Count == 0)
        {
            Console.WriteLine("Nenhum cliente cadastrado.");
        }
        else
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine(
                    $"Id: {cliente.Id} | Nome: {cliente.Nome} | Email: {cliente.Email} | Telefone: {cliente.Telefone}"
                );
            }
        }

        Console.ReadLine();
    }
}
