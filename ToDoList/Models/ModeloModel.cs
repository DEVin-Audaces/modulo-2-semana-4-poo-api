﻿using System.ComponentModel.DataAnnotations;

namespace projeto.ToDoList.Models
{
    public class ModeloModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Responsavel { get; set; }
        public string Tipo { get; set; }
        public int Colecao { get; set; }
        public bool Bordado { get; set; }
        public bool Estampa { get; set; }

        public ModeloModel()
        {

        }

    }
}