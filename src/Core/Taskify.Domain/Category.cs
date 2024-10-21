namespace Taskify.Domain
{
  public class Category
  {
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public ICollection<Task> Tasks { get; set; } = new List<Task>();
  }
}
