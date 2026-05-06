using Control14.Application.DTOs;
using Control14.Domain.Entities;

namespace Control14.Application.Mappings;

public static class AiInferenceRecordMappingExtensions
{
    public static AiInferenceRecordDto ToDto(this AiInferenceRecord record)
    {
        return new AiInferenceRecordDto(
            record.Id,
            record.ModelId,
            record.ModelVersion,
            record.AiRiskCategory,
            record.EvalMetricScore,
            record.InferenceOutput,
            record.TrainingExample,
            record.TrainingCorpusRef,
            record.UserPrompt);
    }
}
