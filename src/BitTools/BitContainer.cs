namespace BitTools;

/// <summary>
/// Methods for changing the container of some bits, without changing the bits themselves
/// </summary>
public static class BitContainer
{
    /// <summary>
    /// Changes the container of <paramref name="value"/>
    /// </summary>
    /// <param name="value">The number</param>
    /// <returns>A <see langword="byte" /> with the exact same bits as <paramref name="value"/></returns>
    public static byte SByteToByte(sbyte value) => unchecked((byte)value);
    /// <summary>
    /// Changes the container of <paramref name="value"/>
    /// </summary>
    /// <param name="value">The number</param>
    /// <returns>A <see langword="sbyte" /> with the exact same bits as <paramref name="value"/></returns>
    public static sbyte ByteToSByte(byte value) => unchecked((sbyte)value);
    /// <summary>
    /// Changes the container of <paramref name="value"/>
    /// </summary>
    /// <param name="value">The number</param>
    /// <returns>A <see langword="short" /> with the exact same bits as <paramref name="value"/></returns>
    public static short UShortToShort(ushort value) => unchecked((short)value);
    /// <summary>
    /// Changes the container of <paramref name="value"/>
    /// </summary>
    /// <param name="value">The number</param>
    /// <returns>A <see langword="ushort" /> with the exact same bits as <paramref name="value"/></returns>
    public static ushort ShortToUShort(short value) => unchecked((ushort)value);
    /// <summary>
    /// Changes the container of <paramref name="value"/>
    /// </summary>
    /// <param name="value">The number</param>
    /// <returns>A <see langword="int" /> with the exact same bits as <paramref name="value"/></returns>
    public static int UIntToInt(uint value) => unchecked((int)value);
    /// <summary>
    /// Changes the container of <paramref name="value"/>
    /// </summary>
    /// <param name="value">The number</param>
    /// <returns>A <see langword="uint" /> with the exact same bits as <paramref name="value"/></returns>
    public static uint IntToUInt(int value) => unchecked((uint)value);
    /// <summary>
    /// Changes the container of <paramref name="value"/>
    /// </summary>
    /// <param name="value">The number</param>
    /// <returns>A <see langword="long" /> with the exact same bits as <paramref name="value"/></returns>
    public static long ULongToLong(ulong value) => unchecked((long)value);
    /// <summary>
    /// Changes the container of <paramref name="value"/>
    /// </summary>
    /// <param name="value">The number</param>
    /// <returns>A <see langword="ulong" /> with the exact same bits as <paramref name="value"/></returns>
    public static ulong LongToULong(long value) => unchecked((ulong)value);
}