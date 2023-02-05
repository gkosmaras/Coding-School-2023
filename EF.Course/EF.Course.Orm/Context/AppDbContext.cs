using EF.Course.Model;
using EF.Course.Orm.Configurations;

using Microsoft.EntityFrameworkCore;

namespace EF.Course.Orm.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<TodoInfo> TodoInfos { get; set; }
        public DbSet<TodoComment> TodoComments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TodoConfiguration());
            modelBuilder.ApplyConfiguration(new TodoInfoConfiguration());
            modelBuilder.ApplyConfiguration(new TodoCommentConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TodoDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
