using BarberShop.Application.UseCase.Invoices.Register;
using Microsoft.Extensions.DependencyInjection;

namespace BarberShop.Application;

public static class DependencyInjectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        AddUseCases(services);
    }

    private static void AddUseCases(IServiceCollection services)
    {
        services.AddScoped<IRegisterInvoiceUseCase, RegisterInvoiceUseCase>();
    }
}
