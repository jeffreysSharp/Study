namespace Modulo14;

public class TrabalhandoComLinq
{
    public void AulaWhere()
    {
        /*var nomeCompleto = "RAFAEL ALMEIDA";

        Func<char, bool> filtro = c => c == 'A';
        
        // var resultado = nomeCompleto.Where(filtro);
        // var resultado = nomeCompleto.Where(p => p == 'A');
        var resultado = from c in nomeCompleto where c == 'E' select;

        foreach(var letra in resultado)
        {
            Console.WriteLine(letra);
        }*/

        var numeros = new int[] {10, 6, 5, 50, 15, 2};
        var resultado = numeros.Where(p => p >= 10);
        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
        
    }

    public void AulaOrdenacao()
    {
        var numeros = new int[] {10, 6, 5, 50, 15, 2};

        // var resultado = numeros.OrderBy(p => p);
        var nomes = new string[] { "Rafael", "Eduardo", "Bruno"};
        
        // var resultado = numeros.OrderByDescending(p => p);
        var resultado = nomes.OrderBy(p => p);

        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void AulaTake()
    {
        var numeros = new int[] {10, 6, 5, 50, 15, 2};
        var resultado = numeros.Where(p => p > 10).Take(3).OrderBy(p => p);

        foreach(var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void AulaCount()
    {
        var numeros = new int[] {10, 6, 5, 50, 15, 2};
        var resultado = numeros.Count(p => p > 10);

        Console.WriteLine(resultado);
    }

    public void AulaFirstEFirstOrDefault()
    {
        var numeros = new int[] {10, 6, 5, 50, 50, 15, 2};
        // var resultado = numeros.First();
        // var resultado = numeros.First(p => p > 15);
        var resultado = numeros.FirstOrDefault(p => p > 100, -99);

        Console.WriteLine(resultado);
    }
}