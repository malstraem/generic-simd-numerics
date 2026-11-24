namespace System.Numerics;

public static class Mat44Floating
{
    extension<T>(Mat44<T> m)
        where T : unmanaged, IFloatingPoint<T>
    {
        [MethodImpl(AggressiveInlining)]
        public bool TryInvert(out Mat44<T> inv) => Mat44.TryInvert(m, out inv);
    }
}
