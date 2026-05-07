using MediatR;

namespace Control14.Application.SecurityRecords.Commands.DeleteSecurityRecord;

public record DeleteSecurityRecordCommand(Guid Id) : IRequest<bool>;
