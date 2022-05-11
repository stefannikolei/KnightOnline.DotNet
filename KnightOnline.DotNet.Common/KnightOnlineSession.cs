using KnightOnline.DotNet.Common.Extensions;
using NetCoreServer;

namespace KnightOnline.DotNet.Common;

public abstract class KnightOnlineSession : TcpSession
{
    public KnightOnlineSession(TcpServer server) : base(server)
    {
    }

    protected override void OnReceived(byte[] buffer, long offset, long size)
    {
        if (TryParsePackage(buffer, out var package))
        {
            HandlePackage(package);
        }
    }

    private static bool TryParsePackage(byte[] buffer, out KnightOnlinePackage package)
    {
        var inputData = buffer.AsSpan();

        if (inputData.GetShortFromFirstTwoBytes() != 0x55AA)
        {
            package = default;
            return false;
        }

        var length = inputData.Slice(2, 2).GetShortFromFirstTwoBytes();

        var opCode = inputData[4];
        var data = inputData.Slice(4, length);
        var beginOfTail = length + 4;
        if (inputData[0] != inputData[beginOfTail + 1] || inputData[1] != inputData[beginOfTail])
        {
            package = default;
            return false;
        }

        package = new KnightOnlinePackage(opCode, data);

        return true;
    }

    protected abstract void HandlePackage(KnightOnlinePackage package);

    protected void SendResponse(KnightOnlinePackage package)
    {
        Span<byte> result = stackalloc byte[package.Data.Length + 7];

        // Header
        result[0] = 0xAA;
        result[1] = 0x55;

        // Tail
        result[^2] = 0x55;
        result[^1] = 0xAA;


        var lengthData = ArrayUtils.ToByteArray(package.Data.Length);

        var opcodeBytes = new byte[]
        {
            package.OpCode
        };

        result[2] = lengthData[0];
        result[3] = lengthData[1];
        result[4] = package.OpCode;

        for (var i = 0; i < package.Data.Length ; i++)
        {
            result[i + 5] = package.Data[i];
        }
        
        // byte[] data = packet.getData();
        // byte[] opcodeBytes = new byte[] { (byte) packet.getOpcode() };
        // byte[] tail = new byte[] { 85, -86 };
        //
        // packet.setData(header);
        // packet.appendData(length);
        // packet.appendData(data);
        // packet.appendData(tail);
        //         
        this.Send(result.ToArray());
    }
}
