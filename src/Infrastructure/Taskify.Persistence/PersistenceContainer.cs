using Taskify.Application.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Taskify.Persistence
{
  public static class PersistenceContainer
  {
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
      services.AddDbContext<TaskDbContext>(options =>
          options.UseSqlServer(configuration.GetConnectionString("TaskConnectionString")));

      services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
      services.AddScoped(typeof(ITaskRepository), typeof(TaskRepository));

      return services;
    }
  }

}
