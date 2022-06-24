using System.Collections.Generic;
using System.Linq;
using projeto.ToDoList.Models;

namespace projeto.ToDoList.Repositories
{
    public class TarefaRepository
    {
        private static int Id = 0;
        private static List<TarefaModel> lista = new List<TarefaModel>();

        public static List<TarefaModel> Listar(string pesquisa = null)
        {
            return string.IsNullOrEmpty(pesquisa)
                ? lista
                : lista.Where(x => x.Name.ToLower().Contains(pesquisa.ToLower().Trim())).ToList();
        }

        public static void Adicionar(TarefaModel tarefaModel)
        {
            lista.Add(tarefaModel);
        }

        public static void Adicionar(IEnumerable<TarefaModel> tarefaModel)
        {
            lista.AddRange(tarefaModel);
        }

        public static void Remover(int id)
        {
            var tarefaModel = lista.FirstOrDefault(x => x.Id == id);
            if(tarefaModel != null)
             lista.Remove(tarefaModel);
        }

        public static int GerarId()
        {
            Id++;
            return Id;
        }
    }
}