using BarberShop.Domain.Entities;

namespace BarberShop.Domain.Repositories.Invoices;

public interface IInvoicesReadOnlyRepository
{
    Task<List<Invoice>> GetAll();
}
