using System;
using System.Collections.Generic;
using System.Linq;
using projeto.ToDoList.Models;
using projeto.ToDoList.Repositories.Interfaces;

namespace projeto.ToDoList.Repositories
{
    public class ModeloRepository : IModeloRepository
    {
        private static int _id = 0;
        private static List<ModeloModel> lista = new List<ModeloModel>();

        public void Adicionar(ModeloModel model)
        {
            model.Id = GerarId();
            lista.Add(model);
        }

        public void Editar(ModeloModel modeloASerEditado)
        {
            var modelo = lista.FirstOrDefault(x => x.Id == modeloASerEditado.Id);

            if (modelo == null)
                throw new ArgumentException();

            modelo.Nome = modeloASerEditado.Nome;
            modelo.Responsavel = modeloASerEditado.Responsavel;
            modelo.Tipo = modeloASerEditado.Tipo;
            modelo.Colecao = modeloASerEditado.Colecao;
            modelo.Bordado = modeloASerEditado.Bordado;
            modelo.Estampa = modeloASerEditado.Estampa;
        }

        public void Remover(int id)
        {
            var model = lista.FirstOrDefault(x => x.Id == id);
            if(model != null)
                lista.Remove(model);
        }

        public List<ModeloModel> Listar(string pesquisa = null)
        {
            return lista;
        }

        public ModeloModel ObterPorId(int id)
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