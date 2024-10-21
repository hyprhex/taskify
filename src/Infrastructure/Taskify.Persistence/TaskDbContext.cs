using Taskify.Domain;
using Microsoft.EntityFrameworkCore;


namespace Taskify.Persistence
{
  public class TaskDbContext : DbContext
  {
    public TaskDbContext(DbContextOptions<TaskDbContext> options)
       : base(options)
    {
    }

    public DbSet<Task> Tasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      var categoryGuid = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}");
      var taskGuid = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B43E6A6}");
      modelBuilder.Entity<Category>().HasData(new Category
      {
        Id = categoryGuid,
        Name = "API"
      });

      modelBuilder.Entity<Task>().HasData(new Task
      {
        Id = taskGuid,
        Title = "Build Task management API",
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat",
        Status = "Completed",
        CategoryId = categoryGuid
      });

    }
  }

}
