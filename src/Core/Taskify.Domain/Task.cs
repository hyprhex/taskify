namespace Taskify.Domain
{
  public class Task
  {
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public TaskStatus Status { get; set; }
    public DateTime? DueDate { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime LastModifiedDate { get; set; }
    public Guid CategoryId { get; set; }
    public required Category Category { get; set; }

  }

  public enum TaskStatus
  {
    Pending,
    InProgress,
    Completed
  }
}
