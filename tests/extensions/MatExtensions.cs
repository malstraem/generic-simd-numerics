namespace System.Numerics.Tests;

public static class MatExtensions
{
    extension<T>(Mat44<T>)
#if EXPOSE_ROOT
    where T : unmanaged, INumber<T>
#else
    where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>
#endif
    {
        public static Mat44<T> Generate(T num) => new
        (
            num++, num++, num++, num++,
            num++, num++, num++, num++,
            num++, num++, num++, num++,
            num++, num++, num++, num++
        );
    }
}
