using ToDoList.Dtos;
using ToDoList.Models;
using ToDoList.Repositories;

namespace ToDoList.Converters
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