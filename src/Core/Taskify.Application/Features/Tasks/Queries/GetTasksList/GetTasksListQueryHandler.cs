using AutoMapper;
using MediatR;
using Taskify.Application.Contracts;

namespace Taskify.Application.Features.Tasks.Queries.GetTasksList
{
  public class GetTasksListQueryHandler : IRequestHandler<GetTasksListQuery, List<GetTasksListViewModel>>
  {
    private readonly ITaskRepository _taskRepository;
    private readonly IMapper _mapper;

    public GetTasksListQueryHandler(ITaskRepository taskRepository, IMapper mapper)
    {
      _taskRepository = taskRepository;
      _mapper = mapper;
    }

    public async Task<List<GetTasksListViewModel>> Handle(GetTasksListQuery request, CancellationToken cancellationToken)
    {
      var allTasks = await _taskRepository.GetAllTasksAsync(true);
      return _mapper.Map<List<GetTasksListViewModel>>(allTasks);
    }
  }
}
