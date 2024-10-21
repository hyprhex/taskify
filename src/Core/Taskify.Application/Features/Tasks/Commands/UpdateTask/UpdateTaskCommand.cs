using MediatR;

namespace Taskify.Application.Features.Tasks.Commands.UpdateTask
{
  public class UpdateTaskCommand : IRequest<Guid>
  {
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public TaskStatus Status { get; set; }
    public Guid CategoryId { get; set; }

  }
}
