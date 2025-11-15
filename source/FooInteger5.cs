using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Numerics;

[InlineArray(5)]
public struct FooInteger5 : IBinaryInteger<FooInteger5>
{
    public byte Value;

    private static FooInteger5 OneBiba()
    {
        FooInteger5 num = new();

        num[0] = 1;
        num[1] = 1;
        num[2] = 1;
        num[3] = 1;
        num[4] = 1;

        return num;
    }

    public static FooInteger5 One => OneBiba();

    public static int Radix => throw new NotImplementedException();

    public static FooInteger5 Zero => new();

    public static FooInteger5 AdditiveIdentity => throw new NotImplementedException();

    public static FooInteger5 MultiplicativeIdentity => throw new NotImplementedException();

    public static FooInteger5 Abs(FooInteger5 value) => throw new NotImplementedException();

    public static bool IsCanonical(FooInteger5 value) => throw new NotImplementedException();

    public static bool IsComplexNumber(FooInteger5 value) => throw new NotImplementedException();

    public static bool IsEvenInteger(FooInteger5 value) => throw new NotImplementedException();

    public static bool IsFinite(FooInteger5 value) => throw new NotImplementedException();

    public static bool IsImaginaryNumber(FooInteger5 value) => throw new NotImplementedException();

    public static bool IsInfinity(FooInteger5 value) => throw new NotImplementedException();

    public static bool IsInteger(FooInteger5 value) => throw new NotImplementedException();

    public static bool IsNaN(FooInteger5 value) => throw new NotImplementedException();

    public static bool IsNegative(FooInteger5 value) => throw new NotImplementedException();

    public static bool IsNegativeInfinity(FooInteger5 value) => throw new NotImplementedException();

    public static bool IsNormal(FooInteger5 value) => throw new NotImplementedException();

    public static bool IsOddInteger(FooInteger5 value) => throw new NotImplementedException();

    public static bool IsPositive(FooInteger5 value) => throw new NotImplementedException();

    public static bool IsPositiveInfinity(FooInteger5 value) => throw new NotImplementedException();

    public static bool IsPow2(FooInteger5 value) => throw new NotImplementedException();

    public static bool IsRealNumber(FooInteger5 value) => throw new NotImplementedException();

    public static bool IsSubnormal(FooInteger5 value) => throw new NotImplementedException();

    public static bool IsZero(FooInteger5 value) => throw new NotImplementedException();

    public static FooInteger5 Log2(FooInteger5 value) => throw new NotImplementedException();

    public static FooInteger5 MaxMagnitude(FooInteger5 x, FooInteger5 y) => throw new NotImplementedException();

    public static FooInteger5 MaxMagnitudeNumber(FooInteger5 x, FooInteger5 y) => throw new NotImplementedException();

    public static FooInteger5 MinMagnitude(FooInteger5 x, FooInteger5 y) => throw new NotImplementedException();

    public static FooInteger5 MinMagnitudeNumber(FooInteger5 x, FooInteger5 y) => throw new NotImplementedException();

