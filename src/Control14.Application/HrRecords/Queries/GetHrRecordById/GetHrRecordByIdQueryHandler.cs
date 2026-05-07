using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.HrRecords.Queries.GetHrRecordById;

public class GetHrRecordByIdQueryHandler : IRequestHandler<GetHrRecordByIdQuery, HrRecordDto?>
{
    private readonly IHrRecordRepository _repository;

    public GetHrRecordByIdQueryHandler(IHrRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<HrRecordDto?> Handle(GetHrRecordByIdQuery request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);
        return record?.ToDto();
    }
}
