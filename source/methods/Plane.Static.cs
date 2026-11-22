namespace System.Numerics;

public static class PlaneMethods // OOPSIE WOOPSIE, struct name...
{
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
