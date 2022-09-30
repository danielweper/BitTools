namespace BitTools;

/// <summary>
/// Bitwise operations for all integral types.
/// </summary>
public static class Bitwise
{
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> AND <paramref name="value2"/> have a 1-bit at index n, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> and <paramref name="value2"/> has a 1 at the nth bit, else it will be 0</returns>
    public static byte And(byte value1, byte value2) => (byte)(value1 & value2);
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> AND <paramref name="value2"/> have a 1-bit at index n, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> and <paramref name="value2"/> has a 1 at the nth bit, else it will be 0</returns>
    public static sbyte And(sbyte value1, sbyte value2) => (sbyte)(value1 & value2);
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> AND <paramref name="value2"/> have a 1-bit at index n, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> and <paramref name="value2"/> has a 1 at the nth bit, else it will be 0</returns>
    public static short And(short value1, short value2) => (short)(value1 & value2);
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> AND <paramref name="value2"/> have a 1-bit at index n, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> and <paramref name="value2"/> has a 1 at the nth bit, else it will be 0</returns>
    public static ushort And(ushort value1, ushort value2) => (ushort)(value1 & value2);
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> AND <paramref name="value2"/> have a 1-bit at index n, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> and <paramref name="value2"/> has a 1 at the nth bit, else it will be 0</returns>
    public static int And(int value1, int value2) => value1 & value2;
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> AND <paramref name="value2"/> have a 1-bit at index n, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> and <paramref name="value2"/> has a 1 at the nth bit, else it will be 0</returns>
    public static uint And(uint value1, uint value2) => value1 & value2;
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> AND <paramref name="value2"/> have a 1-bit at index n, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> and <paramref name="value2"/> has a 1 at the nth bit, else it will be 0</returns>
    public static long And(long value1, long value2) => value1 & value2;
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> AND <paramref name="value2"/> have a 1-bit at index n, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> and <paramref name="value2"/> has a 1 at the nth bit, else it will be 0</returns>
    public static ulong And(ulong value1, ulong value2) => value1 & value2;


    /// <summary>
    /// Gives a number with a 0-bit at index n, if <paramref name="value1"/> AND <paramref name="value2"/> have a 1-bit at index n, else it will have a 1-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 0 if <paramref name="value1"/> and <paramref name="value2"/> has a 1 at the nth bit, else it will be 1</returns>
    public static byte Nand(byte value1, byte value2) => Complement(And(value1, value2));
    /// <summary>
    /// Gives a number with a 0-bit at index n, if <paramref name="value1"/> AND <paramref name="value2"/> have a 1-bit at index n, else it will have a 1-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 0 if <paramref name="value1"/> and <paramref name="value2"/> has a 1 at the nth bit, else it will be 1</returns>
    public static sbyte Nand(sbyte value1, sbyte value2) => Complement(And(value1, value2));
    /// <summary>
    /// Gives a number with a 0-bit at index n, if <paramref name="value1"/> AND <paramref name="value2"/> have a 1-bit at index n, else it will have a 1-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 0 if <paramref name="value1"/> and <paramref name="value2"/> has a 1 at the nth bit, else it will be 1</returns>
	public static short Nand(short value1, short value2) => Complement(And(value1, value2));
    /// <summary>
    /// Gives a number with a 0-bit at index n, if <paramref name="value1"/> AND <paramref name="value2"/> have a 1-bit at index n, else it will have a 1-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 0 if <paramref name="value1"/> and <paramref name="value2"/> has a 1 at the nth bit, else it will be 1</returns>
	public static ushort Nand(ushort value1, ushort value2) => Complement(And(value1, value2));
    /// <summary>
    /// Gives a number with a 0-bit at index n, if <paramref name="value1"/> AND <paramref name="value2"/> have a 1-bit at index n, else it will have a 1-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 0 if <paramref name="value1"/> and <paramref name="value2"/> has a 1 at the nth bit, else it will be 1</returns>
	public static int Nand(int value1, int value2) => Complement(And(value1, value2));
    /// <summary>
    /// Gives a number with a 0-bit at index n, if <paramref name="value1"/> AND <paramref name="value2"/> have a 1-bit at index n, else it will have a 1-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 0 if <paramref name="value1"/> and <paramref name="value2"/> has a 1 at the nth bit, else it will be 1</returns>
	public static uint Nand(uint value1, uint value2) => Complement(And(value1, value2));
    /// <summary>
    /// Gives a number with a 0-bit at index n, if <paramref name="value1"/> AND <paramref name="value2"/> have a 1-bit at index n, else it will have a 1-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 0 if <paramref name="value1"/> and <paramref name="value2"/> has a 1 at the nth bit, else it will be 1</returns>
	public static long Nand(long value1, long value2) => Complement(And(value1, value2));
    /// <summary>
    /// Gives a number with a 0-bit at index n, if <paramref name="value1"/> AND <paramref name="value2"/> have a 1-bit at index n, else it will have a 1-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 0 if <paramref name="value1"/> and <paramref name="value2"/> has a 1 at the nth bit, else it will be 1</returns>
	public static ulong Nand(ulong value1, ulong value2) => Complement(And(value1, value2));


