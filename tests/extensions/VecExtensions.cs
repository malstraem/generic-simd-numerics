namespace System.Numerics.Tests;

internal static class VecExtensions
{
    extension<T>(Vec4<T>) where T : unmanaged, /*IFloatingPoint<T>, IRootFunctions<T>*/ INumber<T>
    {
        public static Vec4<T> Gen(T num) => new(num++, num++, num++, num++);
    }
}
