using MediatR;

namespace Taskify.Application.Features.Tasks.Queries.GetTasksList
{
  public class GetTasksListQuery : IRequest<List<GetTasksListViewModel>>
  {

  }
}
