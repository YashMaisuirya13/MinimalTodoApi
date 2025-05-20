
using Microsoft.EntityFrameworkCore;
using MinimalTodoApi.Models;

namespace MinimalTodoApi.Data
{
    public class TodoDb : DbContext
    {
        // Constructor that accepts DbContextOptions
        public TodoDb(DbContextOptions<TodoDb> options) : base(options) { }

        // Represents the collection of Todo items in the database
        public DbSet<Todo> Todos { get; set; }
    }
}
