using MediatR;

namespace Control14.Application.AiInferenceRecords.Commands.DeleteAiInferenceRecord;

public record DeleteAiInferenceRecordCommand(Guid Id) : IRequest<bool>;
