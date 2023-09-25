//classe pai que sera herdada pelo filho - SuperClasse
 abstract class Animal
{
    public string cor { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Animal emitindo som");
    }
}

class Cachorro : Animal
{

    public void Latir()
    {
        Console.WriteLine($"o cachorro {cor} esta latindo");
    }
}
//classe filha que herdara da classe animal
//receberá todos os atributos e metodos da SuperClasse
class Gato : Animal
{
public override void EmitirSom()
    {
        Console.WriteLine($"o gato esta miando");
    }
}


class program
{
    public static void Main()
    {
        //Nao é permitido instanciar um objeto e uma classe abstrata
        //var animalGenerico = new Animal();
        //animalGenerico.EmitirSom();

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "Caramelo";
        meuCachorro.EmitirSom();
        meuCachorro.Latir();

        Gato meuGato = new Gato();
        meuGato.EmitirSom();
    }
}