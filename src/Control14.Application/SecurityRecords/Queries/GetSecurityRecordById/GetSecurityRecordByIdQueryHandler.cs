using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.SecurityRecords.Queries.GetSecurityRecordById;

public class GetSecurityRecordByIdQueryHandler : IRequestHandler<GetSecurityRecordByIdQuery, SecurityRecordDto?>
{
    private readonly ISecurityRecordRepository _repository;

    public GetSecurityRecordByIdQueryHandler(ISecurityRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<SecurityRecordDto?> Handle(GetSecurityRecordByIdQuery request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);
        return record?.ToDto();
    }
}
