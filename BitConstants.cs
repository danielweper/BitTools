namespace BitTools;

public static class BitConstants {
    public const int BitsInByte = 8;
    public const int BitsInShort = sizeof(short) * BitsInByte;
    public const int BitsInInt = sizeof(int) * BitsInByte;
    public const int BitsInLong = sizeof(long) * BitsInByte;

    public const int BitsInFloat = sizeof(float) * BitsInByte;
    public const int BitsInDouble = sizeof(double) * BitsInByte; 

    public const int BitsInChar = sizeof(char) * BitsInByte;
}