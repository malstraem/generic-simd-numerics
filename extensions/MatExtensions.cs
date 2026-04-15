using System.Runtime.CompilerServices;

using Silk.NET.Maths;

namespace System.Numerics;

internal static class MatExtensions
{
    extension<T>(Mat44<T> m)
        where T : unmanaged, INumber<T>
    {
        internal static Mat44<T> Gen(T num) => new
        (
            num++, num++, num++, num++,
            num++, num++, num++, num++,
            num++, num++, num++, num++,
            num++, num++, num++, num++
        );

        internal Matrix4X4<T> Silk() => Unsafe.BitCast<Mat44<T>, Matrix4X4<T>>(m);
    }

    extension<T>(Matrix4X4<T> m)
        where T : unmanaged, INumber<T>
    {
        internal Mat44<T> Mat44() => Unsafe.BitCast<Matrix4X4<T>, Mat44<T>>(m);
    }

    extension(Mat44<float> m)
    {
        internal Matrix4x4 System() => Unsafe.BitCast<Mat44<float>, Matrix4x4>(m);
    }

    extension(Matrix4x4 m)
    {
        internal Mat44<float> Mat44() => Unsafe.BitCast<Matrix4x4, Mat44<float>>(m);
    }
}
