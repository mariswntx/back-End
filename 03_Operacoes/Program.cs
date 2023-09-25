Console.WriteLine("Digite o valor de x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de y:");
int y = int.Parse(Console.ReadLine());

// Exemplos de operaçoes aritimeticas 
int soma = x + y;
int subtracao = x - y;
int mutiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2; // calculando o resto da divisao de x / 2 
int restoDiv3 = y % 2;

//console para exibir na tela as variáveis em cada linha 
// soma: 15 

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"subtracao: {subtracao}");
Console.WriteLine($"mutiplicacao: {mutiplicacao}");
Console.WriteLine($"divisao: {divisao}");
Console.WriteLine($"resto: {resto}");

if (restoDiv2 == 0)
{
    Console.WriteLine($"O numero {x} é par");
}
else
{
    Console.WriteLine($"O numero {x} é impar ");
}

if (restoDiv3 == 0)
{
    Console.WriteLine($"O numero {y} é par");
}
else
{
    Console.WriteLine($"O numero {y} é impar ");
}

//Operador ternario
//condicao ? se : senao
string resultado = (resultadoDiv3 == 0) ? $"o numero {x} é par" : $"o numero {y} é impar";
Console.WriteLine(resultado);

int diaSemana = 3;
//Aprendendo swith case 
switch (diaSemana)
{
    case 1:
        Console.WriteLine("Hoje é domingo!");
        break;
    case 2:
        Console.WriteLine("Hoje é segunda!");
        break
    case 3:
        Console.WriteLine("Hoje é terça!");
        break
    case 4:
        Console.WriteLine("Hoje é quarta!");
        break
    case 5:
        Console.WriteLine("Hoje é quinta!");
        break
    case 6:
        Console.WriteLine("Hoje é sexta!");
        break
    case 7:
        Console.WriteLine("Hoje é sabado!");
    default:
        Console.WriteLine("Dia invalido");
}