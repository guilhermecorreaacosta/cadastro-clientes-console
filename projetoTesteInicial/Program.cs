using System;

var clienteService = new ClienteService();
int opcao = 0;

while (opcao != 3)
{
    Console.Clear();
    Console.WriteLine("=== CADASTRO DE CLIENTES ===");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Listar clientes");
    Console.WriteLine("3 - Sair");
    Console.Write("Escolha uma opção: ");

    int.TryParse(Console.ReadLine(), out opcao);

    switch (opcao)
    {
        case 1:
            clienteService.CadastrarCliente();
            break;
    
        case 2:
            clienteService.ListarClientes();
            break;
    }
}
