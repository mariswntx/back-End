namespace Sesi.Model{

public class pantera{
    public decimal tamanho { get; set; }

    public int  peso { get; set; }

    public string cor { get; set; }

    public string especie { get; set; }

    public string alimentaçao { get; set; }

public void correr(){
        Console.WriteLine($"Pantera esta correndo");
    }
    public void caçar(){
        Console.WriteLine($"Pantera esta caçando");
    }
}
}