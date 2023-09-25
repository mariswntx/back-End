using System.Collections.Generic;
using Sesi.Models;

public class Program
{
    public static void Main()
    {
        //criando uma lista de inteiros 
        List<int> listaNumeros = new List<int>();

        listaNumeros.Add(10); //ele esta na posiçao 0 
        listaNumeros.Add(20); //ele esta na posiçao 1
        listaNumeros.Add(30); //ele esta na posiçao 2

        Console.WriteLine(listaNumeros[0]);

        //contagem de elementos
        Console.WriteLine($"neste momento temos {listaNumeros.Count} elementos");

        List<string> listaNomes = new List<string>();

        listaNomes.Add("Maria"); //ele esta na posiçao 0 
        listaNomes.Add("Marcos"); //ele esta na posiçao 1
        listaNomes.Add("Clara"); //ele esta na posiçao 2

        Console.WriteLine(listaNomes[2]);

        Console.WriteLine($"neste momento temos {listaNomes.Count} nomes");

        //criando uma lista de numeros ja atribuindo valores
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine($"neste momento temos {numeros.Count} elementos");

        numeros.Remove(3); //rmover o elemento 3
        numeros.RemoveAt(2); //rmover o elemento no indice 3

        //substituindo informacao do item da lista
        numeros[0] = 100;

        //interando sobre todos os itens da lista
        foreach (int item in numeros)
        {
            Console.WriteLine(numeros);
        }

        foreach (string item in listaNomes)
        {
            Console.WriteLine(item);
        }

        //criando uma lista com objeto da classe aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //adiconando um novo aluno a minha lista
        Aluno novoAluno = new Aluno("Marcos", 20);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("Patricia", 17));
        listaAlunos.Add(new Aluno("Bob", 17));

        //Exibindo lista de alunos 
        Console.WriteLine("Lista de alunos:");
        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine($"Nome do aluno: {item.nome} tem {item.idade} anos");
        }
        //criando uma nova lista ordenando por nome
        var ordenacao = from aluno in listaAlunos
                        where aluno.idade = 17
                        orderby aluno.nome
                        select aluno.nome;

        foreach (var aluno in ordenacao)
            Console.WriteLine(aluno);

        //linq utilizando sintaxe de metodos 
        var consulta = listaAlunos
                              .Where(aluno => novoAluno.idade == 17)
                              .orderBy(aluno => aluno.nome)
        foreach (var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);
        }
        {

        }


    }

}