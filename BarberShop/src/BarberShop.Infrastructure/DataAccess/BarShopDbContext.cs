using BarberShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BarberShop.Infrastructure.DataAccess;

internal class BarShopDbContext: DbContext
{
    public BarShopDbContext(DbContextOptions options): base(options) { }
    public DbSet<Invoice> Invoices { get; set; }
}
