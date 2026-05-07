using Control14.Application.Interfaces;
using Control14.Domain.Entities;
using MediatR;

namespace Control14.Application.NetworkRequestRecords.Commands.CreateNetworkRequestRecord;

public class CreateNetworkRequestRecordCommandHandler : IRequestHandler<CreateNetworkRequestRecordCommand, Guid>
{
    private readonly INetworkRequestRecordRepository _repository;

    public CreateNetworkRequestRecordCommandHandler(INetworkRequestRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateNetworkRequestRecordCommand request, CancellationToken cancellationToken)
    {
        var record = NetworkRequestRecord.Create(
            request.NetworkRequestInfo,
            request.ClientIp,
            request.ServerIp,
            request.MacAddress,
            request.FqdnHost,
            request.TcpPort,
            request.NicId,
            request.OriginAsn,
            request.RequestHeaders,
            request.ResponseHeaders,
            request.RemoteAddr,
            request.XForwardedFor,
            request.HardwareAddress);

        await _repository.AddAsync(record, cancellationToken);

        return record.Id;
    }
}
