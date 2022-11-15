using System;
using Microsoft.EntityFrameworkCore;

namespace TodoFinalProject.Model
{
    public class TodoDBContext : DbContext
    {
        public TodoDBContext(DbContextOptions<TodoDBContext> options) : base(options)
        {
        }
        public DbSet<Todo> Todos { get; set; }
    }
}
