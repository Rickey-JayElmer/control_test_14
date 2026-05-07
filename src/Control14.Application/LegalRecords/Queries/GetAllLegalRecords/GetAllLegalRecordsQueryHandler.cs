using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.LegalRecords.Queries.GetAllLegalRecords;

public class GetAllLegalRecordsQueryHandler : IRequestHandler<GetAllLegalRecordsQuery, IEnumerable<LegalRecordDto>>
{
    private readonly ILegalRecordRepository _repository;

    public GetAllLegalRecordsQueryHandler(ILegalRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<LegalRecordDto>> Handle(GetAllLegalRecordsQuery request, CancellationToken cancellationToken)
    {
        var records = await _repository.GetAllAsync(cancellationToken);
        return records.Select(r => r.ToDto());
    }
}
