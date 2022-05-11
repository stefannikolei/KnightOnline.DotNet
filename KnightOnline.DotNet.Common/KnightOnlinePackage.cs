namespace KnightOnline.DotNet.Common;

public readonly ref struct KnightOnlinePackage
{
    public byte OpCode { get; }
    public Span<byte> Data { get; }

    public KnightOnlinePackage(byte opCode, Span<byte> data)
    {
        OpCode = opCode;
        Data = data;
    }
}
