using projeto.ToDoList.Dtos;
using projeto.ToDoList.Models;
using projeto.ToDoList.Repositories;
using ToDoList.Repositories;

namespace projeto.ToDoList.Converters
{
    public static class TarefaConverter
    {
        public static TarefaModel DtoParaModel(TarefaDto tarefaDto)
        {
            var id = TarefaRepository.GerarId();
            return new TarefaModel(id, tarefaDto.Name, tarefaDto.Date, tarefaDto.Description);
        }
    }
}