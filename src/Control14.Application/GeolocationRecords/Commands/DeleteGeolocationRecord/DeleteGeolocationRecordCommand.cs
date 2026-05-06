using MediatR;

namespace Control14.Application.GeolocationRecords.Commands.DeleteGeolocationRecord;

public record DeleteGeolocationRecordCommand(Guid Id) : IRequest<bool>;
