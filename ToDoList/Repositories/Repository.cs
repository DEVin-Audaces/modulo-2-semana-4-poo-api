using System.Collections.Generic;
using System.Linq;
using projeto.ToDoList.Models;
using projeto.ToDoList.Repositories.Interfaces;

namespace projeto.ToDoList.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        private static int _id = 0;
        protected static List<T> lista = new List<T>();

        public void Adicionar(T model)
        {
            model.Id = GerarId();
            lista.Add(model);
        }

        public void Editar(T modeloASerEditado)
        {
            var modelo = lista.FirstOrDefault(x => x.Id == modeloASerEditado.Id);

            if (modelo == null)
                lista.Add(modeloASerEditado);
            else
            {
                lista.Remove(modelo);
                lista.Add(modeloASerEditado);

            }
        }

        public void Remover(int id)
        {
            var model = lista.FirstOrDefault(x => x.Id == id);
            if(model != null)
                lista.Remove(model);
        }

        public List<T> Listar(string pesquisa = null)
        {
            return lista;
        }

        public T ObterPorId(int id)
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