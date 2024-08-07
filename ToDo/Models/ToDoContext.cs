using Microsoft.EntityFrameworkCore;

namespace ToDoDemo.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

        public DbSet<ToDo> ToDos { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Status> Statuses { get; set; } = null!;


        //seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "is", Name="İş"},
                new Category { CategoryId = "ev", Name = "Ev" },
                new Category { CategoryId = "okul", Name = "Okul" },
                new Category { CategoryId = "ex", Name = "Exercise" },
                new Category { CategoryId = "shop", Name = "Alışveriş" }
                );

            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "open", Name = "Open" },
                new Status { StatusId = "closed", Name = "Completed" }
                );
        }
    }
}
