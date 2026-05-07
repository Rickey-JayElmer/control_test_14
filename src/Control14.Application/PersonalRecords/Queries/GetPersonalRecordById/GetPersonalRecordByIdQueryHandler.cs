using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.PersonalRecords.Queries.GetPersonalRecordById;

public class GetPersonalRecordByIdQueryHandler : IRequestHandler<GetPersonalRecordByIdQuery, PersonalRecordDto?>
{
    private readonly IPersonalRecordRepository _repository;

    public GetPersonalRecordByIdQueryHandler(IPersonalRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<PersonalRecordDto?> Handle(GetPersonalRecordByIdQuery request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);
        return record?.ToDto();
    }
}
