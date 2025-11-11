namespace System.Numerics.Tests;

internal static class Vector4Extensions
{
    extension<T>(Vector4<T>) where T : unmanaged, IBinaryNumber<T>
    {
        public static Vector4<T> Generate(T num) => new(num++, num++, num++, num++);
    }
}
