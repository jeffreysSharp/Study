using System.Runtime.InteropServices;
using Cadastro;

namespace Repositorio;

public class ClienteRepositorio
{
    public List<Cliente> clientes = new List<Cliente>();

    public void GravarDadosCliente()
    {
        var json = System.Text.Json.JsonSerializer.Serialize(clientes);
        File.WriteAllText("clientes.txt", json);
    }

    public void LerDadosCliente()
    {
        if(File.Exists("clientes.txt"))
        {
            var dados = File.ReadAllText("clientes.txt");
            var clientesArquivo = System.Text.Json.JsonSerializer.Deserialize<List<Cliente>>(dados);
        
            clientes.AddRange(clientesArquivo);
        }

    }

    public void ExcluirCliente()
    {
        Console.Clear();

        Console.Write("Informe o código do cliente: ");
        var codigo = Console.ReadLine();

        var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigo));

        if(cliente == null)
        {
            Console.WriteLine("Cliente não encontrado! [Enter]");
            Console.ReadKey();
            return;
        }

        ImprimirCliente(cliente);
        clientes.Remove(cliente);
        Console.WriteLine("Cliente removido com sucesso: ");
        Console.ReadKey();
        
    }

    public void EditarCliente()
    {
        Console.Clear();
        Console.Write("Informe o código do cliente: ");
        var codigo = Console.ReadLine();

        var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigo));

        if(cliente == null)
        {
            Console.WriteLine("Cliente não encontrado! : [Enter]");
            Console.ReadKey();
            return;            
        }

        ImprimirCliente(cliente);

        Console.Write("Nome do cliente: ");
        var nome = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.Write("Data nascimento: ");
        var dataNascimento = DateTime.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.Write("Desconto: ");
        var desconto = decimal.Parse(Console.ReadLine());        
        Console.Write(Environment.NewLine);

        cliente.Nome = nome;
        cliente.DataNascimento = dataNascimento;
        cliente.Desconto = desconto;
        cliente.CadastradoEm = DateTime.Now;

        Console.WriteLine("Cliente alterado com sucesso! [Enter]");
        ImprimirCliente(cliente);
        Console.ReadKey();
    }

    public void CadastrarCliente()
    {
        Console.Clear();

        Console.Write("Nome do Cliente: ");
        var nome = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.Write("Data de nascimento: ");
        var dataNascimento = DateTime.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.Write("Desconto: ");
        var desconto = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        var cliente = new Cliente();
        cliente.Id = clientes.Count +1;
        cliente.Nome = nome;
        cliente.DataNascimento = dataNascimento;
        cliente.Desconto = desconto;
        cliente.CadastradoEm = DateTime.Now;

        clientes.Add(cliente);

        Console.WriteLine("Cliente cadastrado com sucesso! [Enter]");
        ImprimirCliente(cliente);
        Console.ReadKey();
    }

    public void ImprimirCliente(Cliente cliente)
    {
        Console.WriteLine("ID..............: " + cliente.Id);
        Console.WriteLine("Nome............: " + cliente.Nome);
        Console.WriteLine("Desconto........: " + cliente.Desconto);
        Console.WriteLine("Data Nascimento.: " + cliente.DataNascimento);
        Console.WriteLine("Data Cadastro...: " + cliente.CadastradoEm);
        Console.WriteLine(".....................................");
    }

    public void ExibirClientes()
    {
        Console.Clear();

        foreach(var cliente in clientes)
        {
            ImprimirCliente(cliente);
        }

        Console.ReadKey();
    }
}