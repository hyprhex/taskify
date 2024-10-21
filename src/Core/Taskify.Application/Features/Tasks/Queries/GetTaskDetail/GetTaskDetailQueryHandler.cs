using AutoMapper;
using Taskify.Application.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Taskify.Application.Features.Tasks.Queries.GetTaskDetail
{
  public class GetTaskDetailQueryHandler : IRequestHandler<GetTaskDetailQuery, GetTaskDetailViewModel>
  {
    private readonly ITaskRepository _taskRepository;
    private readonly IMapper _mapper;

    public GetTaskDetailQueryHandler(ITaskRepository taskRepository, IMapper mapper)
    {
      _taskRepository = taskRepository;
      _mapper = mapper;
    }

    public async Task<GetTaskDetailViewModel> Handle(GetTaskDetailQuery request, CancellationToken cancellationToken)
    {
      var Task = await _taskRepository.GetTaskByIdAsync(request.TaskId, true);

      return _mapper.Map<GetTaskDetailViewModel>(Task);
    }
  }
}
