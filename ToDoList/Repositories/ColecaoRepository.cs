using System.Collections.Generic;
using System.Linq;
using projeto.ToDoList.Models;
using projeto.ToDoList.Repositories.Interfaces;

namespace projeto.ToDoList.Repositories
{
    public class ColecaoRepository : Repository<ColecaoModel>, IColecaoRepository
    {
        public List<ColecaoModel> ObterColecoesComMaisVendas()
        {
            throw new System.NotImplementedException();
        }
    }
}