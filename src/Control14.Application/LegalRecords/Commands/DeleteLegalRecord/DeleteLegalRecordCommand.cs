using MediatR;

namespace Control14.Application.LegalRecords.Commands.DeleteLegalRecord;

public record DeleteLegalRecordCommand(Guid Id) : IRequest<bool>;
