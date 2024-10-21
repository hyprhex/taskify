namespace Taskify.Application.Contracts
{
  public interface ITaskRepository : IAsyncRepository<Task>
  {
    Task<IReadOnlyList<Task>> GetAllTasksAsync(bool includeCategory);
    Task<Task> GetTaskByIdAsync(Guid id, bool includeCategory);
  }
}
