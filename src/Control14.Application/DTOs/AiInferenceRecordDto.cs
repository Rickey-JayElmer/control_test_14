namespace Control14.Application.DTOs;

public record AiInferenceRecordDto(
    Guid Id,
    string ModelId,
    string ModelVersion,
    string AiRiskCategory,
    double EvalMetricScore,
    string InferenceOutput,
    string TrainingExample,
    string TrainingCorpusRef,
    string UserPrompt);
