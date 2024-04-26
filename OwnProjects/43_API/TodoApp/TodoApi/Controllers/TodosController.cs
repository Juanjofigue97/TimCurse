using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using TodoLibrary.DataAccess;
using TodoLibrary.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodosController : ControllerBase
{
    private readonly ITodoData _data;
    private readonly ILogger<TodosController> _logger;

    public TodosController(ITodoData data, ILogger<TodosController> logger)
    {
        _data = data;
        _logger = logger;
    }

    private int GetUserId()
    {
        var varIdText = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
        var userId = int.Parse(varIdText);
        return userId;
    }

    [HttpGet(Name = "GetAllTodos")]
    public async Task<ActionResult<List<TodoModel>>> Get()
    {
        _logger.LogInformation("GET: api/Todos");

        try
        {
            var output = await _data.GetAllAssigned(GetUserId());
            return Ok(output);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "The GET call api/Todos failed");
            return BadRequest();
        }

    }

    // GET api/Todos/5
    [HttpGet("{todoId}", Name = "GetOneTodos")]
    public async Task<ActionResult<TodoModel>> Get(int todoId)
    {
        _logger.LogInformation("GET: api/Todos{TodoId}",todoId);

        try
        {
            var output = await _data.GetOneAssigned(GetUserId(), todoId);
            return Ok(output);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "The GET call to {ApiPath} failed", $"api/Todos/{todoId}");
            return BadRequest();
        }
    }

    // POST api/<TodosController>
    [HttpPost(Name = "CreateTodos")]
    public async Task<ActionResult<TodoModel>> Post([FromBody] string task)
    {
        _logger.LogInformation("POST: api/Todos (Task: {Task})", task);

        try
        {
            var output = await _data.Create(GetUserId(), task);
            return Ok(output);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "The PUT call to {ApiPath} failed", $"api/Todos/{task}");
            return BadRequest();
        }
    }

    // PUT api/Todos/5
    [HttpPut("{todoId}", Name = "UpdateTodos")]
    public async Task<ActionResult> Put(int todoId, [FromBody] string task)
    {
        _logger.LogInformation("POST: api/Todos/{TodoId} (Task: {Task})",todoId, task);

        try
        {
            await _data.UpdateTask(GetUserId(), todoId, task);
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "The PUT call to api/Todos/{TodoId} failed. Task value was {Task}", todoId,task);
            return BadRequest();
        }
    }
    // PUT api/Todos/5
    [HttpPut("{todoId}/Complete",Name = "CompleteTodos")]
    public async Task<IActionResult> Complete(int todoId)
    {
        _logger.LogInformation("POST: api/Todos/{TodoId}/Complete ", todoId);

        try
        {
            await _data.CompleteTodo(GetUserId(), todoId);
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "The PUT call to api/Todos/{TodoId}/Complete failed.", todoId);
            return BadRequest();
        }
    }

    // DELETE api/<TodosController>/5
    [HttpDelete("{todoId}",Name ="DeleteTodos")]
    public async Task<IActionResult> Delete(int todoId)
    {
        _logger.LogInformation("DELETE: api/Todos/{TodoId}/ ", todoId);

        try
        {
            await _data.Delete(GetUserId(), todoId);
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "The DELETE call to api/Todos/{TodoId} failed.", todoId);
            return BadRequest();
        }

    }
}
