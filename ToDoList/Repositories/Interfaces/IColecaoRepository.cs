using System.Collections.Generic;
using projeto.ToDoList.Models;

namespace projeto.ToDoList.Repositories.Interfaces
{
    public interface IColecaoRepository : IRepository<ColecaoModel>
    {
        List<ColecaoModel> ObterColecoesComMaisVendas();
    }
}