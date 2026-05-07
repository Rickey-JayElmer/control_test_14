using MediatR;

namespace Control14.Application.OrganizationRecords.Commands.DeleteOrganizationRecord;

public record DeleteOrganizationRecordCommand(Guid Id) : IRequest<bool>;
