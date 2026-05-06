using Control14.Application.Interfaces;
using MediatR;

namespace Control14.Application.FinancialPaymentRecords.Commands.DeleteFinancialPaymentRecord;

public class DeleteFinancialPaymentRecordCommandHandler : IRequestHandler<DeleteFinancialPaymentRecordCommand, bool>
{
    private readonly IFinancialPaymentRecordRepository _repository;

    public DeleteFinancialPaymentRecordCommandHandler(IFinancialPaymentRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(DeleteFinancialPaymentRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return false;

        await _repository.DeleteAsync(record, cancellationToken);

        return true;
    }
}
