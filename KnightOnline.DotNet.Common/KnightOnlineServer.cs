using System.Net;
using NetCoreServer;

namespace KnightOnline.DotNet.Common;

public class KnightOnlineServer<T> : TcpServer where T : KnightOnlineSession
{
    public KnightOnlineServer(IPAddress address, int port)
        : base(address, port)
    {
    }

    protected override TcpSession CreateSession()
    {
        return (T)Activator.CreateInstance(typeof(T), this)!;
    }
}
