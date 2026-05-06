using Control14.Application.DTOs;
using Control14.Domain.Entities;

namespace Control14.Application.Mappings;

public static class NetworkRequestRecordMappingExtensions
{
    public static NetworkRequestRecordDto ToDto(this NetworkRequestRecord record)
    {
        return new NetworkRequestRecordDto(
            record.Id,
            record.NetworkRequestInfo,
            record.ClientIp,
            record.ServerIp,
            record.MacAddress,
            record.FqdnHost,
            record.TcpPort,
            record.NicId,
            record.OriginAsn,
            record.RequestHeaders,
            record.ResponseHeaders);
    }
}
