namespace BitTools;

public static class BitContainer
{
    public static byte SByteToByte(sbyte val) => unchecked((byte)val);

    public static sbyte ByteToSByte(byte val) => unchecked((sbyte)val);

    public static short UShortToShort(ushort val) => unchecked((short)val);

    public static ushort ShortToUShort(short val) => unchecked((ushort)val);

    public static int UIntToInt(uint val) => unchecked((int)val);

    public static uint IntToUInt(int val) => unchecked((uint)val);

    public static long ULongToLong(ulong val) => unchecked((long)val);

    public static ulong LongToULong(long val) => unchecked((ulong)val);
}