namespace BitTools;

public static class BitShift
{
    public static byte Left(byte x, int amount) => (byte)(x << (amount & 0b111));
    public static sbyte Left(sbyte x, int amount) => (sbyte)(x << (amount & 0b111));
    public static short Left(short x, int amount) => (short)(x << (amount & 0b1111));
    public static ushort Left(ushort x, int amount) => (ushort)(x << (amount & 0b1111));
    public static int Left(int x, int amount) => x << amount;
    public static uint Left(uint x, int amount) => x << amount;
    public static long Left(long x, int amount) => x << amount;
    public static ulong Left(ulong x, int amount) => x << amount;


    public static byte Right(byte x, int amount) => (byte)(((x << 24) >> (amount & 0b111)) >> 24);
    public static sbyte Right(sbyte x, int amount) => (sbyte)(((x << 24) >> (amount & 0b111)) >> 24);
    public static short Right(short x, int amount) => (short)(((x << 16) >> (amount & 0b1111)) >> 16);
    public static ushort Right(ushort x, int amount) => (ushort)(((x << 16) >> (amount & 0b1111)) >> 16);
    public static int Right(int x, int amount) => x >> amount;
    public static uint Right(uint x, int amount) => x >> amount;
    public static long Right(long x, int amount) => x >> amount;
    public static ulong Right(ulong x, int amount) => x >> amount;


    public static byte RightNoCopy(byte x, int amount) => (byte)(Right(x, amount) & BitMask.MakeZerosFromLeftByte(amount));
    public static sbyte RightNoCopy(sbyte x, int amount) => (sbyte)(Right(x, amount) & BitMask.MakeZerosFromLeftByte(amount));
    public static short RightNoCopy(short x, int amount) => (short)(Right(x, amount) & BitMask.MakeZerosFromLeftShort(amount));
    public static ushort RightNoCopy(ushort x, int amount) => (ushort)(Right(x, amount) & BitMask.MakeZerosFromLeftShort(amount));
    public static int RightNoCopy(int x, int amount) => (int)(Right(x, amount) & BitMask.MakeZerosFromLeftInt(amount));
    public static uint RightNoCopy(uint x, int amount) => (uint)(Right(x, amount) & BitContainer.IntToUInt(BitMask.MakeZerosFromLeftInt(amount)));
    public static long RightNoCopy(long x, int amount) => (long)(Right(x, amount) & BitMask.MakeZerosFromLeftLong(amount));
    public static ulong RightNoCopy(ulong x, int amount) => (ulong)(Right(x, amount) & BitContainer.LongToULong(BitMask.MakeZerosFromLeftLong(amount)));
}