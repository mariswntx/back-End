// Exercicio 001 calculando a media de 3 notas de um aluno 

// receber o nome do aluno e armazenar em uma variavel inteira do tipo string 

//receber a nota 01, converter e armazenar em uma variavel int

//receber a nota 02, converter e armazenar em uma variavel int

//receber a nota 03, converter e armazenar em uma variavel int

// declarar uma variavel do tipo int, para receber a media das notas
//(nota1 + nota2 + nota3) / 3

//exibir uma mensagem se o aluno esta aprovado considerando a nota acima de 7

Console.WriteLine("Digite o valor de x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de y:");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de z:");
int z = int.Parse(Console.ReadLine());

int nota1 = x;
int nota2 = y;
int nota3 = z;
int resultado = (nota1 + nota2 + nota3) /3;
        
        if (resultado >= 7) {
            Console.WriteLine($"A media do aluno foi {resultado}, ele esta APROVADO ");
        } else{
            Console.WriteLine($"A media do aluno foi {resultado}, ele esta REPROVADO");
        }
       
        