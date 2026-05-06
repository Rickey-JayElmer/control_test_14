using Control14.Application.Interfaces;
using Control14.Domain.Entities;
using MediatR;

namespace Control14.Application.FinancialPaymentRecords.Commands.CreateFinancialPaymentRecord;

public class CreateFinancialPaymentRecordCommandHandler : IRequestHandler<CreateFinancialPaymentRecordCommand, Guid>
{
    private readonly IFinancialPaymentRecordRepository _repository;

    public CreateFinancialPaymentRecordCommandHandler(IFinancialPaymentRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateFinancialPaymentRecordCommand request, CancellationToken cancellationToken)
    {
        var record = FinancialPaymentRecord.Create(
            request.BankAccountNumber,
            request.SortCode,
            request.Iban,
            request.SwiftBic,
            request.CardPan,
            request.CardExpiry,
            request.CardCvv,
            request.CardholderName,
            request.CardToken);

        await _repository.AddAsync(record, cancellationToken);

        return record.Id;
    }
}
