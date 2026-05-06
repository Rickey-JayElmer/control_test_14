using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.FinancialPaymentRecords.Queries.GetAllFinancialPaymentRecords;

public class GetAllFinancialPaymentRecordsQueryHandler : IRequestHandler<GetAllFinancialPaymentRecordsQuery, IEnumerable<FinancialPaymentRecordDto>>
{
    private readonly IFinancialPaymentRecordRepository _repository;

    public GetAllFinancialPaymentRecordsQueryHandler(IFinancialPaymentRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<FinancialPaymentRecordDto>> Handle(GetAllFinancialPaymentRecordsQuery request, CancellationToken cancellationToken)
    {
        var records = await _repository.GetAllAsync(cancellationToken);
        return records.Select(r => r.ToDto());
    }
}
