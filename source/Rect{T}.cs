namespace System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public struct Rect<T>(Vec2<T> origin, Vec2<T> max)
    where T : unmanaged, INumber<T>
{
    public Vec2<T> Origin = origin, Max = max;

    public Rect(T oX, T oY, T mX, T mY) : this(new(oX, oY), new(mX, mY)) { }

    public readonly Vec2<T> Size => Max - Origin;

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Rect<T> a, Rect<T> b) => a.Vec4() == b.Vec4();

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Rect<T> a, Rect<T> b) => a.Vec4() != b.Vec4();

    [MethodImpl(AggressiveInlining)]
    public readonly T Square()
    {
        var size = Size;
        return size.X * size.Y;
    }

    [MethodImpl(AggressiveInlining)]
    public readonly bool Contains(Vec2<T> point) => point >= Origin && point <= Max;

    [MethodImpl(AggressiveInlining)]
    public readonly bool Contains(Rect<T> other) => other.Origin >= Origin && other.Max <= Max;

    [MethodImpl(AggressiveInlining)]
    public readonly bool IsIntersectNaive(Rect<T> other) => Origin <= other.Max && other.Origin <= Max;

    [MethodImpl(AggressiveInlining)]
    [Obsolete("hardcode todo")]
    public readonly bool IsIntersectVectorized(Rect<T> other)
    {
        var a = this.As128();
        var b = other.As128().Permute32(2, 3, 0, 1);

        return Vector128.LessThanOrEqualAll(a, b);
    }

    public readonly bool Equals(Rect<T> other) => this == other;

    public override readonly bool Equals(object? obj) => obj is Rect<T> other && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(Origin, Max);
}
