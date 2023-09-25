using Models;

public class program
{
    public static void Main()
    {
        // criando um objeto da classe pessoa
        // instanciando sem o metodo construtor 

        /*var pessoa1 = new pessoa();
        pessoa1.nome = "douglas";
        pessoa1.idade = 25;
        pessoa1.Cantar();

        //alternativa para criaçao de um objeto sem construtor

        var pessoa2 = new pessoa{
        nome = "ricardo",
        idade = 25
        };
        pessoa2.Cantar();
        */

        pessoa pessoa1 = new pessoa("Douglas", 35, "maria.oliveira83@portalsesisp.org.br");
        pessoa1.Cantar();
        pessoa1.informaçoes();

        pessoa pessoa2 = new pessoa("maria", 17, "maria.oliveira83@portalsesisp.org.br");
        pessoa1.Cantar();
        pessoa1.informaçoes();


        pessoa pessoa3 = new pessoa("marcos", 20, "maria.oliveira83@portalsesisp.org.br");
        pessoa1.Cantar();
        pessoa1.informaçoes();

    }
}