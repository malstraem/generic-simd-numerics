namespace System.Numerics;

internal static class ReinterpretatePlane
{
    extension<T>(Plane<T> q)
        where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        internal Vec4<T> Vec4() => BitCast<Plane<T>, Vec4<T>>(q);
    }
}
