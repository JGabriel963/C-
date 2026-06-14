using BarberShop.Application.UseCase.Invoices.Register;
using BarberShop.Communication.Requests;
using BarberShop.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BarberShop.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BillingsController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredInvoiceJson), StatusCodes.Status201Created)]
    public IActionResult Register(
        [FromBody] RequestInvoiceJson request,
        [FromServices] IRegisterInvoiceUseCase useCase)
    {
        var response = useCase.Execute(request);
        return Created(string.Empty, response);
    }
}
