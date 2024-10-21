using AutoMapper;
using Taskify.Domain;
using Taskify.Application.Features.Tasks.Queries.GetTasksList;
using Taskify.Application.Features.Tasks.Queries.GetTaskDetail;
using Taskify.Application.Features.Tasks.Commands.CreateTask;
using Taskify.Application.Features.Tasks.Commands.UpdateTask;
using Taskify.Application.Features.Tasks.Commands.DeleteTask;

namespace Taskify.Application.Profiles
{
  public class AutoMapperProfile : Profile
  {
    public AutoMapperProfile()
    {
      CreateMap<Domain.Task, GetTasksListViewModel>().ReverseMap();
      CreateMap<Domain.Task, GetTaskDetailViewModel>().ReverseMap();
      CreateMap<Domain.Category, CategoryDto>().ReverseMap();
      CreateMap<Domain.Task, CreateTaskCommand>().ReverseMap();
      CreateMap<Domain.Task, UpdateTaskCommand>().ReverseMap();
      CreateMap<Domain.Task, DeleteTaskCommand>().ReverseMap();
    }
  }
}
