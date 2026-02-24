namespace System.Numerics;

public static class Vec3Extensions
{
    extension<T>(Vec3<T> vec)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public T Length() => vec.Length<T>();

        [MethodImpl(AggressiveInlining)]
        public T Distance(Vec3<T> other) => vec.Distance<T>(other);

        [MethodImpl(AggressiveInlining)]
        public Vec3<T> Normalize() => vec.Normalize<T>();

        [MethodImpl(AggressiveInlining)]
        public Vec3<T> SquareRoot() => vec.SquareRoot<T>();
    }
}

public static class Vec3StaticExtensions
{
    extension<T>(Vec3<T>)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public static T Length(Vec3<T> vec) => Vec3<T>.Length<T>(vec);

        [MethodImpl(AggressiveInlining)]
        public static T Distance(Vec3<T> left, Vec3<T> right) => Vec3<T>.Distance<T>(left, right);

        [MethodImpl(AggressiveInlining)]
        public static Vec3<T> Normalize(Vec3<T> vec) => Vec3<T>.Normalize<T>(vec);

        [MethodImpl(AggressiveInlining)]
        public static Vec3<T> SquareRoot(Vec3<T> vec) => Vec3<T>.SquareRoot<T>(vec);
    }
}
