namespace BitTools;

public static class BitRotate {
    public static byte Left(byte x, int amount) {
        int rotateShiftAmount = BitConstants.BitsInByte - amount;
        byte shifted = BitShift.Left(x, amount);
        byte rotated = BitShift.Right(x, rotateShiftAmount);
        byte rotatedMask = BitMask.MakeZerosFromLeftByte(rotateShiftAmount);
        return (byte)(shifted | (rotated & rotatedMask));
    }
    public static sbyte Left(sbyte x, int amount) => BitContainer.ByteToSByte(Left(BitContainer.SByteToByte(x), amount));
    public static short Left(short x, int amount) {
        int rotateShiftAmount = BitConstants.BitsInShort - amount;
        short shifted = BitShift.Left(x, amount);
        short rotated = BitShift.Right(x, rotateShiftAmount);
        short rotatedMask = BitMask.MakeZerosFromLeftShort(rotateShiftAmount);
        return (short)(shifted | (rotated & rotatedMask));
    }
    public static ushort Left(ushort x, int amount) => BitContainer.ShortToUShort(Left(BitContainer.UShortToShort(x), amount));
    public static int Left(int x, int amount) {
        int rotateShiftAmount = BitConstants.BitsInInt - amount;
        int shifted = BitShift.Left(x, amount);
        int rotated = BitShift.Right(x, rotateShiftAmount);
        int rotatedMask = BitMask.MakeZerosFromLeftInt(rotateShiftAmount);
        return (int)(shifted | (rotated & rotatedMask));
    }
    public static uint Left(uint x, int amount) => BitContainer.IntToUInt(Left(BitContainer.UIntToInt(x), amount));
    public static long Left(long x, int amount) {
        int rotateShiftAmount = BitConstants.BitsInLong - amount;
        long shifted = BitShift.Left(x, amount);
        long rotated = BitShift.Right(x, rotateShiftAmount);
        long rotatedMask = BitMask.MakeZerosFromLeftLong(rotateShiftAmount);
        return (long)(shifted | (rotated & rotatedMask));
    }
    public static ulong Left(ulong x, int amount) => BitContainer.LongToULong(Left(BitContainer.ULongToLong(x), amount));


    public static byte Right(byte x, int amount) {
        int rotateShiftAmount = BitConstants.BitsInByte - amount;
        byte shifted = BitShift.Right(x, amount);
        byte shiftedMask = BitMask.MakeZerosFromLeftByte(amount);
        byte rotated = BitShift.Left(x, rotateShiftAmount);
        return (byte)((shifted & shiftedMask) | rotated);
    }
    public static sbyte Right(sbyte x, int amount) => BitContainer.ByteToSByte(Right(BitContainer.SByteToByte(x), amount));
    public static short Right(short x, int amount) {
        int rotateShiftAmount = BitConstants.BitsInShort - amount;
        short shifted = BitShift.Right(x, amount);
        short shiftedMask = BitMask.MakeZerosFromLeftShort(amount);
        short rotated = BitShift.Left(x, rotateShiftAmount);
        return (short)((shifted & shiftedMask) | rotated);
    }
    public static ushort Right(ushort x, int amount) => BitContainer.ShortToUShort(Right(BitContainer.UShortToShort(x), amount));
    public static int Right(int x, int amount) {
        int rotateShiftAmount = BitConstants.BitsInInt - amount;
        int shifted = BitShift.Right(x, amount);
        int shiftedMask = BitMask.MakeZerosFromLeftInt(amount);
        int rotated = BitShift.Left(x, rotateShiftAmount);
        return (int)((shifted & shiftedMask) | rotated);
    }
    public static uint Right(uint x, int amount) => BitContainer.IntToUInt(Right(BitContainer.UIntToInt(x), amount));
    public static long Right(long x, int amount) {
        int rotateShiftAmount = BitConstants.BitsInLong - amount;
        long shifted = BitShift.Right(x, amount);
        long shiftedMask = BitMask.MakeZerosFromLeftLong(amount);
        long rotated = BitShift.Left(x, rotateShiftAmount);
        return (long)((shifted & shiftedMask) | rotated);
    }
    public static ulong Right(ulong x, int amount) => BitContainer.LongToULong(Right(BitContainer.ULongToLong(x), amount));
}