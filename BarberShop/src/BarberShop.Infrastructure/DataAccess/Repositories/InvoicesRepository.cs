using BarberShop.Domain.Entities;
using BarberShop.Domain.Repositories.Invoices;

namespace BarberShop.Infrastructure.DataAccess.Repositories;

internal class InvoicesRepository : IInvoicesWriteOnlyRepository
{
    private readonly BarShopDbContext _dbContext;

    public InvoicesRepository(BarShopDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task Add(Invoice invoice)
    {
        await _dbContext.Invoices.AddAsync(invoice);
    }
}
