using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.PersonalRecords.Queries.GetAllPersonalRecords;

public class GetAllPersonalRecordsQueryHandler : IRequestHandler<GetAllPersonalRecordsQuery, IEnumerable<PersonalRecordDto>>
{
    private readonly IPersonalRecordRepository _repository;

    public GetAllPersonalRecordsQueryHandler(IPersonalRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<PersonalRecordDto>> Handle(GetAllPersonalRecordsQuery request, CancellationToken cancellationToken)
    {
        var records = await _repository.GetAllAsync(cancellationToken);
        return records.Select(r => r.ToDto());
    }
}
