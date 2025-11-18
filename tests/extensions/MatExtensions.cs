namespace System.Numerics.Tests;

public static class MatExtensions
{
    extension<T>(Mat44<T>) where T : unmanaged, IBinaryFloatingPointIeee754<T>
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
