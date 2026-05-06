using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.AiInferenceRecords.Queries.GetAllAiInferenceRecords;

public class GetAllAiInferenceRecordsQueryHandler : IRequestHandler<GetAllAiInferenceRecordsQuery, IEnumerable<AiInferenceRecordDto>>
{
    private readonly IAiInferenceRecordRepository _repository;

    public GetAllAiInferenceRecordsQueryHandler(IAiInferenceRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<AiInferenceRecordDto>> Handle(GetAllAiInferenceRecordsQuery request, CancellationToken cancellationToken)
    {
        var records = await _repository.GetAllAsync(cancellationToken);
        return records.Select(r => r.ToDto());
    }
}
