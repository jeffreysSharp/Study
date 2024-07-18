namespace Modulo10;

public class TrabalhandoComStrings
{
    public void ConverterParaLetrasMaiusculas()
    {
        Console.Write("Favor digitar alguma informaçao: ");
        var linha = Console.ReadLine();

        Console.WriteLine(linha.ToUpper());
    }

    public void ConverterParaLetrasMinusculas()
    {
        Console.Write("Favor digitar alguma informacao: ");
        var linha = Console.ReadLine();

        Console.WriteLine(linha.ToLower());
    }

    public void AulaSubstring()
    {
        Console.Write("Favor digitar alguma informacao: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.Substring(6));

    }

    public void AulaRange()
    {
        string nomeArquivo = "2022_12_01_backup.bak";
        var ano = nomeArquivo[..4];
        Console.WriteLine(ano);

        string extencao = nomeArquivo[^3..];
        Console.WriteLine(extencao);

        string nome = nomeArquivo[11..^4];
        Console.WriteLine(nome);

        string apenasNome = nomeArquivo[..^4];
        Console.WriteLine(apenasNome);

    }

    public void AulaContains()
    {
        string nomeArquivo = "2022_12_01_backup.bak";
        if(nomeArquivo.Contains("backup"))
        {
            Console.WriteLine("Palavra encontrada!");
        }
        else
        {
            Console.WriteLine("Palavra não encontrada!");
        }
        
        //Console.WriteLine("Contém nome: " + nomeArquivo.Contains("backup"));
    }

    public void AulaTrim()
    {
        string teste = "**RAFAEL ALMEIDA**";
        Console.WriteLine("Total: " + teste.Trim('*'));
        Console.WriteLine("Início: " + teste.TrimStart('*'));
        Console.WriteLine("Final: " + teste.TrimEnd('*'));

    }

    public void AulaStartWithEndsWith()
    {
        string teste = "Curso CSharp";

        Console.WriteLine("Início: " + teste.StartsWith("Curso"));
        Console.WriteLine("Final: " + teste.EndsWith("Csharp"));

    }

    public void AulaReplace()
    {
        string teste = "Curso Csharp";
        Console.WriteLine(teste.Replace("Csharp", "C#"));
    }

    public void AulaLenght()
    {
        string teste = Console.ReadLine();
        Console.WriteLine(teste);
        Console.WriteLine(teste.Length);

    }
}