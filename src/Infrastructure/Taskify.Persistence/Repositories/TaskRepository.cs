using Taskify.Application.Contracts;
using Taskify.Domain;
using Microsoft.EntityFrameworkCore;

namespace Taskify.Persistence
{
  public class TaskRepository : BaseRepository<Task>, ITaskRepository
  {
    public TaskRepository(TaskDbContext taskDbContext) : base(taskDbContext)
    {

    }
    public async Task<IReadOnlyList<Task>> GetAllTasksAsync(bool includeCategory)
    {
      List<Task> allTasks = new List<Task>();
      allTasks = includeCategory ? await _dbContext.Tasks.Include(x => x.Category).ToListAsync() : await _dbContext.Tasks.ToListAsync();
      return allTasks;
    }

    public async Task<Task> GetTaskByIdAsync(Guid id, bool includeCategory)
    {
      var Task = new Task();
      Task = includeCategory ? await _dbContext.Tasks.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id) : await GetByIdAsync(id);
      return Task;
    }
  }

}
