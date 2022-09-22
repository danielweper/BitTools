namespace BitTools;

/// <summary>
/// Methods for bitrotating all integral types
/// </summary>
public static class BitRotate {
    /// <summary>
    /// Rotates the bits of <paramref name="value"/>, <paramref name="amount"/> times to the left
    /// </summary>
    /// <param name="value">The number to rotate</param>
    /// <param name="amount">The amount to rotate</param>
    /// <returns><paramref name="value"/> rotated <paramref name="amount"/> to the left</returns>
    public static byte Left(byte value, int amount) {
        int rotateShiftAmount = BitConstants.BitsInByte - amount;
        byte shifted = BitShift.Left(x, amount);
        byte rotated = BitShift.Right(x, rotateShiftAmount);
        byte rotatedMask = BitMask.MakeZerosFromLeftByte(rotateShiftAmount);
        return (byte)(shifted | (rotated & rotatedMask));
    }
    /// <summary>
    /// Rotates the bits of <paramref name="value"/>, <paramref name="amount"/> times to the left
    /// </summary>
    /// <param name="value">The number to rotate</param>
    /// <param name="amount">The amount to rotate</param>
    /// <returns><paramref name="value"/> rotated <paramref name="amount"/> to the left</returns>
    public static sbyte Left(sbyte value, int amount) => BitContainer.ByteToSByte(Left(BitContainer.SByteToByte(x), amount));
    /// <summary>
    /// Rotates the bits of <paramref name="value"/>, <paramref name="amount"/> times to the left
    /// </summary>
    /// <param name="value">The number to rotate</param>
    /// <param name="amount">The amount to rotate</param>
    /// <returns><paramref name="value"/> rotated <paramref name="amount"/> to the left</returns>
    public static short Left(short value, int amount) {
        int rotateShiftAmount = BitConstants.BitsInShort - amount;
        short shifted = BitShift.Left(x, amount);
        short rotated = BitShift.Right(x, rotateShiftAmount);
        short rotatedMask = BitMask.MakeZerosFromLeftShort(rotateShiftAmount);
        return (short)(shifted | (rotated & rotatedMask));
    }
    /// <summary>
    /// Rotates the bits of <paramref name="value"/>, <paramref name="amount"/> times to the left
    /// </summary>
    /// <param name="value">The number to rotate</param>
    /// <param name="amount">The amount to rotate</param>
    /// <returns><paramref name="value"/> rotated <paramref name="amount"/> to the left</returns>
    public static ushort Left(ushort value, int amount) => BitContainer.ShortToUShort(Left(BitContainer.UShortToShort(x), amount));
    /// <summary>
    /// Rotates the bits of <paramref name="value"/>, <paramref name="amount"/> times to the left
    /// </summary>
    /// <param name="value">The number to rotate</param>
    /// <param name="amount">The amount to rotate</param>
    /// <returns><paramref name="value"/> rotated <paramref name="amount"/> to the left</returns>
    public static int Left(int value, int amount) {
        int rotateShiftAmount = BitConstants.BitsInInt - amount;
        int shifted = BitShift.Left(x, amount);
        int rotated = BitShift.Right(x, rotateShiftAmount);
        int rotatedMask = BitMask.MakeZerosFromLeftInt(rotateShiftAmount);
        return (int)(shifted | (rotated & rotatedMask));
    }
    /// <summary>
    /// Rotates the bits of <paramref name="value"/>, <paramref name="amount"/> times to the left
    /// </summary>
    /// <param name="value">The number to rotate</param>
    /// <param name="amount">The amount to rotate</param>
    /// <returns><paramref name="value"/> rotated <paramref name="amount"/> to the left</returns>
    public static uint Left(uint value, int amount) => BitContainer.IntToUInt(Left(BitContainer.UIntToInt(x), amount));
    /// <summary>
    /// Rotates the bits of <paramref name="value"/>, <paramref name="amount"/> times to the left
    /// </summary>
    /// <param name="value">The number to rotate</param>
    /// <param name="amount">The amount to rotate</param>
    /// <returns><paramref name="value"/> rotated <paramref name="amount"/> to the left</returns>
    public static long Left(long value, int amount) {
        int rotateShiftAmount = BitConstants.BitsInLong - amount;
        long shifted = BitShift.Left(x, amount);
        long rotated = BitShift.Right(x, rotateShiftAmount);
        long rotatedMask = BitMask.MakeZerosFromLeftLong(rotateShiftAmount);
        return (long)(shifted | (rotated & rotatedMask));
    }
    /// <summary>
    /// Rotates the bits of <paramref name="value"/>, <paramref name="amount"/> times to the left
    /// </summary>
    /// <param name="value">The number to rotate</param>
    /// <param name="amount">The amount to rotate</param>
    /// <returns><paramref name="value"/> rotated <paramref name="amount"/> to the left</returns>
    public static ulong Left(ulong value, int amount) => BitContainer.LongToULong(Left(BitContainer.ULongToLong(x), amount));


