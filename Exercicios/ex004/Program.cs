class Program
{

    public static void Main()
    {
        int valor_dobro = Dobro(int.Parse(Console.ReadLine()));
        Console.WriteLine($"O dobro é {valor_dobro}");

        int valor_metade = Metade(int.Parse(Console.ReadLine()));
        Console.WriteLine($"A metade é {valor_metade}");

        Tabuada(int.Parse(Console.ReadLine()));

        ResumoSalarios();

    }
    public static int Dobro(int valor)
    {
        int resultado = valor * 2;
        return resultado;
    }

    public static int Metade(int final)
    {
        int Resultado = final / 2;
        return Resultado;
    }

    public static void Tabuada(int numero)
    {
        int contador = 1;
        while (contador <= 10)
        {
            Console.WriteLine($"1 x {numero} - {contador * numero}");
            contador++;
        }
    }


    public static void ResumoSalarios()
    {
        int somaSalarios = 0;
        int menorSalario = 10000;
        int maiorSalario = 0;
        int salarioEmpregado = 0;

        do
        {
            Console.WriteLine("Digite o salario do empregado");
            salarioEmpregado = int.Parse(Console.ReadLine());

            if (salarioEmpregado > 0)
                somaSalarios = somaSalarios + salarioEmpregado;

            if (salarioEmpregado > maiorSalario)
            {
                maiorSalario = salarioEmpregado;
            }

            if (salarioEmpregado < maiorSalario && salarioEmpregado > 0)
            {
                maiorSalario = salarioEmpregado;
            }

        } while (salarioEmpregado > 0);
        Console.WriteLine($"A soma dos salarios é {somaSalarios} o maior salario é {maiorSalario} e o menor salario é {menorSalario}");

    }
}