    /// <summary>
    /// Gives the complementary bits of <paramref name="value"/>.
    /// </summary>
    /// <param name="value">The number to get complement of.</param>
    /// <returns>Complementary bits of <paramref name="value"/> (where all the 1-bits are 0-bits and vice versa).</returns>
    public static byte Complement(byte value) => (byte)(~value);
    /// <summary>
    /// Gives the complementary bits of <paramref name="value"/>.
    /// </summary>
    /// <param name="value">The number to get complement of.</param>
    /// <returns>Complementary bits of <paramref name="value"/> (where all the 1-bits are 0-bits and vice versa).</returns>
	public static sbyte Complement(sbyte value) => (sbyte)(~value);
    /// <summary>
    /// Gives the complementary bits of <paramref name="value"/>.
    /// </summary>
    /// <param name="value">The number to get complement of.</param>
    /// <returns>Complementary bits of <paramref name="value"/> (where all the 1-bits are 0-bits and vice versa).</returns>
	public static short Complement(short value) => (short)(~value);
    /// <summary>
    /// Gives the complementary bits of <paramref name="value"/>.
    /// </summary>
    /// <param name="value">The number to get complement of.</param>
    /// <returns>Complementary bits of <paramref name="value"/> (where all the 1-bits are 0-bits and vice versa).</returns>
	public static ushort Complement(ushort value) => (ushort)(~value);
    /// <summary>
    /// Gives the complementary bits of <paramref name="value"/>.
    /// </summary>
    /// <param name="value">The number to get complement of.</param>
    /// <returns>Complementary bits of <paramref name="value"/> (where all the 1-bits are 0-bits and vice versa).</returns>
	public static int Complement(int value) => ~value;
    /// <summary>
    /// Gives the complementary bits of <paramref name="value"/>.
    /// </summary>
    /// <param name="value">The number to get complement of.</param>
    /// <returns>Complementary bits of <paramref name="value"/> (where all the 1-bits are 0-bits and vice versa).</returns>
	public static uint Complement(uint value) => ~value;
    /// <summary>
    /// Gives the complementary bits of <paramref name="value"/>.
    /// </summary>
    /// <param name="value">The number to get complement of.</param>
    /// <returns>Complementary bits of <paramref name="value"/> (where all the 1-bits are 0-bits and vice versa).</returns>
	public static long Complement(long value) => ~value;
    /// <summary>
    /// Gives the complementary bits of <paramref name="value"/>.
    /// </summary>
    /// <param name="value">The number to get complement of.</param>
    /// <returns>Complementary bits of <paramref name="value"/> (where all the 1-bits are 0-bits and vice versa).</returns>
	public static ulong Complement(ulong value) => ~value;


    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, else it will be 0</returns>
    public static byte Or(byte value1, byte value2) => (byte)(value1 | value2);
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, else it will be 0</returns>
    public static sbyte Or(sbyte value1, sbyte value2) => (sbyte)(value1 | value2);
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, else it will be 0</returns>
    public static short Or(short value1, short value2) => (short)(value1 | value2);
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, else it will be 0</returns>
    public static ushort Or(ushort value1, ushort value2) => (ushort)(value1 | value2);
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, else it will be 0</returns>
    public static int Or(int value1, int value2) => value1 | value2;
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, else it will be 0</returns>
    public static uint Or(uint value1, uint value2) => value1 | value2;
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, else it will be 0</returns>
    public static long Or(long value1, long value2) => value1 | value2;
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, else it will be 0</returns>
    public static ulong Or(ulong value1, ulong value2) => value1 | value2;


