namespace KnightOnline.DotNet.Common;

public static class ArrayUtils
{
    public static byte[] ToByteArray(int value)
    {
        byte[] ret = new byte[2];
        ret[0] = (byte)(value & 0xff);
        ret[1] = (byte)((value >> 8) & 0xff);
        return ret;
    }
}
