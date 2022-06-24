using System;
using System.Collections.Generic;
using projeto.ToDoList.Models;
using projeto.ToDoList.Repositories.Interfaces;

namespace projeto.ToDoList.Repositories
{
    public class MySqlTarefaRepository : ITarefaRepository
    {
        public void Adicionar(TarefaModel tarefaModel)
        {
            throw new System.NotImplementedException();
        }

        public void Editar(TarefaModel model)
        {
            throw new NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<TarefaModel> Listar(string pesquisa = null)
        {
            return new List<TarefaModel>() { new TarefaModel(1, "TAREFA DO BANCO MYSQL", DateTime.Now, "") };
        }

        public TarefaModel ObterPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}