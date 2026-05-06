using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.NetworkRequestRecords.Commands.UpdateNetworkRequestRecord;

public record UpdateNetworkRequestRecordCommand(
    Guid Id,
    string NetworkRequestInfo,
    string ClientIp,
    string ServerIp,
    string MacAddress,
    string FqdnHost,
    int TcpPort,
    string NicId,
    string OriginAsn,
    string RequestHeaders,
    string ResponseHeaders) : IRequest<NetworkRequestRecordDto?>;
