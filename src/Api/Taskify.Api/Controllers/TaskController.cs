using Taskify.Application.Features.Tasks.Commands.CreateTask;
using Taskify.Application.Features.Tasks.Commands.DeleteTask;
using Taskify.Application.Features.Tasks.Commands.UpdateTask;
using Taskify.Application.Features.Tasks.Queries.GetTaskDetail;
using Taskify.Application.Features.Tasks.Queries.GetTaskList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Taskify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TaskController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllTasks")]
        public async Task<ActionResult<List<GetTasksListViewModel>>> GetAllTasks()
        {
            var dtos = await _mediator.Send(new GetTasksListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetTaskById")]
        public async Task<ActionResult<GetTaskDetailViewModel>> GetTaskById(Guid id)
        {
            var getEventDetailQuery = new GetTaskDetailQuery() { TaskId = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        [HttpPost(Name = "AddTask")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateTaskCommand createTaskCommand)
        {
            Guid id = await _mediator.Send(createTaskCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateTask")]
        public async Task<ActionResult> Update([FromBody] UpdateTaskCommand updateTaskCommand)
        {
            await _mediator.Send(updateTaskCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteTask")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteTaskCommand = new DeleteTaskCommand() { TaskId = id };
            await _mediator.Send(deleteTaskCommand);
            return NoContent();
        }

    }
}
