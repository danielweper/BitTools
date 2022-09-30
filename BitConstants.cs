namespace BitTools;

public static class BitConstants
{
    // INTEGRAL TYPES
    public const int BitsInByte = 8;
    public const int BitsInShort = sizeof(short) * BitsInByte;
    public const int BitsInInt = sizeof(int) * BitsInByte;
    public const int BitsInLong = sizeof(long) * BitsInByte;

    // FLOATING POINT TYPES
    public const int BitsInFloat = sizeof(float) * BitsInByte;
    public const int BitsInDouble = sizeof(double) * BitsInByte;

    // CHARACTER TYPE
    public const int BitsInChar = sizeof(char) * BitsInByte;
}