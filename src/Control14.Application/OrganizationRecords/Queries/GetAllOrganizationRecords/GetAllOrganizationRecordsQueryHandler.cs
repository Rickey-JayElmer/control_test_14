using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.OrganizationRecords.Queries.GetAllOrganizationRecords;

public class GetAllOrganizationRecordsQueryHandler : IRequestHandler<GetAllOrganizationRecordsQuery, IEnumerable<OrganizationRecordDto>>
{
    private readonly IOrganizationRecordRepository _repository;

    public GetAllOrganizationRecordsQueryHandler(IOrganizationRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<OrganizationRecordDto>> Handle(GetAllOrganizationRecordsQuery request, CancellationToken cancellationToken)
    {
        var records = await _repository.GetAllAsync(cancellationToken);
        return records.Select(r => r.ToDto());
    }
}
