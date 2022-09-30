namespace BitTools;

/// <summary>
/// Methods for bitshifting all integral types.
/// </summary>
public static class BitShift
{
    private const int ByteShiftAmountMask = 0b111;
    private const int ShortShiftAmountMask = 0b1111;

    /// <summary>
    /// The amount to shift a byte to get the right behaviour in a right shift.
    /// </summary>
    private const int ByteShiftOffset = BitConstants.BitsInInt - BitConstants.BitsInByte;

    /// <summary>
    /// The amount to shift a short to get the right behaviour in a right shift.
    /// </summary>
    private const int ShortShiftOffset = BitConstants.BitsInInt - BitConstants.BitsInShort;

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the left.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the left.</returns>
    public static byte Left(byte value, int amount) => (byte)(value << (amount & ByteShiftAmountMask));

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the left.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the left.</returns>
    public static sbyte Left(sbyte value, int amount) => (sbyte)(value << (amount & ByteShiftAmountMask));

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the left.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the left.</returns>
    public static short Left(short value, int amount) => (short)(value << (amount & ShortShiftAmountMask));

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the left.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the left.</returns>
    public static ushort Left(ushort value, int amount) => (ushort)(value << (amount & ShortShiftAmountMask));

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the left.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the left.</returns>
    public static int Left(int value, int amount) => value << amount;

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the left.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the left.</returns>
    public static uint Left(uint value, int amount) => value << amount;

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the left.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the left.</returns>
    public static long Left(long value, int amount) => value << amount;

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the left.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the left.</returns>
    public static ulong Left(ulong value, int amount) => value << amount;

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the right, by copying the most significant bit and inserting it in the "blank" space.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the right.</returns>
    public static byte Right(byte value, int amount) => (byte)(((value << ByteShiftOffset) >> (amount & ByteShiftAmountMask)) >> ByteShiftOffset);

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the right, by copying the most significant bit and inserting it in the "blank" space.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the right.</returns>
    public static sbyte Right(sbyte value, int amount) => (sbyte)(((value << ByteShiftOffset) >> (amount & ByteShiftAmountMask)) >> ByteShiftOffset);

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the right, by copying the most significant bit and inserting it in the "blank" space.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the right.</returns>
    public static short Right(short value, int amount) => (short)(((value << ShortShiftOffset) >> (amount & ShortShiftAmountMask)) >> ShortShiftOffset);

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the right, by copying the most significant bit and inserting it in the "blank" space.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the right.</returns>
    public static ushort Right(ushort value, int amount) => (ushort)(((value << ShortShiftOffset) >> (amount & ShortShiftAmountMask)) >> ShortShiftOffset);

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the right, by copying the most significant bit and inserting it in the "blank" space.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the right.</returns>
    public static int Right(int value, int amount) => value >> amount;

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the right, by copying the most significant bit and inserting it in the "blank" space.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the right.</returns>
    public static uint Right(uint value, int amount) => value >> amount;

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the right, by copying the most significant bit and inserting it in the "blank" space.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the right.</returns>
    public static long Right(long value, int amount) => value >> amount;

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the right, by copying the most significant bit and inserting it in the "blank" space.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the right.</returns>
    public static ulong Right(ulong value, int amount) => value >> amount;

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the right, and filling the "blank" space with 0.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the right.</returns>
    public static byte RightNoCopy(byte value, int amount) => (byte)(Right(value, amount) & BitMask.MakeZerosFromLeftByte(amount));

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the right, and filling the "blank" space with 0.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the right.</returns>
    public static sbyte RightNoCopy(sbyte value, int amount) => (sbyte)(Right(value, amount) & BitMask.MakeZerosFromLeftByte(amount));

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the right, and filling the "blank" space with 0.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the right.</returns>
    public static short RightNoCopy(short value, int amount) => (short)(Right(value, amount) & BitMask.MakeZerosFromLeftShort(amount));

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the right, and filling the "blank" space with 0.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the right.</returns>
    public static ushort RightNoCopy(ushort value, int amount) => (ushort)(Right(value, amount) & BitMask.MakeZerosFromLeftShort(amount));

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the right, and filling the "blank" space with 0.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the right.</returns>
    public static int RightNoCopy(int value, int amount) => (int)(Right(value, amount) & BitMask.MakeZerosFromLeftInt(amount));

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the right, and filling the "blank" space with 0.
    /// </summary>
    /// <param name="value">The number to shift</param>
    /// <param name="amount">The amount to shift</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the right</returns>
    public static uint RightNoCopy(uint value, int amount) => (uint)(Right(value, amount) & BitContainer.IntToUInt(BitMask.MakeZerosFromLeftInt(amount)));
    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the right, and filling the "blank" space with 0.
    /// </summary>
    /// <param name="value">The number to shift.</param>
    /// <param name="amount">The amount to shift.</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the right.</returns>
    public static long RightNoCopy(long value, int amount) => (long)(Right(value, amount) & BitMask.MakeZerosFromLeftLong(amount));

    /// <summary>
    /// Shifts <paramref name="value"/>, <paramref name="amount"/> times to the right, and filling the "blank" space with 0.
    /// </summary>
    /// <param name="value">The number to shift</param>
    /// <param name="amount">The amount to shift</param>
    /// <returns><paramref name="value"/> shifted <paramref name="amount"/> to the right</returns>
    public static ulong RightNoCopy(ulong value, int amount) => (ulong)(Right(value, amount) & BitContainer.LongToULong(BitMask.MakeZerosFromLeftLong(amount)));
}