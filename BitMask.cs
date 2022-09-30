namespace BitTools;

/// <summary>
/// Helper methods for generating basic bitmasks.
/// </summary>
public static class BitMask
{
    /// <summary>
    /// A method for generating a bitmask with <paramref name="amount"/> 1s, from the left, with the rest being 0s.
    /// </summary>
    /// <param name="amount">The amount of 1s to generate.</param>
    /// <returns>A bitmask with 8 bits, with <paramref name="amount"/> 1s, from the most significant bit and down.</returns>
    public static byte MakeOnesFromLeftByte(int amount) => amount % BitConstants.BitsInByte == 0 ? (byte)0 : BitShift.Right((byte)0x80, amount - 1);

    /// <summary>
    /// A method for generating a bitmask with <paramref name="amount"/> 1s, from the left, with the rest being 0s.
    /// </summary>
    /// <param name="amount">The amount of 1s to generate.</param>
    /// <returns>A bitmask with 16 bits, with <paramref name="amount"/> 1s, from the most significant bit and down.</returns>
    public static short MakeOnesFromLeftShort(int amount) => amount % BitConstants.BitsInShort == 0 ? (short)0 : BitShift.Right((short)-0x8000, amount - 1);

    /// <summary>
    /// A method for generating a bitmask with <paramref name="amount"/> 1s, from the left, with the rest being 0s.
    /// </summary>
    /// <param name="amount">The amount of 1s to generate.</param>
    /// <returns>A bitmask with 32 bits, with <paramref name="amount"/> 1s, from the most significant bit and down.</returns>
    public static int MakeOnesFromLeftInt(int amount) => amount % BitConstants.BitsInInt == 0 ? 0 : BitShift.Right(-0x8000_0000, amount - 1);

    /// <summary>
    /// A method for generating a bitmask with <paramref name="amount"/> 1s, from the left, with the rest being 0s.
    /// </summary>
    /// <param name="amount">The amount of 1s to generate.</param>
    /// <returns>A bitmask with 64 bits, with <paramref name="amount"/> 1s, from the most significant bit and down.</returns>
    public static long MakeOnesFromLeftLong(int amount) => amount % BitConstants.BitsInLong == 0 ? 0L : BitShift.Right(-0x8000_0000_0000_0000L, amount - 1);

    /// <summary>
    /// A method for generating a bitmask with <paramref name="amount"/> 0s, from the left, with the rest being 1s.
    /// </summary>
    /// <param name="amount">The amount of 0s to generate.</param>
    /// <returns>A bitmask with 8 bits, with <paramref name="amount"/> 0s, from the most significant bit and down.</returns>
    public static byte MakeZerosFromLeftByte(int amount) => amount % BitConstants.BitsInByte == 0 ? byte.MaxValue : BitShift.Right((byte)0x7f, amount - 1);

    /// <summary>
    /// A method for generating a bitmask with <paramref name="amount"/> 0s, from the left, with the rest being 1s.
    /// </summary>
    /// <param name="amount">The amount of 0s to generate.</param>
    /// <returns>A bitmask with 16 bits, with <paramref name="amount"/> 0s, from the most significant bit and down.</returns>
    public static short MakeZerosFromLeftShort(int amount) => amount % BitConstants.BitsInShort == 0 ? short.MinValue : BitShift.Right(short.MaxValue, amount - 1);

    /// <summary>
    /// A method for generating a bitmask with <paramref name="amount"/> 0s, from the left, with the rest being 1s.
    /// </summary>
    /// <param name="amount">The amount of 0s to generate.</param>
    /// <returns>A bitmask with 32 bits, with <paramref name="amount"/> 0s, from the most significant bit and down.</returns>
    public static int MakeZerosFromLeftInt(int amount) => amount % BitConstants.BitsInInt == 0 ? int.MinValue : BitShift.Right(int.MaxValue, amount - 1);

    /// <summary>
    /// A method for generating a bitmask with <paramref name="amount"/> 0s, from the left, with the rest being 1s.
    /// </summary>
    /// <param name="amount">The amount of 0s to generate.</param>
    /// <returns>A bitmask with 64 bits, with <paramref name="amount"/> 0s, from the most significant bit and down.</returns>
    public static long MakeZerosFromLeftLong(int amount) => amount % BitConstants.BitsInLong == 0 ? long.MinValue : BitShift.Right(long.MaxValue, amount - 1);

    /// <summary>
    /// A method for generating a bitmask with <paramref name="amount"/> 1s, from the right, with the rest being 0s.
    /// </summary>
    /// <param name="amount">The amount of 1s to generate.</param>
    /// <returns>A bitmask with 64 bits, with <paramref name="amount"/> 1s, from the least significant bit and up.</returns>
    public static long MakeOnesFromRight(int amount) => ~MakeZerosFromLeftLong(amount);

    /// <summary>
    /// A method for generating a bitmask with <paramref name="amount"/> 0s, from the right, with the rest being 1s.
    /// </summary>
    /// <param name="amount">The amount of 0s to generate.</param>
    /// <returns>A bitmask with 64 bits, with <paramref name="amount"/> 0s, from the least significant bit and up.</returns>
    public static long MakeZerosFromRight(int amount) => ~MakeOnesFromLeftLong(amount);
}