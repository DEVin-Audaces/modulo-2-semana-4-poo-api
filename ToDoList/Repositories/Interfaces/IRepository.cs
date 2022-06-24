using System.Collections.Generic;

namespace projeto.ToDoList.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        void Adicionar(T model);
        void Editar(T model);
        void Remover(int id);
        List<T> Listar(string pesquisa = null);
        T ObterPorId(int id);

    }
}