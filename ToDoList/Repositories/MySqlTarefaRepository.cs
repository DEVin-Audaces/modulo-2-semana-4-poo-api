using System;
using System.Collections.Generic;
using ToDoList.Models;
using ToDoList.Repositories.Interfaces;

namespace ToDoList.Repositories
{
    public class MySqlTarefaRepository : ITarefaRepository
    {
        public void Adicionar(TarefaModel tarefaModel)
        {
            throw new System.NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<TarefaModel> Listar(string pesquisa = null)
        {
            return new List<TarefaModel>() { new TarefaModel(1, "TAREFA DO BANCO MYSQL", DateTime.Now, "") };
        }
    }
}