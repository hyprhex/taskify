using MediatR;

namespace Taskify.Application.Features.Tasks.Queries.GetTaskDetail
{
  public class GetTaskDetailQuery : IRequest<GetTaskDetailViewModel>
  {
    public Guid TaskId { get; set; }
  }
}
