using MediatR;

namespace Control14.Application.PersonalRecords.Commands.DeletePersonalRecord;

public record DeletePersonalRecordCommand(Guid Id) : IRequest<bool>;
