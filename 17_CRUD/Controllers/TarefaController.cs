using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


public class TarefaController : Controller
{
    private static List<Tarefa> _tarefas = new List<Tarefa>();

    public IActionResult Index()
    {

        return View(_tarefas);
    }

    public IActionResult Adicionar()
    {

        return View();
    }

    [HttpPost]
    public IActionResult adicionar(Tarefa novaTarefa)
    {

        //verificando total de tarefad e adiciondo maid 1
        novaTarefa.Id = _tarefas.Count + 1;
        //adicionando minha nova tarefa
        _tarefas.Add(novaTarefa);
        //redirecionando para a pagina principal com a lista de tarefas
        return RedirectToAction("Index");
    }

    public IActionResult Editar(int Id)
    {
        //buscando a lista de tarefas que desejo alterar 
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == Id);
        //verificando se existe 
        if (novaTarefa == null)
            return NotFound();

        //enviando para a view a tarefas que queremos alterar
        return View(novaTarefa);
    }

    [HttpPost]
    public IActionResult Editar(Tarefa tarefaEditando)
    {

        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == tarefaEditando.Id);
        if (tarefaEncontrada == null)
            return NotFound();

        tarefaEncontrada.Descricao = tarefaEditando.Descricao;
        tarefaEncontrada.Concluida = tarefaEditando.Concluida;
        return RedirectToAction("Index");
    }


    public IActionResult Deletar(int Id)
    {

        //verificando total de tarefad e adiciondo maid 1
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == Id);
     
      if(novaTarefa == null)
            return NotFound();

        return View(novaTarefa);
    }

  [HttpPost]
    public IActionResult DeletarConfirmado(int Id)
    {
        //buscando a lista de tarefas que desejo alterar 
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == Id);
        //verificando se existe 
        if (tarefaEncontrada == null)
            return NotFound();

        _tarefas.Remove(tarefaEncontrada);
        return RedirectToAction("Index");
    }
}