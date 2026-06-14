using BarberShop.Communication.Requests;
using BarberShop.Communication.Responses;

namespace BarberShop.Application.UseCase.Invoices.Register;

public class RegisterInvoiceUseCase : IRegisterInvoiceUseCase
{
    public ResponseRegisteredInvoiceJson Execute(RequestInvoiceJson request)
    {
        return new ResponseRegisteredInvoiceJson
        {
            Amount = request.Amount,
            BarberName = request.BarberName,
            ClientName = request.ClientName,
            ServiceName = request.ServiceName
        };
    }
}