    /// <summary>
    /// Gives a number with a 0-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, else it will have a 1-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 0 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, else it will be 1</returns>
    public static byte Nor(byte value1, byte value2) => Complement(Or(value1, value2));
    /// <summary>
    /// Gives a number with a 0-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, else it will have a 1-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 0 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, else it will be 1</returns>
    public static sbyte Nor(sbyte value1, sbyte value2) => Complement(Or(value1, value2));
    /// <summary>
    /// Gives a number with a 0-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, else it will have a 1-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 0 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, else it will be 1</returns>
	public static short Nor(short value1, short value2) => Complement(Or(value1, value2));
    /// <summary>
    /// Gives a number with a 0-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, else it will have a 1-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 0 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, else it will be 1</returns>
	public static ushort Nor(ushort value1, ushort value2) => Complement(Or(value1, value2));
    /// <summary>
    /// Gives a number with a 0-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, else it will have a 1-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 0 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, else it will be 1</returns>
	public static int Nor(int value1, int value2) => Complement(Or(value1, value2));
    /// <summary>
    /// Gives a number with a 0-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, else it will have a 1-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 0 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, else it will be 1</returns>
	public static uint Nor(uint value1, uint value2) => Complement(Or(value1, value2));
    /// <summary>
    /// Gives a number with a 0-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, else it will have a 1-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 0 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, else it will be 1</returns>
	public static long Nor(long value1, long value2) => Complement(Or(value1, value2));
    /// <summary>
    /// Gives a number with a 0-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, else it will have a 1-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 0 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, else it will be 1</returns>
	public static ulong Nor(ulong value1, ulong value2) => Complement(Or(value1, value2));


    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, BUT not both, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, but not both, else it will be 0</returns>
    public static byte Xor(byte value1, byte value2) => And(Or(value1, value2), Nand(value1, value2));
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, BUT not both, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, but not both, else it will be 0</returns>
    public static sbyte Xor(sbyte value1, sbyte value2) => And(Or(value1, value2), Nand(value1, value2));
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, BUT not both, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, but not both, else it will be 0</returns>
	public static short Xor(short value1, short value2) => And(Or(value1, value2), Nand(value1, value2));
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, BUT not both, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, but not both, else it will be 0</returns>
	public static ushort Xor(ushort value1, ushort value2) => And(Or(value1, value2), Nand(value1, value2));
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, BUT not both, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, but not both, else it will be 0</returns>
	public static int Xor(int value1, int value2) => And(Or(value1, value2), Nand(value1, value2));
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, BUT not both, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, but not both, else it will be 0</returns>
	public static uint Xor(uint value1, uint value2) => And(Or(value1, value2), Nand(value1, value2));
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, BUT not both, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, but not both, else it will be 0</returns>
	public static long Xor(long value1, long value2) => And(Or(value1, value2), Nand(value1, value2));
    /// <summary>
    /// Gives a number with a 1-bit at index n, if <paramref name="value1"/> OR <paramref name="value2"/> have a 1-bit at index n, BUT not both, else it will have a 0-bit.
    /// </summary>
    /// <param name="value1">The first number</param>
    /// <param name="value2">The second number</param>
    /// <returns>A number where the value of the nth bit is 1 if <paramref name="value1"/> or <paramref name="value2"/> has a 1 at the nth bit, but not both, else it will be 0</returns>
	public static ulong Xor(ulong value1, ulong value2) => And(Or(value1, value2), Nand(value1, value2));
}
