namespace KnightOnline.DotNet.Common.Extensions;

public static class SpanExtensions
{
    public static short GetShortFromFirstTwoBytes(this Memory<byte> data) {
        return (short) ((data.Span[1] << 8) + (data.Span[0] & 0xff));
    }

    public static short GetShort(this Memory<byte> data, int startPosition)
    {
        short value = 0;
        for (int i = 0; i < data.Length - startPosition; i++)
        {
            value += (short)((data.Span[i+startPosition] & 0xffL) << (8 * i));
        }

        return value;
    }
}
