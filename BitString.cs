namespace BitTools;

/// <summary>
/// Methods for converting numbers to their binary representation.
/// </summary>
public static class BitString
{
    /// <summary>
    /// Convert the number <paramref name="val"/> to it's binary representation.
    /// </summary>
    /// <param name="val">The value to convert.</param>
    /// <param name="onlySignificantBits">Whether to only show the significant bits. If <see langword="false"/> the length will be equal to 8, else it will cut of leading 0s.</param>
    /// <returns>The binary representation of <paramref name="val"/>.</returns>
    public static string Make(byte val, bool onlySignificantBits = true) => Convert.ToString(val, 2).PadLeft(onlySignificantBits ? 0 : BitConstants.BitsInByte, '0');

    /// <summary>
    /// Convert the number <paramref name="val"/> to it's binary representation.
    /// </summary>
    /// <param name="val">The value to convert.</param>
    /// <param name="onlySignificantBits">Whether to only show the significant bits. If <see langword="false"/> the length will be equal to 8, else it will cut of leading 0s.</param>
    /// <returns>The binary representation of <paramref name="val"/>.</returns>
    public static string Make(sbyte val, bool onlySignificantBits = true) => Make(BitContainer.SByteToByte(val), onlySignificantBits);

    /// <summary>
    /// Convert the number <paramref name="val"/> to it's binary representation.
    /// </summary>
    /// <param name="val">The value to convert.</param>
    /// <param name="onlySignificantBits">Whether to only show the significant bits. If <see langword="false"/> the length will be equal to 16, else it will cut of leading 0s.</param>
    /// <returns>The binary representation of <paramref name="val"/>.</returns>
    public static string Make(short val, bool onlySignificantBits = true) => Convert.ToString(val, 2).PadLeft(onlySignificantBits ? 0 : BitConstants.BitsInShort, '0');

    /// <summary>
    /// Convert the number <paramref name="val"/> to it's binary representation.
    /// </summary>
    /// <param name="val">The value to convert.</param>
    /// <param name="onlySignificantBits">Whether to only show the significant bits. If <see langword="false"/> the length will be equal to 16, else it will cut of leading 0s.</param>
    /// <returns>The binary representation of <paramref name="val"/>.</returns>
    public static string Make(ushort val, bool onlySignificantBits = true) => Make(BitContainer.UShortToShort(val), onlySignificantBits);

    /// <summary>
    /// Convert the number <paramref name="val"/> to it's binary representation.
    /// </summary>
    /// <param name="val">The value to convert.</param>
    /// <param name="onlySignificantBits">Whether to only show the significant bits. If <see langword="false"/> the length will be equal to 32, else it will cut of leading 0s.</param>
    /// <returns>The binary representation of <paramref name="val"/>.</returns>
    public static string Make(int val, bool onlySignificantBits = true) => Convert.ToString(val, 2).PadLeft(onlySignificantBits ? 0 : BitConstants.BitsInInt, '0');

    /// <summary>
    /// Convert the number <paramref name="val"/> to it's binary representation.
    /// </summary>
    /// <param name="val">The value to convert.</param>
    /// <param name="onlySignificantBits">Whether to only show the significant bits. If <see langword="false"/> the length will be equal to 32, else it will cut of leading 0s.</param>
    /// <returns>The binary representation of <paramref name="val"/>.</returns>
    public static string Make(uint val, bool onlySignificantBits = true) => Make(BitContainer.UIntToInt(val), onlySignificantBits);

    /// <summary>
    /// Convert the number <paramref name="val"/> to it's binary representation.
    /// </summary>
    /// <param name="val">The value to convert.</param>
    /// <param name="onlySignificantBits">Whether to only show the significant bits. If <see langword="false"/> the length will be equal to 64, else it will cut of leading 0s.</param>
    /// <returns>The binary representation of <paramref name="val"/>.</returns>
    public static string Make(long val, bool onlySignificantBits = true) => Convert.ToString(val, 2).PadLeft(onlySignificantBits ? 0 : BitConstants.BitsInLong, '0');

    /// <summary>
    /// Convert the number <paramref name="val"/> to it's binary representation.
    /// </summary>
    /// <param name="val">The value to convert.</param>
    /// <param name="onlySignificantBits">Whether to only show the significant bits. If <see langword="false"/> the length will be equal to 64, else it will cut of leading 0s.</param>
    /// <returns>The binary representation of <paramref name="val"/>.</returns>
    public static string Make(ulong val, bool onlySignificantBits = true) => Make(BitContainer.ULongToLong(val), onlySignificantBits);
}