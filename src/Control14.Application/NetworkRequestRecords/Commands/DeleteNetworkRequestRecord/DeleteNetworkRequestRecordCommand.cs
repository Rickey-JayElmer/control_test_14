using MediatR;

namespace Control14.Application.NetworkRequestRecords.Commands.DeleteNetworkRequestRecord;

public record DeleteNetworkRequestRecordCommand(Guid Id) : IRequest<bool>;
