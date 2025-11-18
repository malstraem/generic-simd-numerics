namespace System.Numerics.Tests;

internal static class VecExtensions
{
    extension<T>(Vec4<T>) where T : unmanaged, IBinaryFloatingPointIeee754<T>
    {
        public static Vec4<T> Generate(T num) => new(num++, num++, num++, num++);
    }
}
