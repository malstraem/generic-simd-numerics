namespace System.Numerics;

public static class Planes // OOPSIE WOOPSIE, struct name...
{
    [MethodImpl(AggressiveInlining)]
    public static bool Equal<T>(Plane<T> a, Plane<T> b)
        where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>
            => Vec4.Equal(a.Vec4(), b.Vec4());

    [MethodImpl(AggressiveInlining)]
    public static bool Equal<T>(Plane<T> a, Plane<T> b, T eps)
        where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>
            => Vec4.Equal(a.Vec4(), b.Vec4(), eps);

    [MethodImpl(AggressiveInlining)]
    public static bool NotEqual<T>(Plane<T> a, Plane<T> b)
        where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>
            => Vec4.NotEqual(a.Vec4(), b.Vec4());

    [MethodImpl(AggressiveInlining)]
    public static T Dot<T>(Plane<T> p, Vec4<T> v)
        where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>
            => Vec4.Dot(p.Vec4(), v);

    [MethodImpl(AggressiveInlining)]
    public static Plane<T2> As<T, T2>(Plane<T> p)
        where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>
        where T2 : unmanaged, IFloatingPoint<T2>, IRootFunctions<T2>
            => Vec4.As<T, T2>(p.Vec4()).Plane();
}
