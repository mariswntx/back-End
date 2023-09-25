Console.WriteLine("Digite sua placa:");
string placa = Console.ReadLine();

string ultimo = placa.Substring(placa.Length-1, 1);

Console.WriteLine($"O seu final é {ultimo}");

if (ultimo == "1" || ultimo == "2"){
    Console.WriteLine("Você nao pode andar na Segunda-Feira");
}else if(ultimo == "3" || ultimo == "4"){
    Console.WriteLine("Você nao pode andar na Terça-Feira");
}
else if(ultimo == "5" || ultimo == "6"){
    Console.WriteLine("Você nao pode andar na Quarta-Feira");
}
else if (ultimo == "7" || ultimo == "8"){
    Console.WriteLine("Você nao pode andar na Quinta-Feira");
}
else if (ultimo == "9" || ultimo == "0"){
        Console.WriteLine("Você nao pode andar na Sexta-Feira");
    }