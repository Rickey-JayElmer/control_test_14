using MediatR;

namespace Control14.Application.NetworkRequestRecords.Commands.CreateNetworkRequestRecord;

public record CreateNetworkRequestRecordCommand(
    string NetworkRequestInfo,
    string ClientIp,
    string ServerIp,
    string MacAddress,
    string FqdnHost,
    int TcpPort,
    string NicId,
    string OriginAsn,
    string RequestHeaders,
    string ResponseHeaders) : IRequest<Guid>;
