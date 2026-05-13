using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pet.Register;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredPetJson), StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestRegisterPetJson request)
    {
        var userCase = new RegisterPetUserCase();

        var response = userCase.Execute(request);

        return Created(string.Empty, response);
    }
}
