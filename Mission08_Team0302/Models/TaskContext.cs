using Microsoft.EntityFrameworkCore;

namespace Mission08_Team0302.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
        }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
