namespace System.Numerics;

using Silk.NET.Maths;

// only for Silk.NET convertabilty, drop

public partial struct Mat44<T>
{
    public static implicit operator Matrix4X4<T>(Mat44<T> mat) => new
    (
        mat.X.X, mat.X.Y, mat.X.Z, mat.X.W,
        mat.Y.X, mat.Y.Y, mat.Y.Z, mat.Y.W,
        mat.Z.X, mat.Z.Y, mat.Z.Z, mat.Z.W,
        mat.W.X, mat.W.Y, mat.W.Z, mat.W.W
    );

    public static implicit operator Mat44<T>(Matrix4X4<T> mat) => new
    (
        mat.M11, mat.M12, mat.M13, mat.M14,
        mat.M21, mat.M22, mat.M23, mat.M24,
        mat.M31, mat.M32, mat.M33, mat.M34,
        mat.M41, mat.M42, mat.M43, mat.M44
    );
}

public partial struct Vec4<T>
{
    public static implicit operator Vector4D<T>(Vec4<T> vec) => new
    (
        vec.X, vec.Y, vec.Z, vec.W
    );

    public static implicit operator Vec4<T>(Vector4D<T> vec) => new
    (
        vec.X, vec.Y, vec.Z, vec.W
    );
}
