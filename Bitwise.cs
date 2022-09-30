namespace BitTools;

public static class Bitwise
{
    public static byte Or(byte value1, byte value2) => (byte)(value1 | value2);
    public static sbyte Or(sbyte value1, sbyte value2) => (sbyte)(value1 | value2);
    public static short Or(short value1, short value2) => (short)(value1 | value2);
    public static ushort Or(ushort value1, ushort value2) => (ushort)(value1 | value2);
    public static int Or(int value1, int value2) => value1 | value2;
    public static uint Or(uint value1, uint value2) => value1 | value2;
    public static long Or(long value1, long value2) => value1 | value2;
    public static ulong Or(ulong value1, ulong value2) => value1 | value2;


    public static byte And(byte value1, byte value2) => (byte)(value1 & value2);
    public static sbyte And(sbyte value1, sbyte value2) => (sbyte)(value1 & value2);
    public static short And(short value1, short value2) => (short)(value1 & value2);
    public static ushort And(ushort value1, ushort value2) => (ushort)(value1 & value2);
    public static int And(int value1, int value2) => value1 & value2;
    public static uint And(uint value1, uint value2) => value1 & value2;
    public static long And(long value1, long value2) => value1 & value2;
    public static ulong And(ulong value1, ulong value2) => value1 & value2;
}
