using KnightOnline.DotNet.Common;
using KnightOnline.DotNet.Common.Extensions;
using NetCoreServer;

namespace KnightOnline.DotNet.LoginServer;

public class LoginSession : KnightOnlineSession
{
    public LoginSession(TcpServer server) : base(server)
    {
    }

    protected override async void HandlePackage(KnightOnlinePackage package)
    {
        KnightOnlinePackage responsePackage = default;
        switch ((LoginOpCode)package.OpCode)
        {
            case LoginOpCode.LsVersionReq:
                responsePackage = HandleVersionRequest();
                break;
            case LoginOpCode.LsDownloadInfoReq:
                responsePackage = HandleDownloadInfoRequest(package);
                break;
            case LoginOpCode.LsCryption:
                break;
            case LoginOpCode.LsLogin:
                break;
            case LoginOpCode.LsServerlist:
                break;
            case LoginOpCode.LsUnknowF7:
                break;
            case LoginOpCode.LsNews:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        SendResponse(responsePackage);
    }

    private KnightOnlinePackage HandleDownloadInfoRequest(in KnightOnlinePackage request)
    {
        var clientVersion = request.Data.GetShort(1);

        throw new NotImplementedException();
    }

    private static KnightOnlinePackage HandleVersionRequest()
    {
        var data = ArrayUtils.ToByteArray(LoginConfig.Version);

        return new KnightOnlinePackage((byte)LoginOpCode.LsVersionReq, data);
    }
}
