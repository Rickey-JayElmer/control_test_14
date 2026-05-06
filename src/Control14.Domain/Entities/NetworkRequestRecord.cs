namespace Control14.Domain.Entities;

public class NetworkRequestRecord
{
    public Guid Id { get; private set; }
    public string NetworkRequestInfo { get; private set; } = string.Empty;
    public string ClientIp { get; private set; } = string.Empty;
    public string ServerIp { get; private set; } = string.Empty;
    public string MacAddress { get; private set; } = string.Empty;
    public string FqdnHost { get; private set; } = string.Empty;
    public int TcpPort { get; private set; }
    public string NicId { get; private set; } = string.Empty;
    public string OriginAsn { get; private set; } = string.Empty;
    public string RequestHeaders { get; private set; } = string.Empty;
    public string ResponseHeaders { get; private set; } = string.Empty;

    private NetworkRequestRecord() { }

    public static NetworkRequestRecord Create(
        string networkRequestInfo,
        string clientIp,
        string serverIp,
        string macAddress,
        string fqdnHost,
        int tcpPort,
        string nicId,
        string originAsn,
        string requestHeaders,
        string responseHeaders)
    {
        return new NetworkRequestRecord
        {
            Id = Guid.NewGuid(),
            NetworkRequestInfo = networkRequestInfo,
            ClientIp = clientIp,
            ServerIp = serverIp,
            MacAddress = macAddress,
            FqdnHost = fqdnHost,
            TcpPort = tcpPort,
            NicId = nicId,
            OriginAsn = originAsn,
            RequestHeaders = requestHeaders,
            ResponseHeaders = responseHeaders
        };
    }

    public void Update(
        string networkRequestInfo,
        string clientIp,
        string serverIp,
        string macAddress,
        string fqdnHost,
        int tcpPort,
        string nicId,
        string originAsn,
        string requestHeaders,
        string responseHeaders)
    {
        NetworkRequestInfo = networkRequestInfo;
        ClientIp = clientIp;
        ServerIp = serverIp;
        MacAddress = macAddress;
        FqdnHost = fqdnHost;
        TcpPort = tcpPort;
        NicId = nicId;
        OriginAsn = originAsn;
        RequestHeaders = requestHeaders;
        ResponseHeaders = responseHeaders;
    }
}