    public static FooInteger5 Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider) => throw new NotImplementedException();

    public static FooInteger5 Parse(string s, NumberStyles style, IFormatProvider? provider) => throw new NotImplementedException();

    public static FooInteger5 Parse(ReadOnlySpan<char> s, IFormatProvider? provider) => throw new NotImplementedException();

    public static FooInteger5 Parse(string s, IFormatProvider? provider) => throw new NotImplementedException();

    public static FooInteger5 PopCount(FooInteger5 value) => throw new NotImplementedException();

    public static FooInteger5 TrailingZeroCount(FooInteger5 value) => throw new NotImplementedException();

    public static bool TryConvertFromChecked<TOther>(TOther value, [MaybeNullWhen(false)] out FooInteger5 result) where TOther : INumberBase<TOther> => throw new NotImplementedException();

    public static bool TryConvertFromSaturating<TOther>(TOther value, [MaybeNullWhen(false)] out FooInteger5 result) where TOther : INumberBase<TOther> => throw new NotImplementedException();

    public static bool TryConvertFromTruncating<TOther>(TOther value, [MaybeNullWhen(false)] out FooInteger5 result) where TOther : INumberBase<TOther> => throw new NotImplementedException();

    public static bool TryConvertToChecked<TOther>(FooInteger5 value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther> => throw new NotImplementedException();

    public static bool TryConvertToSaturating<TOther>(FooInteger5 value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther> => throw new NotImplementedException();

    public static bool TryConvertToTruncating<TOther>(FooInteger5 value, [MaybeNullWhen(false)] out TOther result) where TOther : INumberBase<TOther> => throw new NotImplementedException();

    public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out FooInteger5 result) => throw new NotImplementedException();

    public static bool TryParse([NotNullWhen(true)] string? s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out FooInteger5 result) => throw new NotImplementedException();

    public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out FooInteger5 result) => throw new NotImplementedException();

    public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out FooInteger5 result) => throw new NotImplementedException();

    public static bool TryReadBigEndian(ReadOnlySpan<byte> source, bool isUnsigned, out FooInteger5 value) => throw new NotImplementedException();

    public static bool TryReadLittleEndian(ReadOnlySpan<byte> source, bool isUnsigned, out FooInteger5 value) => throw new NotImplementedException();

    public int CompareTo(object? obj) => throw new NotImplementedException();

    public int CompareTo(FooInteger5 other) => throw new NotImplementedException();

    public bool Equals(FooInteger5 other) => throw new NotImplementedException();

    public int GetByteCount() => throw new NotImplementedException();

    public int GetShortestBitLength() => throw new NotImplementedException();

    public string ToString(string? format, IFormatProvider? formatProvider) => throw new NotImplementedException();

    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => throw new NotImplementedException();

    public bool TryWriteBigEndian(Span<byte> destination, out int bytesWritten) => throw new NotImplementedException();

    public bool TryWriteLittleEndian(Span<byte> destination, out int bytesWritten) => throw new NotImplementedException();

    public static FooInteger5 operator +(FooInteger5 value) => throw new NotImplementedException();

    public static FooInteger5 operator +(FooInteger5 left, FooInteger5 right)
    {
        left[0] += right[0];
        left[1] += right[1];
        left[2] += right[2];
        left[3] += right[3];
        left[4] += right[4];

        return left;
    }

    public static FooInteger5 operator -(FooInteger5 value) => throw new NotImplementedException();

    public static FooInteger5 operator -(FooInteger5 left, FooInteger5 right) => throw new NotImplementedException();

    public static FooInteger5 operator ~(FooInteger5 value) => throw new NotImplementedException();

    // incorrect and no meaning, only for tests
    public static FooInteger5 operator ++(FooInteger5 value)
    {
        value.Value++;
        return value;
    }

    public static FooInteger5 operator --(FooInteger5 value) => throw new NotImplementedException();

    public static FooInteger5 operator *(FooInteger5 left, FooInteger5 right)
    {
        left[0] += right[0];
        left[1] += right[1];
        left[2] += right[2];
        left[3] += right[3];
        left[4] += right[4];

        return left;
    }

    public static FooInteger5 operator /(FooInteger5 left, FooInteger5 right) => throw new NotImplementedException();

    public static FooInteger5 operator %(FooInteger5 left, FooInteger5 right) => throw new NotImplementedException();

    public static FooInteger5 operator &(FooInteger5 left, FooInteger5 right) => throw new NotImplementedException();

    public static FooInteger5 operator |(FooInteger5 left, FooInteger5 right) => throw new NotImplementedException();

    public static FooInteger5 operator ^(FooInteger5 left, FooInteger5 right) => throw new NotImplementedException();

    public static FooInteger5 operator <<(FooInteger5 value, int shiftAmount) => throw new NotImplementedException();

    public static FooInteger5 operator >>(FooInteger5 value, int shiftAmount) => throw new NotImplementedException();

    public static bool operator ==(FooInteger5 left, FooInteger5 right) => throw new NotImplementedException();

    public static bool operator !=(FooInteger5 left, FooInteger5 right) => throw new NotImplementedException();

    public static bool operator <(FooInteger5 left, FooInteger5 right) => throw new NotImplementedException();

    public static bool operator >(FooInteger5 left, FooInteger5 right) => throw new NotImplementedException();

    public static bool operator <=(FooInteger5 left, FooInteger5 right) => throw new NotImplementedException();

    public static bool operator >=(FooInteger5 left, FooInteger5 right) => throw new NotImplementedException();

    public static FooInteger5 operator >>>(FooInteger5 value, int shiftAmount) => throw new NotImplementedException();

    public override bool Equals(object? obj) => throw new NotImplementedException();

    public override int GetHashCode() => throw new NotImplementedException();
}
