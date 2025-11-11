using Silk.NET.Maths;

namespace System.Numerics;

/* Only for tests, drop */

public partial struct Matrix44<T>
{
    public static implicit operator Matrix4X4<T>(Matrix44<T> mat) => new
    (
        mat.Row1.X, mat.Row1.Y, mat.Row1.Z, mat.Row1.W,
        mat.Row2.X, mat.Row2.Y, mat.Row2.Z, mat.Row2.W,
        mat.Row3.X, mat.Row3.Y, mat.Row3.Z, mat.Row3.W,
        mat.Row4.X, mat.Row4.Y, mat.Row4.Z, mat.Row4.W
    );

    public static implicit operator Matrix44<T>(Matrix4X4<T> mat) => new
    (
        mat.M11, mat.M12, mat.M13, mat.M14,
        mat.M21, mat.M22, mat.M23, mat.M24,
        mat.M31, mat.M32, mat.M33, mat.M34,
        mat.M41, mat.M42, mat.M43, mat.M44
    );
}

public partial struct Vector4<T>
{
    public static implicit operator Vector4D<T>(Vector4<T> vec) => new
    (
        vec.X, vec.Y, vec.Z, vec.W
    );

    public static implicit operator Vector4<T>(Vector4D<T> vec) => new
    (
        vec.X, vec.Y, vec.Z, vec.W
    );
}
