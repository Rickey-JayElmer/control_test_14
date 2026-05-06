namespace Control14.Domain.Entities;

public class AiInferenceRecord
{
    public Guid Id { get; private set; }
    public string ModelId { get; private set; } = string.Empty;
    public string ModelVersion { get; private set; } = string.Empty;
    public string AiRiskCategory { get; private set; } = string.Empty;
    public double EvalMetricScore { get; private set; }
    public string InferenceOutput { get; private set; } = string.Empty;
    public string TrainingExample { get; private set; } = string.Empty;
    public string TrainingCorpusRef { get; private set; } = string.Empty;
    public string UserPrompt { get; private set; } = string.Empty;

    private AiInferenceRecord() { }

    public static AiInferenceRecord Create(
        string modelId,
        string modelVersion,
        string aiRiskCategory,
        double evalMetricScore,
        string inferenceOutput,
        string trainingExample,
        string trainingCorpusRef,
        string userPrompt)
    {
        return new AiInferenceRecord
        {
            Id = Guid.NewGuid(),
            ModelId = modelId,
            ModelVersion = modelVersion,
            AiRiskCategory = aiRiskCategory,
            EvalMetricScore = evalMetricScore,
            InferenceOutput = inferenceOutput,
            TrainingExample = trainingExample,
            TrainingCorpusRef = trainingCorpusRef,
            UserPrompt = userPrompt
        };
    }

    public void Update(
        string modelId,
        string modelVersion,
        string aiRiskCategory,
        double evalMetricScore,
        string inferenceOutput,
        string trainingExample,
        string trainingCorpusRef,
        string userPrompt)
    {
        ModelId = modelId;
        ModelVersion = modelVersion;
        AiRiskCategory = aiRiskCategory;
        EvalMetricScore = evalMetricScore;
        InferenceOutput = inferenceOutput;
        TrainingExample = trainingExample;
        TrainingCorpusRef = trainingCorpusRef;
        UserPrompt = userPrompt;
    }
}
