using BarberShop.Domain.Entities;

namespace BarberShop.Domain.Repositories.Invoices;

public interface IInvoicesWriteOnlyRepository
{
    Task Add(Invoice invoice);
}
