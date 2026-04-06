namespace System.Numerics;

public static class Vec2Extensions
{
    extension<T>(Vec2<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public T Length() => v.Length<T>();

        [MethodImpl(AggressiveInlining)]
        public T Distance(Vec2<T> other) => v.Distance<T>(other);

        [MethodImpl(AggressiveInlining)]
        public Vec2<T> Normalize() => v.Normalize<T>();

        [MethodImpl(AggressiveInlining)]
        public Vec2<T> SquareRoot() => v.SquareRoot<T>();
    }
}

public static class Vec2StaticExtensions // god that extensions behavior sucks
{
    extension<T>(Vec2)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public static T Length(Vec2<T> v) => Vec2.Length<T, T>(v);

        [MethodImpl(AggressiveInlining)]
        public static T Distance(Vec2<T> a, Vec2<T> b) => Vec2.Distance<T, T>(a, b);

        [MethodImpl(AggressiveInlining)]
        public static Vec2<T> Normalize(Vec2<T> v) => Vec2.Normalize<T, T>(v);

        [MethodImpl(AggressiveInlining)]
        public static Vec2<T> SquareRoot(Vec2<T> v) => Vec2.SquareRoot<T, T>(v);
    }
}
