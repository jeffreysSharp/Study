namespace Conversores;

public class Conversor
{
    public void ConvertAndParse()
    {
        // int numero = int.Parse("1");        
        // int numero = Convert.ToInt32(null);
        // int numero = int.Parse(null);
        // Console.WriteLine(numero);
        bool verdadeiro = bool.Parse("true");
        Console.WriteLine(verdadeiro);
    }

    public void AulaTryParse()
    {
        var numero = "abc";
        int numeroConvertido;

        if(int.TryParse(numero, out numeroConvertido))
        {
            Console.WriteLine("Numero foi convertido com sucesso!");
        }

        Console.WriteLine(numeroConvertido);
    }

} 