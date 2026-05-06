using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.AiInferenceRecords.Commands.UpdateAiInferenceRecord;

public class UpdateAiInferenceRecordCommandHandler : IRequestHandler<UpdateAiInferenceRecordCommand, AiInferenceRecordDto?>
{
    private readonly IAiInferenceRecordRepository _repository;

    public UpdateAiInferenceRecordCommandHandler(IAiInferenceRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<AiInferenceRecordDto?> Handle(UpdateAiInferenceRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return null;

        record.Update(
            request.ModelId,
            request.ModelVersion,
            request.AiRiskCategory,
            request.EvalMetricScore,
            request.InferenceOutput,
            request.TrainingExample,
            request.TrainingCorpusRef,
            request.UserPrompt);

        await _repository.UpdateAsync(record, cancellationToken);

        return record.ToDto();
    }
}