    /// <summary>
    /// Rotates the bits of <paramref name="value"/>, <paramref name="amount"/> times to the right
    /// </summary>
    /// <param name="value">The number to rotate</param>
    /// <param name="amount">The amount to rotate</param>
    /// <returns><paramref name="value"/> rotated <paramref name="amount"/> to the right</returns>
    public static byte Right(byte value, int amount) {
        int rotateShiftAmount = BitConstants.BitsInByte - amount;
        byte shifted = BitShift.Right(x, amount);
        byte shiftedMask = BitMask.MakeZerosFromLeftByte(amount);
        byte rotated = BitShift.Left(x, rotateShiftAmount);
        return (byte)((shifted & shiftedMask) | rotated);
    }
    /// <summary>
    /// Rotates the bits of <paramref name="value"/>, <paramref name="amount"/> times to the right
    /// </summary>
    /// <param name="value">The number to rotate</param>
    /// <param name="amount">The amount to rotate</param>
    /// <returns><paramref name="value"/> rotated <paramref name="amount"/> to the right</returns>
    public static sbyte Right(sbyte value, int amount) => BitContainer.ByteToSByte(Right(BitContainer.SByteToByte(x), amount));
    /// <summary>
    /// Rotates the bits of <paramref name="value"/>, <paramref name="amount"/> times to the right
    /// </summary>
    /// <param name="value">The number to rotate</param>
    /// <param name="amount">The amount to rotate</param>
    /// <returns><paramref name="value"/> rotated <paramref name="amount"/> to the right</returns>
    public static short Right(short value, int amount) {
        int rotateShiftAmount = BitConstants.BitsInShort - amount;
        short shifted = BitShift.Right(x, amount);
        short shiftedMask = BitMask.MakeZerosFromLeftShort(amount);
        short rotated = BitShift.Left(x, rotateShiftAmount);
        return (short)((shifted & shiftedMask) | rotated);
    }
    /// <summary>
    /// Rotates the bits of <paramref name="value"/>, <paramref name="amount"/> times to the right
    /// </summary>
    /// <param name="value">The number to rotate</param>
    /// <param name="amount">The amount to rotate</param>
    /// <returns><paramref name="value"/> rotated <paramref name="amount"/> to the right</returns>
    public static ushort Right(ushort value, int amount) => BitContainer.ShortToUShort(Right(BitContainer.UShortToShort(x), amount));
    /// <summary>
    /// Rotates the bits of <paramref name="value"/>, <paramref name="amount"/> times to the right
    /// </summary>
    /// <param name="value">The number to rotate</param>
    /// <param name="amount">The amount to rotate</param>
    /// <returns><paramref name="value"/> rotated <paramref name="amount"/> to the right</returns>
    public static int Right(int value, int amount) {
        int rotateShiftAmount = BitConstants.BitsInInt - amount;
        int shifted = BitShift.Right(x, amount);
        int shiftedMask = BitMask.MakeZerosFromLeftInt(amount);
        int rotated = BitShift.Left(x, rotateShiftAmount);
        return (int)((shifted & shiftedMask) | rotated);
    }
    /// <summary>
    /// Rotates the bits of <paramref name="value"/>, <paramref name="amount"/> times to the right
    /// </summary>
    /// <param name="value">The number to rotate</param>
    /// <param name="amount">The amount to rotate</param>
    /// <returns><paramref name="value"/> rotated <paramref name="amount"/> to the right</returns>
    public static uint Right(uint value, int amount) => BitContainer.IntToUInt(Right(BitContainer.UIntToInt(x), amount));
    /// <summary>
    /// Rotates the bits of <paramref name="value"/>, <paramref name="amount"/> times to the right
    /// </summary>
    /// <param name="value">The number to rotate</param>
    /// <param name="amount">The amount to rotate</param>
    /// <returns><paramref name="value"/> rotated <paramref name="amount"/> to the right</returns>
    public static long Right(long value, int amount) {
        int rotateShiftAmount = BitConstants.BitsInLong - amount;
        long shifted = BitShift.Right(x, amount);
        long shiftedMask = BitMask.MakeZerosFromLeftLong(amount);
        long rotated = BitShift.Left(x, rotateShiftAmount);
        return (long)((shifted & shiftedMask) | rotated);
    }
    /// <summary>
    /// Rotates the bits of <paramref name="value"/>, <paramref name="amount"/> times to the right
    /// </summary>
    /// <param name="value">The number to rotate</param>
    /// <param name="amount">The amount to rotate</param>
    /// <returns><paramref name="value"/> rotated <paramref name="amount"/> to the right</returns>
    public static ulong Right(ulong value, int amount) => BitContainer.LongToULong(Right(BitContainer.ULongToLong(x), amount));
}