using Silk.NET.Maths;

namespace System.Numerics;

public static class MatExtensions
{
    extension<T>(Mat44<T> m) where T : unmanaged, INumber<T>
    {
        public static Mat44<T> Gen(T num) => new
        (
            num++, num++, num++, num++,
            num++, num++, num++, num++,
            num++, num++, num++, num++,
            num++, num++, num++, num++
        );

        public Matrix4X4<T> Silk() => new
        (
            m.X.X, m.X.Y, m.X.Z, m.X.W,
            m.Y.X, m.Y.Y, m.Y.Z, m.Y.W,
            m.Z.X, m.Z.Y, m.Z.Z, m.Z.W,
            m.W.X, m.W.Y, m.W.Z, m.W.W
        );
    }

    extension<T>(Matrix4X4<T> m) where T : unmanaged, INumber<T>
    {
        public Mat44<T> Mat44() => new
        (
            m.M11, m.M12, m.M13, m.M14,
            m.M21, m.M22, m.M23, m.M24,
            m.M31, m.M32, m.M33, m.M34,
            m.M41, m.M42, m.M43, m.M44
        );
    }

    extension(Mat44<float> m)
    {
        public Matrix4x4 System() => new
        (
            m.X.X, m.X.Y, m.X.Z, m.X.W,
            m.Y.X, m.Y.Y, m.Y.Z, m.Y.W,
            m.Z.X, m.Z.Y, m.Z.Z, m.Z.W,
            m.W.X, m.W.Y, m.W.Z, m.W.W
        );
    }
}
