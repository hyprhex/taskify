using MediatR;

namespace Taskify.Application.Features.Tasks.Commands.DeleteTask
{
  public class DeleteTaskCommand : IRequest
  {
    public Guid TaskId { get; set; }
  }

}

