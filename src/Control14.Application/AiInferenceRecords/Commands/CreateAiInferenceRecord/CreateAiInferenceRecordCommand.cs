using MediatR;

namespace Control14.Application.AiInferenceRecords.Commands.CreateAiInferenceRecord;

public record CreateAiInferenceRecordCommand(
    string ModelId,
    string ModelVersion,
    string AiRiskCategory,
    double EvalMetricScore,
    string InferenceOutput,
    string TrainingExample,
    string TrainingCorpusRef,
    string UserPrompt) : IRequest<Guid>;
