namespace System.Numerics.Tests;

internal static class VecExtensions
{
    extension<T>(Vec4<T>)
#if EXPOSE_ROOT
    where T : unmanaged, INumber<T>
#else
    where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>
#endif
    {
        public static Vec4<T> Gen(T num) => new(num++, num++, num++, num++);
    }
}
