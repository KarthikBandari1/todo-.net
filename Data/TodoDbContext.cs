using Microsoft.EntityFrameworkCore;
using MyTodo.Models;

namespace MyTodo.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Todo> Todos { get; set; }
    }
}