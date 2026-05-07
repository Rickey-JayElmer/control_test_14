using MediatR;

namespace Control14.Application.HrRecords.Commands.DeleteHrRecord;

public record DeleteHrRecordCommand(Guid Id) : IRequest<bool>;
