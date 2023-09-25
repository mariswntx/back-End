//Funcao em JavaScript
//function nomeFuncao(){
//}

//Funcao / metodo em C#
//public static void NomeFuncao(){
//}

class Sesi
{
    public static void Main()
    {
        //chamando metodos sem retorno 
        MostrarMensagem("Seja bem vindo");
        MostrarMensagem("SESI / SENAI");
        ImprimeDataHora();
        double Potencia = Potenciacao(4);
        Console.WriteLine($"potenciação {Potencia}");

        ContagemRegressiva(10);
        JogoQueNrSouEu();
    }
    //metodo com parametro e retorno 
    public static double Potenciacao(int num)
    {
        double resultado = Math.Pow(num, 2);
        return resultado;
    }


    //metodo sem parametro e sem retorno
    public static void ImprimeDataHora()
    {
        Console.WriteLine(DateTime.Now.ToString());
    }
    //metodo com parametro e sem retorno
    public static void MostrarMensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }

    public static void ContagemRegressiva(int n)
    {
        while (n >= 0)
        {
            Console.WriteLine(n);
            n--;
            System.Threading.Thread.Sleep(500); //500 ms

        }
        Console.WriteLine("BOOOOOOOOOOM");
    }




    public static void JogoQueNrSouEu()
    {
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * *");
        Console.WriteLine("            Bem vindo ao jogo            ");
        Console.WriteLine("Sorteei um n° de 1 a 20 tente adivinha-lo");
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * *");
        Console.WriteLine(""); //linha em branco

        Random rnd = new Random();
        int nrSorteado = rnd.Next(20);
        int nrDigitado = -1;

        do
        {
            Console.WriteLine("Digite um n°");
            nrDigitado = int.Parse(Console.ReadLine());
            if (nrDigitado > nrSorteado)
                Console.WriteLine("O numero digitado é MAIOR que o sorteado");
            else if (nrDigitado < nrSorteado)
                Console.WriteLine("O numero digitado é MENOR que o sorteado");
        } while (nrDigitado != nrSorteado);

        Console.WriteLine("Parabens você acertou");

    }
}