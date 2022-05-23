namespace KnightOnline.DotNet.Common;

public readonly struct KnightOnlinePackage
{
    public byte OpCode { get; }
    public Memory<byte> Data { get; }

    public KnightOnlinePackage(byte opCode, Memory<byte> data)
    {
        OpCode = opCode;
        Data = data;
    }
}
