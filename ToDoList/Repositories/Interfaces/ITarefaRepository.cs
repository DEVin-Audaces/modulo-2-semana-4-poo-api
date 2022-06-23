using System.Collections.Generic;
using projeto.ToDoList.Models;

namespace ToDoList.Repositories.Interfaces
{
    public interface ITarefaRepository
    {
        void Adicionar(TarefaModel tarefaModel);
        void Remover(int id);
        List<TarefaModel> Listar(string pesquisa = null);
    }
}