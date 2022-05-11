namespace KnightOnline.DotNet.Common.Extensions;

public static class SpanExtensions
{
    public static short GetShortFromFirstTwoBytes(this Span<byte> data) {
        return (short) ((data[1] << 8) + (data[0] & 0xff));
    }
}
