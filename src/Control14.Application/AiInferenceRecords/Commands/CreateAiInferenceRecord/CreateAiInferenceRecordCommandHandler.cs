using Control14.Application.Interfaces;
using Control14.Domain.Entities;
using MediatR;

namespace Control14.Application.AiInferenceRecords.Commands.CreateAiInferenceRecord;

public class CreateAiInferenceRecordCommandHandler : IRequestHandler<CreateAiInferenceRecordCommand, Guid>
{
    private readonly IAiInferenceRecordRepository _repository;

    public CreateAiInferenceRecordCommandHandler(IAiInferenceRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateAiInferenceRecordCommand request, CancellationToken cancellationToken)
    {
        var record = AiInferenceRecord.Create(
            request.ModelId,
            request.ModelVersion,
            request.AiRiskCategory,
            request.EvalMetricScore,
            request.InferenceOutput,
            request.TrainingExample,
            request.TrainingCorpusRef,
            request.UserPrompt);

        await _repository.AddAsync(record, cancellationToken);

        return record.Id;
    }
}
