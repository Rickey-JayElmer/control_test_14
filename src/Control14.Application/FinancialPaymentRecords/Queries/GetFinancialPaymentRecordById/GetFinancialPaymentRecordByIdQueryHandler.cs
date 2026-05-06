using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.FinancialPaymentRecords.Queries.GetFinancialPaymentRecordById;

public class GetFinancialPaymentRecordByIdQueryHandler : IRequestHandler<GetFinancialPaymentRecordByIdQuery, FinancialPaymentRecordDto?>
{
    private readonly IFinancialPaymentRecordRepository _repository;

    public GetFinancialPaymentRecordByIdQueryHandler(IFinancialPaymentRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<FinancialPaymentRecordDto?> Handle(GetFinancialPaymentRecordByIdQuery request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);
        return record?.ToDto();
    }
}
