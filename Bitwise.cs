namespace BitTools;

public static class Bitwise
{
    public static byte Complement(byte value) => (byte)(~value);
	public static sbyte Complement(sbyte value) => (sbyte)(~value);
	public static short Complement(short value) => (short)(~value);
	public static ushort Complement(ushort value) => (ushort)(~value);
	public static int Complement(int value) => ~value;
	public static uint Complement(uint value) => ~value;
	public static long Complement(long value) => ~value;
	public static ulong Complement(ulong value) => ~value;


    public static byte Or(byte value1, byte value2) => (byte)(value1 | value2);
    public static sbyte Or(sbyte value1, sbyte value2) => (sbyte)(value1 | value2);
    public static short Or(short value1, short value2) => (short)(value1 | value2);
    public static ushort Or(ushort value1, ushort value2) => (ushort)(value1 | value2);
    public static int Or(int value1, int value2) => value1 | value2;
    public static uint Or(uint value1, uint value2) => value1 | value2;
    public static long Or(long value1, long value2) => value1 | value2;
    public static ulong Or(ulong value1, ulong value2) => value1 | value2;


    public static byte Nor(byte value1, byte value2) => Complement(Or(value1, value2));
    public static sbyte Nor(sbyte value1, sbyte value2) => Complement(Or(value1, value2));
	public static short Nor(short value1, short value2) => Complement(Or(value1, value2));
	public static ushort Nor(ushort value1, ushort value2) => Complement(Or(value1, value2));
	public static int Nor(int value1, int value2) => Complement(Or(value1, value2));
	public static uint Nor(uint value1, uint value2) => Complement(Or(value1, value2));
	public static long Nor(long value1, long value2) => Complement(Or(value1, value2));
	public static ulong Nor(ulong value1, ulong value2) => Complement(Or(value1, value2));


    public static byte Xor(byte value1, byte value2) => And(Or(value1, value2), Nand(value1, value2));
    public static sbyte Xor(sbyte value1, sbyte value2) => And(Or(value1, value2), Nand(value1, value2));
	public static short Xor(short value1, short value2) => And(Or(value1, value2), Nand(value1, value2));
	public static ushort Xor(ushort value1, ushort value2) => And(Or(value1, value2), Nand(value1, value2));
	public static int Xor(int value1, int value2) => And(Or(value1, value2), Nand(value1, value2));
	public static uint Xor(uint value1, uint value2) => And(Or(value1, value2), Nand(value1, value2));
	public static long Xor(long value1, long value2) => And(Or(value1, value2), Nand(value1, value2));
	public static ulong Xor(ulong value1, ulong value2) => And(Or(value1, value2), Nand(value1, value2));



    public static byte And(byte value1, byte value2) => (byte)(value1 & value2);
    public static sbyte And(sbyte value1, sbyte value2) => (sbyte)(value1 & value2);
    public static short And(short value1, short value2) => (short)(value1 & value2);
    public static ushort And(ushort value1, ushort value2) => (ushort)(value1 & value2);
    public static int And(int value1, int value2) => value1 & value2;
    public static uint And(uint value1, uint value2) => value1 & value2;
    public static long And(long value1, long value2) => value1 & value2;
    public static ulong And(ulong value1, ulong value2) => value1 & value2;


    public static byte Nand(byte value1, byte value2) => Complement(And(value1, value2));
    public static sbyte Nand(sbyte value1, sbyte value2) => Complement(And(value1, value2));
	public static short Nand(short value1, short value2) => Complement(And(value1, value2));
	public static ushort Nand(ushort value1, ushort value2) => Complement(And(value1, value2));
	public static int Nand(int value1, int value2) => Complement(And(value1, value2));
	public static uint Nand(uint value1, uint value2) => Complement(And(value1, value2));
	public static long Nand(long value1, long value2) => Complement(And(value1, value2));
	public static ulong Nand(ulong value1, ulong value2) => Complement(And(value1, value2));

}
