namespace System.Numerics.Tests;

public static class MatrixExtensions
{
    extension<T>(Matrix44<T>) where T : unmanaged, IBinaryNumber<T>
    {
        public static Matrix44<T> Generate(T num) => new
        (
            num++, num++, num++, num++,
            num++, num++, num++, num++,
            num++, num++, num++, num++,
            num++, num++, num++, num++
        );
    }
}
