namespace System.Numerics;

public static class Vec3Extensions
{
    extension<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public T Length() => v.Length<T>();

        [MethodImpl(AggressiveInlining)]
        public T Distance(Vec3<T> other) => v.Distance<T>(other);

        [MethodImpl(AggressiveInlining)]
        public Vec3<T> Normalize() => v.Normalize<T>();

        [MethodImpl(AggressiveInlining)]
        public Vec3<T> SquareRoot() => v.SquareRoot<T>();
    }
}

public static class Vec3StaticExtensions
{
    extension<T>(Vec3)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public static T Length(Vec3<T> v) => Vec3.Length<T, T>(v);

        [MethodImpl(AggressiveInlining)]
        public static T Distance(Vec3<T> a, Vec3<T> b) => Vec3.Distance<T, T>(a, b);

        [MethodImpl(AggressiveInlining)]
        public static Vec3<T> Normalize(Vec3<T> v) => Vec3.Normalize<T, T>(v);

        [MethodImpl(AggressiveInlining)]
        public static Vec3<T> SquareRoot(Vec3<T> v) => Vec3.SquareRoot<T, T>(v);
    }
}
