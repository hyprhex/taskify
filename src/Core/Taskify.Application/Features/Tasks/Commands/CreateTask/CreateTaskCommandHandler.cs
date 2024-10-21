using AutoMapper;
using Taskify.Application.Contracts;
using Taskify.Domain;
using MediatR;

namespace Taskify.Application.Features.Tasks.Commands.CreateTask
{
  public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, Guid>
  {
    private readonly ITaskRepository _taskRepository;
    private readonly IMapper _mapper;

    public CreateTaskCommandHandler(ITaskRepository taskRepository, IMapper mapper)
    {
      _taskRepository = taskRepository;
      _mapper = mapper;
    }
    public async Task<Guid> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
    {
      var task = _mapper.Map<Task>(request);

      CreateCommandValidator validator = new CreateCommandValidator();
      var result = await validator.ValidateAsync(request);

      if (result.Errors.Any())
      {
        throw new Exception("Task is not valid");
      }

      task = await _taskRepository.AddAsync(task);

      return task.Id;
    }
  }
}
