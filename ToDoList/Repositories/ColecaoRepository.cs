using System.Collections.Generic;
using System.Linq;
using projeto.ToDoList.Models;
using projeto.ToDoList.Repositories.Interfaces;

namespace projeto.ToDoList.Repositories
{
    public class ColecaoRepository : IColecaoRepository
    {
        private static int _id = 0;
        private static List<ColecaoModel> lista = new List<ColecaoModel>();
        public void Adicionar(ColecaoModel model)
        {
            model.Id = GerarId();
            lista.Add(model);
        }

        public void Editar(ColecaoModel model)
        {
            throw new System.NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<ColecaoModel> Listar(string pesquisa = null)
        {
            return lista;
        }

        public ColecaoModel ObterPorId(int id)
        {
            return lista.FirstOrDefault(x => x.Id == id);
        }

        private static int GerarId()
        {
            _id++;
            return _id;
        }
    }
}