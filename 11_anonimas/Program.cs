public class Program
{
    public static void Main()
    {
        //Criando classe anonima (classe sem definiçao inicial)
        var pessoa1 = new
        {
            nome = "Marcos",
            idade = 20
        };
        var pessoa2 = new
        {
            nome = "maria",
            email = "maria.123.@senai",
        };

        Console.WriteLine($"a pessoa1 é {pessoa1.nome} e tem {pessoa1.idade} anos");
        Console.WriteLine($"a pessoa2 é {pessoa2.nome} e tem {pessoa2.email}");


        var carro1 = new
        {
            marca = "ford",
            modelo = "ranger",
            ano = "2019",
        };

        var carro2 = new
        {
            marca = "vw",
            modelo = "gol",
            ano = "2020",
        };

         Console.WriteLine($"o carro 1 é da marca{carro1.marca} é do modelo {carro1.modelo} do ano de {carro1.ano}");
         Console.WriteLine($"o carro 2 é da marca{carro2.marca} é do modelo {carro2.modelo} do ano de {carro2.ano}");
    }
}