namespace System.Numerics;

public static class VecNTrigonometric
{
    extension<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>, ITrigonometricFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public Vec4<T> Sin() => Vec4.Sin(v);

        [MethodImpl(AggressiveInlining)]
        public Vec4<T> Cos() => Vec4.Cos(v);
    }

    extension<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>, ITrigonometricFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public Vec3<T> Sin() => Vec3.Sin(v);

        [MethodImpl(AggressiveInlining)]
        public Vec3<T> Cos() => Vec3.Cos(v);
    }

    extension<T>(Vec2<T> v)
        where T : unmanaged, INumber<T>, ITrigonometricFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public Vec2<T> Sin() => Vec2.Sin(v);

        [MethodImpl(AggressiveInlining)]
        public Vec2<T> Cos() => Vec2.Cos(v);
    }
}
