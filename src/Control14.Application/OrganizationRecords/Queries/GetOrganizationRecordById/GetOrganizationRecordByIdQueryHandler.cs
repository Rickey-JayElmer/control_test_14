using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.OrganizationRecords.Queries.GetOrganizationRecordById;

public class GetOrganizationRecordByIdQueryHandler : IRequestHandler<GetOrganizationRecordByIdQuery, OrganizationRecordDto?>
{
    private readonly IOrganizationRecordRepository _repository;

    public GetOrganizationRecordByIdQueryHandler(IOrganizationRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<OrganizationRecordDto?> Handle(GetOrganizationRecordByIdQuery request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);
        return record?.ToDto();
    }
}
