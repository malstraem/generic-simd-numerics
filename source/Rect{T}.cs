namespace System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public partial struct Rect<T>(Vec2<T> origin, Vec2<T> max) :
    IEqualityOperators<Rect<T>, Rect<T>, bool>
        where T : unmanaged, INumber<T>
{
    public Vec2<T> Origin = origin, Max = max;

    public Rect(T ox, T oy, T mx, T my) : this(new(ox, oy), new(mx, my)) { }

    [Obsolete("vectorize")]
    public readonly Vec2<T> Size => Max - Origin;

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Rect<T> a, Rect<T> b) => a.Vec4() == b.Vec4();

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Rect<T> a, Rect<T> b) => a.Vec4() != b.Vec4();

    [MethodImpl(AggressiveInlining)]
    public readonly T Square() => Rect.Square(this);

    [MethodImpl(AggressiveInlining)]
    public readonly bool Contains(Vec2<T> point) => Rect.Contains(this, point);

    [MethodImpl(AggressiveInlining)]
    public readonly bool Contains(Rect<T> rect) => Rect.Contains(this, rect);

    [MethodImpl(AggressiveInlining)]
    public readonly bool IsIntersect(Rect<T> rect) => Rect.IsIntersect(this, rect);

    public readonly bool Equals(Rect<T> other) => this == other;

    public override readonly bool Equals(object? obj) => obj is Rect<T> other && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(Origin, Max);
}
