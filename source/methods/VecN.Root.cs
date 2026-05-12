namespace System.Numerics;

public static class Vec4Root
{
    extension<T>(Vec2<T> v)
       where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public T Length() => Vec2.Length(v);

        [MethodImpl(AggressiveInlining)]
        public T Distance(Vec2<T> b) => Vec2.Distance(v, b);

        [MethodImpl(AggressiveInlining)]
        public Vec2<T> Normalize() => Vec2.Normalize(v);

        [MethodImpl(AggressiveInlining)]
        public Vec2<T> SquareRoot() => Vec2.SquareRoot(v);
    }

    extension<T>(Vec3<T> v)
       where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public T Length() => Vec3.Length(v);

        [MethodImpl(AggressiveInlining)]
        public T Distance(Vec3<T> b) => Vec3.Distance(v, b);

        [MethodImpl(AggressiveInlining)]
        public Vec3<T> Normalize() => Vec3.Normalize(v);

        [MethodImpl(AggressiveInlining)]
        public Vec3<T> SquareRoot() => Vec3.SquareRoot(v);
    }

    extension<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public T Length() => Vec4.Length(v);

        [MethodImpl(AggressiveInlining)]
        public T Distance(Vec4<T> b) => Vec4.Distance(v, b);

        [MethodImpl(AggressiveInlining)]
        public Vec4<T> Normalize() => Vec4.Normalize(v);

        [MethodImpl(AggressiveInlining)]
        public Vec4<T> SquareRoot() => Vec4.SquareRoot(v);
    }
}
