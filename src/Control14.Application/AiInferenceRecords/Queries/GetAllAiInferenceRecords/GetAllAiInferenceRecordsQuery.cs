using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.AiInferenceRecords.Queries.GetAllAiInferenceRecords;

public record GetAllAiInferenceRecordsQuery() : IRequest<IEnumerable<AiInferenceRecordDto>>;
