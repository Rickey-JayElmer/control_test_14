using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.LegalRecords.Queries.GetLegalRecordById;

public class GetLegalRecordByIdQueryHandler : IRequestHandler<GetLegalRecordByIdQuery, LegalRecordDto?>
{
    private readonly ILegalRecordRepository _repository;

    public GetLegalRecordByIdQueryHandler(ILegalRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<LegalRecordDto?> Handle(GetLegalRecordByIdQuery request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);
        return record?.ToDto();
    }
}
