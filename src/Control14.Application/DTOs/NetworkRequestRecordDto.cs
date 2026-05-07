using System.Text.Json.Serialization;

namespace Control14.Application.DTOs;

public record NetworkRequestRecordDto(
    Guid Id,
    [property: JsonPropertyName("network_request_info")] string NetworkRequestInfo,
    [property: JsonPropertyName("client_ip")] string ClientIp,
    [property: JsonPropertyName("server_ip")] string ServerIp,
    [property: JsonPropertyName("mac_address")] string MacAddress,
    [property: JsonPropertyName("fqdn_host")] string FqdnHost,
    [property: JsonPropertyName("tcp_port")] int TcpPort,
    [property: JsonPropertyName("nic_id")] string NicId,
    [property: JsonPropertyName("origin_asn")] string OriginAsn,
    [property: JsonPropertyName("request_headers")] string RequestHeaders,
    [property: JsonPropertyName("response_headers")] string ResponseHeaders,
    [property: JsonPropertyName("remote_addr")] string RemoteAddr,
    [property: JsonPropertyName("x_forwarded_for")] string XForwardedFor,
    [property: JsonPropertyName("hardware_address")] string HardwareAddress);
