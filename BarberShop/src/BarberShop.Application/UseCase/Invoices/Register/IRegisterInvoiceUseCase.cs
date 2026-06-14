using BarberShop.Communication.Requests;
using BarberShop.Communication.Responses;

namespace BarberShop.Application.UseCase.Invoices.Register;

public interface IRegisterInvoiceUseCase
{
    ResponseRegisteredInvoiceJson Execute(RequestInvoiceJson request);
}
