using Bogus;
using CashFlow.Domain.Entities;
using CashFlow.Domain.Enums;

namespace CommonTestUtilities.Entities;

public class ExpenseBuilder
{
    public static List<Expense> Collection(User user, uint cont = 2)
    {
        var list = new List<Expense>();

        if (cont == 0)
            cont = 1;

        var expenseId = 1;

        for (int i = 0; i < cont; i++)
        {
            var expense = Build(user);
            expense.Id = expenseId++;

            list.Add(expense);
        }

        return list;
    }

    public static Expense Build(User user)
    {
        return new Faker<Expense>()
            .RuleFor(u => u.Id, _ => 1)
            .RuleFor(u => u.Title, faker => faker.Commerce.ProductName())
            .RuleFor(r => r.Description, faker => faker.Commerce.ProductDescription())
            .RuleFor(r => r.Date, faker => faker.Date.Past())
            .RuleFor(r => r.Amount, faker => faker.Random.Decimal(min: 1, max: 1000))
            .RuleFor(r => r.PaymentType, faker => faker.PickRandom<PaymentType>())
            .RuleFor(r => r.UserId, _ => user.Id);
    }
}
