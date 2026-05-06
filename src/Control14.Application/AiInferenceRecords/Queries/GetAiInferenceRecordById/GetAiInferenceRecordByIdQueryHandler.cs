using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.AiInferenceRecords.Queries.GetAiInferenceRecordById;

public class GetAiInferenceRecordByIdQueryHandler : IRequestHandler<GetAiInferenceRecordByIdQuery, AiInferenceRecordDto?>
{
    private readonly IAiInferenceRecordRepository _repository;

    public GetAiInferenceRecordByIdQueryHandler(IAiInferenceRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<AiInferenceRecordDto?> Handle(GetAiInferenceRecordByIdQuery request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);
        return record?.ToDto();
    }
}
