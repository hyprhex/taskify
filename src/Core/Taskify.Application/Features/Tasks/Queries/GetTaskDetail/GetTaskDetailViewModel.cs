using Taskify.Application.Features.Tasks.Queries.GetTasksList;

namespace Taskify.Application.Features.Tasks.Queries.GetTaskDetail
{
  public class GetTaskDetailViewModel
  {
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public TaskStatus Status { get; set; }
    public CategoryDto Category { get; set; }

  }
}
