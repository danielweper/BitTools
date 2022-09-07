namespace BitTools;
public static class BitMask {
    public static byte MakeOnesFromLeftByte(int amount) => amount % BitConstants.BitsInByte == 0 ? (byte)0 : BitShift.Right((byte)0x80, amount - 1);
    public static short MakeOnesFromLeftShort(int amount) => amount % BitConstants.BitsInShort == 0 ? (short)0 : BitShift.Right((short)-0x8000, amount - 1);
    public static int MakeOnesFromLeftInt(int amount) => amount % BitConstants.BitsInInt == 0 ? (int)0 : BitShift.Right((int)-0x80000000, amount - 1);
    public static long MakeOnesFromLeftLong(int amount) => amount % BitConstants.BitsInLong == 0 ? (long)0 : BitShift.Right((long)-0x8000000000000000, amount - 1);
    

    public static byte MakeZerosFromLeftByte(int amount) => amount % BitConstants.BitsInByte == 0 ? byte.MaxValue : BitShift.Right((byte)0x7f, amount - 1);
    public static short MakeZerosFromLeftShort(int amount) => amount % BitConstants.BitsInShort == 0 ? short.MinValue : BitShift.Right(short.MaxValue, amount - 1);
    public static int MakeZerosFromLeftInt(int amount) => amount % BitConstants.BitsInInt == 0 ? int.MinValue : BitShift.Right(int.MaxValue, amount - 1);
    public static long MakeZerosFromLeftLong(int amount) => amount % BitConstants.BitsInLong == 0 ? long.MinValue : BitShift.Right(long.MaxValue, amount - 1);


    public static byte MakeOnesFromRightByte(int amount) => (byte)~MakeZerosFromLeftByte(amount);
    public static short MakeOnesFromRightShort(int amount) => (short)~MakeZerosFromLeftShort(amount);
    public static int MakeOnesFromRightInt(int amount) => (int)~MakeZerosFromLeftInt(amount);
    public static long MakeOnesFromRightLong(int amount) => (long)~MakeZerosFromLeftLong(amount);
    public static long MakeOnesFromRight(int amount) => MakeOnesFromRightLong(amount);


    public static byte MakeZerosFromRightByte(int amount) => (byte)~MakeOnesFromLeftByte(amount);
    public static short MakeZerosFromRightShort(int amount) => (short)~MakeOnesFromLeftShort(amount);
    public static int MakeZerosFromRightInt(int amount) => (int)~MakeOnesFromLeftInt(amount);
    public static long MakeZerosFromRightLong(int amount) => (long)~MakeOnesFromLeftLong(amount);
    public static long MakeZerosFromRight(int amount) => MakeZerosFromRightLong(amount);
}