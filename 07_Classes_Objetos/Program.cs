// sempre que formos utilizar bibliotecas ou classes ja criadas
//importamos ela com using
using Sesi.Model;

class program {
    public static void Main(){

        //criando uma variavel aluno1 e instanciando a class Aluno
        //ou seja, esamos criando nosso objeto
        var aluno1 = new Aluno();
//atribuindo um valor ao atriburo nome do aluno
        aluno1.nome = "Douglas";
        aluno1.idade = 17;
        aluno1.turma = "2 E.M";

        aluno1.Apresentar();
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(10);
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(7);
        aluno1.ResumirFaltas();
        aluno1.JustificarFaltas(8);
        aluno1.ResumirFaltas();

        var aluno2 = new Aluno();
        aluno2.nome = "Marcos";
        aluno2.idade = 20;
        aluno2.turma = "2 E.M";

        aluno2.Apresentar();
    }
}