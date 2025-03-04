using Microsoft.EntityFrameworkCore;
using ToDoListBlazor.Models;

namespace ToDoListBlazor.Context
{
    public class ListaDeTarefasContext : DbContext
    {
        public ListaDeTarefasContext(DbContextOptions<ListaDeTarefasContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
