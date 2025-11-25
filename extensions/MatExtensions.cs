using Silk.NET.Maths;

namespace System.Numerics;

public static class MatExtensions
{
    extension<T>(Mat44<T> mat) where T : unmanaged, INumber<T>
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
            mat.X.X, mat.X.Y, mat.X.Z, mat.X.W,
            mat.Y.X, mat.Y.Y, mat.Y.Z, mat.Y.W,
            mat.Z.X, mat.Z.Y, mat.Z.Z, mat.Z.W,
            mat.W.X, mat.W.Y, mat.W.Z, mat.W.W
        );
    }

    extension<T>(Matrix4X4<T> mat) where T : unmanaged, INumber<T>
    {
        public Mat44<T> Mat44() => new
        (
            mat.M11, mat.M12, mat.M13, mat.M14,
            mat.M21, mat.M22, mat.M23, mat.M24,
            mat.M31, mat.M32, mat.M33, mat.M34,
            mat.M41, mat.M42, mat.M43, mat.M44
        );
    }

    extension(Mat44<float> mat)
    {
        public Matrix4x4 System() => new
        (
            mat.X.X, mat.X.Y, mat.X.Z, mat.X.W,
            mat.Y.X, mat.Y.Y, mat.Y.Z, mat.Y.W,
            mat.Z.X, mat.Z.Y, mat.Z.Z, mat.Z.W,
            mat.W.X, mat.W.Y, mat.W.Z, mat.W.W
        );
    }

    extension(Matrix4x4 mat)
    {
        public static Matrix4x4 Gen(float num) => new
        (
            num++, num++, num++, num++,
            num++, num++, num++, num++,
            num++, num++, num++, num++,
            num++, num++, num++, num++
        );
    }
}
