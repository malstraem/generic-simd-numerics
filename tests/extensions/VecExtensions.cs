namespace System.Numerics.Tests;

internal static class VecExtensions
{
    extension<T>(Vec4<T>) where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>
    {
        public static Vec4<T> Generate(T num) => new(num++, num++, num++, num++);
    }
}
