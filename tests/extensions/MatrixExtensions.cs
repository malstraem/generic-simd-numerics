namespace System.Numerics.Tests;

public static class MatrixExtensions
{
    extension<T>(Mat44<T>) where T : unmanaged, IBinaryNumber<T>
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
