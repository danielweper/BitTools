using Xunit;

namespace BitTools.Tests;

public class BitContainerTests
{
    [Fact]
    public void ByteToSbyteToByte_DoesNotChangeValue()
    {
        byte value = 5;
        sbyte switchedValue = BitContainer.ByteToSByte(value);
        byte doubleSwitchedValue = BitContainer.SByteToByte(switchedValue);

        Assert.Equal(value, doubleSwitchedValue);
    }
    
    [Fact]
    public void SByteToByteToSbyte_DoesNotChangeValue()
    {
        sbyte value = -3;
        byte switchedValue = BitContainer.SByteToByte(value);
        sbyte doubleSwitchedValue = BitContainer.ByteToSByte(switchedValue);

        Assert.Equal(value, doubleSwitchedValue);
    }

    [Fact]
    public void ShortToUshortToShort_DoesNotChangeValue()
    {
        short value = -17;
        ushort switchedValue = BitContainer.ShortToUShort(value);
        short doubleSwitchedValue = BitContainer.UShortToShort(switchedValue);

        Assert.Equal(value, doubleSwitchedValue);
    }

    [Fact]
    public void UshortToShortToUshort_DoesNotChangeValue()
    {
        ushort value = 12;
        short switchedValue = BitContainer.UShortToShort(value);
        ushort doubleSwitchedValue = BitContainer.ShortToUShort(switchedValue);

        Assert.Equal(value, doubleSwitchedValue);
    }

    [Fact]
    public void IntToUintToInt_DoesNotChangeValue()
    {
        int value = -4;
        uint switchedValue = BitContainer.IntToUInt(value);
        int doubleSwitchedValue = BitContainer.UIntToInt(switchedValue);

        Assert.Equal(value, doubleSwitchedValue);
    }

    [Fact]
    public void UintToIntToUint_DoesNotChangeValue()
    {
        uint value = 10000;
        int switchedValue = BitContainer.UIntToInt(value);
        uint doubleSwitchedValue = BitContainer.IntToUInt(switchedValue);

        Assert.Equal(value, doubleSwitchedValue);
    }

    [Fact]
    public void LongToUlongToLong_DoesNotChangeValue()
    {
        long value = 2;
        ulong switchedValue = BitContainer.LongToULong(value);
        long doubleSwitchedValue = BitContainer.ULongToLong(switchedValue);

        Assert.Equal(value, doubleSwitchedValue);
    }

    [Fact]
    public void UlongToLongToUlong_DoesNotChangeValue()
    {
        ulong value = 15;
        long switchedValue = BitContainer.ULongToLong(value);
        ulong doubleSwitchedValue = BitContainer.LongToULong(switchedValue);

        Assert.Equal(value, doubleSwitchedValue);
    }
}