using Sesi.Model;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o nome do titular:");
        string nomeTitular = Console.ReadLine();

        ContaCorrente ContaCorrente1 = new ContaCorrente(nomeTitular, 0);
        string opcao = "";
        do
        {
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("        Bem vindo ao Banco Brasil        ");
            Console.WriteLine("");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("Menu do Banco:");
            Console.WriteLine("1 - Consultar saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("0 - Sair");
             opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado, volte sempre !!!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    ContaCorrente1.ConsultarSaldo();
                    break;
                case "2":
                    Console.WriteLine("Digite o valor que deseja depositar:");
                    double valor = double.Parse(Console.ReadLine());
                    ContaCorrente1.Depositar(valor);
                    break;
                case "3":
                    Console.WriteLine("DIgite o valor que deseja sacar:");
                    double valor2 = double.Parse(Console.ReadLine());
                    ContaCorrente1.Sacar(valor2);
                    break;
                default:
                    Console.WriteLine("Opção inválida!!!");
                    break;
            } 
        }while (opcao != "0");
    }
}