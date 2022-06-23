using System;

namespace ToDoList.Models
{
    public class TarefaModel
    {
        public TarefaModel(int id, string name, DateTime date, string description)
        {
            Id = id;
            Name = name.Trim();
            Date = date;
            Description = description;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}