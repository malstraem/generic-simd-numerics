namespace System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public partial struct Rect<T>(Vec2<T> origin, Vec2<T> max)
    where T : unmanaged, INumber<T>
{
    public Vec2<T> Origin = origin, Max = max;

    public Rect(T ox, T oy, T mx, T my) : this(new(ox, oy), new(mx, my)) { }

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Rect<T> a, Rect<T> b) => a.Vec4() == b.Vec4();

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Rect<T> a, Rect<T> b) => a.Vec4() != b.Vec4();

    public readonly Vec2<T> Size => Max - Origin;

    [MethodImpl(AggressiveInlining)]
    public readonly T Square()
    {
        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated))
        {
            return Square(this.Vec4());
        }
        var size = Size;
        return size.X * size.Y;
    }

    [Obsolete("vectorize")]
    [MethodImpl(AggressiveInlining)]
    public readonly bool Contains(Vec2<T> point)
    {
        return point >= Origin && point <= Max;
    }

    [MethodImpl(AggressiveInlining)]
    public readonly bool Contains(Rect<T> rect)
    {
        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated))
        {
            return Contains(rect.Vec4());
        }
        return rect.Origin >= Origin && rect.Max <= Max;
    }

    [MethodImpl(AggressiveInlining)]
    public readonly bool IsIntersect(Rect<T> rect)
    {
        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated))
        {
            return IsIntersect(rect.Vec4());
        }
        return Origin <= rect.Max && rect.Origin <= Max;
    }

    public readonly bool Equals(Rect<T> other) => this == other;

    public override readonly bool Equals(object? obj) => obj is Rect<T> other && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(Origin, Max);
}
