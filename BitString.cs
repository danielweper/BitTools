namespace BitTools;

public static class BitString {
    public static string Make(byte val, bool onlySignificantBits = true) => Convert.ToString(val, 2).PadLeft(onlySignificantBits ? 0 : BitConstants.BitsInByte, '0');
    public static string Make(sbyte val, bool onlySignificantBits = true) => Make(BitContainer.SByteToByte(val), onlySignificantBits);
    public static string Make(short val, bool onlySignificantBits = true) => Convert.ToString(val, 2).PadLeft(onlySignificantBits ? 0 : BitConstants.BitsInShort, '0');
    public static string Make(ushort val, bool onlySignificantBits = true) => Make(BitContainer.UShortToShort(val), onlySignificantBits);
    public static string Make(int val, bool onlySignificantBits = true) => Convert.ToString(val, 2).PadLeft(onlySignificantBits ? 0 : BitConstants.BitsInInt, '0');
    public static string Make(uint val, bool onlySignificantBits = true) => Make(BitContainer.UIntToInt(val), onlySignificantBits);
    public static string Make(long val, bool onlySignificantBits = true) => Convert.ToString(val, 2).PadLeft(onlySignificantBits ? 0 : BitConstants.BitsInLong, '0');
    public static string Make(ulong val, bool onlySignificantBits = true) => Make(BitContainer.ULongToLong(val), onlySignificantBits);


    public static void Write(byte val, bool onlySignificantBits = true) => Console.Write(Make(val, onlySignificantBits));
    public static void Write(sbyte val, bool onlySignificantBits = true) => Console.Write(Make(val, onlySignificantBits));
    public static void Write(short val, bool onlySignificantBits = true) => Console.Write(Make(val, onlySignificantBits));
    public static void Write(ushort val, bool onlySignificantBits = true) => Console.Write(Make(val, onlySignificantBits));
    public static void Write(int val, bool onlySignificantBits = true) => Console.Write(Make(val, onlySignificantBits));
    public static void Write(uint val, bool onlySignificantBits = true) => Console.Write(Make(val, onlySignificantBits));
    public static void Write(long val, bool onlySignificantBits = true) => Console.Write(Make(val, onlySignificantBits));
    public static void Write(ulong val, bool onlySignificantBits = true) => Console.Write(Make(val, onlySignificantBits));


    public static void WriteLine(byte val, bool onlySignificantBits = true) => Console.WriteLine(Make(val, onlySignificantBits));
    public static void WriteLine(sbyte val, bool onlySignificantBits = true) => Console.WriteLine(Make(val, onlySignificantBits));
    public static void WriteLine(short val, bool onlySignificantBits = true) => Console.WriteLine(Make(val, onlySignificantBits));
    public static void WriteLine(ushort val, bool onlySignificantBits = true) => Console.WriteLine(Make(val, onlySignificantBits));
    public static void WriteLine(int val, bool onlySignificantBits = true) => Console.WriteLine(Make(val, onlySignificantBits));
    public static void WriteLine(uint val, bool onlySignificantBits = true) => Console.WriteLine(Make(val, onlySignificantBits));
    public static void WriteLine(long val, bool onlySignificantBits = true) => Console.WriteLine(Make(val, onlySignificantBits));
    public static void WriteLine(ulong val, bool onlySignificantBits = true) => Console.WriteLine(Make(val, onlySignificantBits));
}