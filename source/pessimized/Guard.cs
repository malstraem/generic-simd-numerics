namespace System.Numerics;

internal static class Guard
{
    [MethodImpl(AggressiveInlining)]
    internal static bool IsHardware<T>() => typeof(T) == typeof(float) || typeof(T) == typeof(double);
}
