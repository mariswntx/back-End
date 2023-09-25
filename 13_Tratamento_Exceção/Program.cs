public class Program
{
    public static void Main()
    {
        // o try serve para tratar um erro e nao para a execuçao do programa
        //se ocorrer qualquer erro dentro do bloco try o sitema interrompe a execuçao do bloco e vai para o catch 
        try
        {
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"vc digitou o nº {numero}");
            int resultado = 10 / numero;
            Console.WriteLine($"O reusltado é: {resultado}");
        }
        //tratando exceçao de erro de formato, 81
        catch(FormatException){
            Console.WriteLine("Erro: Digite um numero inteiro");

        }
        //catch é o tratamento do erro normalmente colocamos as mensagens de acordo com 
        //o tipo do erro, para melhor compreensao do usuario
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro : {ex.Message}");
        }
        //o finally é um bloco wxecultado independentimente se ocorrer erro ou nao 
        finally
        {
            Console.WriteLine("Entrando no finally");
        }
    }
}