using AutoMapper;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Exception;
using CashFlow.Exception.ExceptionsBase;

namespace CashFlow.Application.UseCase.Expenses.GetById;

public class GetExpenseByIdUseCase : IGetExpenseByIdUseCase
{
    private readonly IExpensesReadOnlyRepository _repository;
    private readonly IMapper _mapper;
    public GetExpenseByIdUseCase(IExpensesReadOnlyRepository respository, IMapper mapper)
    {
        _repository = respository;
        _mapper = mapper;
    }
    public async Task<ResponseExpenseJson> Execute(long id)
    {
        var result = await _repository.GetById(id);

        if (result is null)
        {
            throw new NotFoundException(ResourceErrorMessages.EXPENSE_NOT_FOUND);
        }

        return _mapper.Map<ResponseExpenseJson>(result);
    }
}
