using System.Text.Json.Serialization;
using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.AiInferenceRecords.Commands.UpdateAiInferenceRecord;

public record UpdateAiInferenceRecordCommand(
    Guid Id,
    [property: JsonPropertyName("model_id")] string ModelId,
    [property: JsonPropertyName("model_version")] string ModelVersion,
    [property: JsonPropertyName("ai_risk_category")] string AiRiskCategory,
    [property: JsonPropertyName("eval_metric_score")] double EvalMetricScore,
    [property: JsonPropertyName("inference_output")] string InferenceOutput,
    [property: JsonPropertyName("training_example")] string TrainingExample,
    [property: JsonPropertyName("training_corpus_ref")] string TrainingCorpusRef,
    [property: JsonPropertyName("user_prompt")] string UserPrompt) : IRequest<AiInferenceRecordDto?>;
