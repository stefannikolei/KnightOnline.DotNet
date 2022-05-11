namespace KnightOnline.DotNet.Common;

public enum LoginOpCode
{
    LsVersionReq = 0x01,
    LsDownloadinfoReq = 0x0002,
    LsCryption = 0x00F2,
    LsLogin = 0x00F3,
    LsServerlist = 0x00F5,
    LsUnknowF7 = 0x00F7,
    LsNews = 0x00F6,
}
