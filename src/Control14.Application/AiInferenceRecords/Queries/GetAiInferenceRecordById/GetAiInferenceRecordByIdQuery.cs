using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.AiInferenceRecords.Queries.GetAiInferenceRecordById;

public record GetAiInferenceRecordByIdQuery(Guid Id) : IRequest<AiInferenceRecordDto?>;
