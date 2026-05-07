using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.HrRecords.Queries.GetAllHrRecords;

public class GetAllHrRecordsQueryHandler : IRequestHandler<GetAllHrRecordsQuery, IEnumerable<HrRecordDto>>
{
    private readonly IHrRecordRepository _repository;

    public GetAllHrRecordsQueryHandler(IHrRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<HrRecordDto>> Handle(GetAllHrRecordsQuery request, CancellationToken cancellationToken)
    {
        var records = await _repository.GetAllAsync(cancellationToken);
        return records.Select(r => r.ToDto());
    }
}
