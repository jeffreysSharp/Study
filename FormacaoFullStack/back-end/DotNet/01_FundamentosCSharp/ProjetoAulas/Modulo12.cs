namespace Modulo12;

public class TrabalhandoComExcessoes
{
    public void AulaGerandoException()
    {
        while(true)
        {
            Console.Write("Informeum numero: ");
            var numero = Console.ReadLine();
            var resultado = 500 / int.Parse(numero);

            Console.WriteLine("Resultado: " + resultado);
        }
    }

    public void AulaTratandoException()
    {
        
        while(true)
        {
         try 
         {
          Console.Write("Informeum numero: ");
          var numero = Console.ReadLine();
          var resultado = 500 / int.Parse(numero);

          Console.WriteLine("Resultado: " + resultado);

        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("Ocorreu um erro de divisão: " + ex.Message);   
            Console.WriteLine("Stack: " + ex.StackTrace);              

        }
        catch(Exception ex)
        {
            Console.WriteLine("Ocorreu um erro: " + ex.Message);   
            Console.WriteLine("Stack: " + ex.StackTrace);  
        }            
        }

    }
}