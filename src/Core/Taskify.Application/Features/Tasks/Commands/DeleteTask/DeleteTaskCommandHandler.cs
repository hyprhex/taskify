using Taskify.Application.Contracts;
using MediatR;

namespace Taskify.Application.Features.Tasks.Commands.DeleteTask
{
  public class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommand>
  {
    private readonly ITaskRepository _taskRepository;
    public DeleteTaskCommandHandler(ITaskRepository taskRepository)
    {
      _taskRepository = taskRepository;
    }

    public async Task<Unit> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
    {
      var task = await _taskRepository.GetByIdAsync(request.TaskId);

      await _taskRepository.DeleteAsync(task);

      return Unit.Value;
    }
  }

}
