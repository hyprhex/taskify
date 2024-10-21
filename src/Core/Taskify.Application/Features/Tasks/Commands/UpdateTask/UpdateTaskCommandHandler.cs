using AutoMapper;
using Taskify.Application.Contracts;
using Taskify.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Taskify.Application.Features.Tasks.Commands.UpdateTask
{
  public class UpdateTaskCommandHandler : IRequestHandler<UpdateTaskCommand>
  {
    private readonly IAsyncRepository<Task> _taskRepository;
    private readonly IMapper _mapper;
    public UpdateTaskCommandHandler(IAsyncRepository<Task> taskRepository, IMapper mapper)
    {
      _taskRepository = taskRepository;
      _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
    {
      var task = _mapper.Map<Task>(request);

      await _taskRepository.UpdateAsync(task);

      return Unit.Value;
    }
  }
}
