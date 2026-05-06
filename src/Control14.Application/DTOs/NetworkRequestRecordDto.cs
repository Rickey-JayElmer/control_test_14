namespace Control14.Application.DTOs;

public record NetworkRequestRecordDto(
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
    string ResponseHeaders);
