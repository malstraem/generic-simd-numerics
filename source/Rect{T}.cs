namespace System.Numerics;

public struct Rect<T> where T : unmanaged, INumber<T>
{
    public Vec2<T> Origin;

    public Vec2<T> Max;

    public readonly Vec2<T> Size => Max - Origin;

    public Rect(Vec2<T> origin, Vec2<T> max)
    {
        Origin = origin;
        Max = max;
    }

    public Rect(T oX, T oY, T mX, T mY)
    {
        Origin = new(oX, oY);
        Max = new(mX, mY);
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public readonly T Square()
    {
        var size = Size;
        return size.X * size.Y;
    }

    public readonly bool Contains(Vec2<T> point) => point >= Origin && point <= Max;

    public readonly bool Contains(Rect<T> other) => other.Origin >= Origin && other.Max <= Max;

    public readonly bool IsIntersect(Rect<T> other) => Origin <= other.Max && Max >= other.Origin;

    public readonly Rect<T> GetTranslated(Vec2<T> distance) => new(Origin + distance, Max + distance);

    public readonly bool Equals(Rect<T> other) => Origin.Equals(other.Origin) && Max.Equals(other.Max);

    public override readonly bool Equals(object? obj) => obj is Rect<T> other && Equals(other);

    public override readonly int GetHashCode() => HashCode.Combine(Origin, Max);

    public static bool operator ==(Rect<T> left, Rect<T> right) => left.Origin == right.Origin && left.Max == right.Max;

    public static bool operator !=(Rect<T> left, Rect<T> right) => left.Origin != right.Origin && left.Max != right.Max;

    public readonly Rect<TOther> As<TOther>() where TOther : unmanaged, INumber<TOther>
        => new(Origin.As<TOther>(), Max.As<TOther>());
}
