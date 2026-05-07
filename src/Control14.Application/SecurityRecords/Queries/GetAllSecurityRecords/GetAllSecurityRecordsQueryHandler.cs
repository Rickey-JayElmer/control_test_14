using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.SecurityRecords.Queries.GetAllSecurityRecords;

public class GetAllSecurityRecordsQueryHandler : IRequestHandler<GetAllSecurityRecordsQuery, IEnumerable<SecurityRecordDto>>
{
    private readonly ISecurityRecordRepository _repository;

    public GetAllSecurityRecordsQueryHandler(ISecurityRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<SecurityRecordDto>> Handle(GetAllSecurityRecordsQuery request, CancellationToken cancellationToken)
    {
        var records = await _repository.GetAllAsync(cancellationToken);
        return records.Select(r => r.ToDto());
    }
}
