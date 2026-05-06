using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.AiInferenceRecords.Commands.UpdateAiInferenceRecord;

public record UpdateAiInferenceRecordCommand(
    Guid Id,
    string ModelId,
    string ModelVersion,
    string AiRiskCategory,
    double EvalMetricScore,
    string InferenceOutput,
    string TrainingExample,
    string TrainingCorpusRef,
    string UserPrompt) : IRequest<AiInferenceRecordDto?>;
