﻿namespace ToDoListBlazor.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public string Descricao { get; set; } = null!;
    }
}
