using System.Data.Entity;

namespace ToDoApp.Models
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
    }

    public class Todo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
}