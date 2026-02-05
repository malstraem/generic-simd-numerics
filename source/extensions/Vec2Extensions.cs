namespace System.Numerics;

public static class Vec2Extensions
{
    extension<T>(Vec2<T> vec) where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public T Length() => vec.Length<T>();

        [MethodImpl(AggressiveInlining)]
        public T Distance(Vec2<T> other) => vec.Distance<T>(other);

        [MethodImpl(AggressiveInlining)]
        public Vec2<T> Normalize() => vec.Normalize<T>();

        [MethodImpl(AggressiveInlining)]
        public Vec2<T> SquareRoot() => vec.SquareRoot<T>();
    }
}

public static class Vec2StaticExtensions // god that extensions behavior sucks
{
    extension<T>(Vec2<T>) where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public static T Length(Vec2<T> vec) => Vec2<T>.Length<T>(vec);

        [MethodImpl(AggressiveInlining)]
        public static T Distance(Vec2<T> left, Vec2<T> right) => Vec2<T>.Distance<T>(left, right);

        [MethodImpl(AggressiveInlining)]
        public static Vec2<T> Normalize(Vec2<T> vec) => Vec2<T>.Normalize<T>(vec);

        [MethodImpl(AggressiveInlining)]
        public static Vec2<T> SquareRoot(Vec2<T> vec) => Vec2<T>.SquareRoot<T>(vec);
    }
}
