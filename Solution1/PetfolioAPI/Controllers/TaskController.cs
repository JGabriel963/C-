using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Task.Create;
using Petfolio.Application.UseCases.Task.GetAll;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses.Errors;
using Petfolio.Communication.Responses.Task;

namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreatedTaskJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestTaskJson request)
    {
        var useCase = new CreateTaskUseCase();
        var response = useCase.Execute(request);
        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllTaskUseCase();

        var response = useCase.Execute();

        return Ok(response);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Get([FromRoute]  int id)
    {
        return Ok();
    }

    [HttpPut]
    [Route("{id}")]
    public IActionResult Update([FromRoute] int id)
    {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    public IActionResult Delete([FromRoute] int id)
    {
        return NoContent();
    }
}
