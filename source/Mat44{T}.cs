using System.Runtime.InteropServices;

namespace System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public partial struct Mat44<T>(Vec4<T> x, Vec4<T> y, Vec4<T> z, Vec4<T> w)
    where T : unmanaged, INumber<T>
{
    public Vec4<T> X = x, Y = y, Z = z, W = w;

    public Mat44(T m11, T m12, T m13, T m14,
                 T m21, T m22, T m23, T m24,
                 T m31, T m32, T m33, T m34,
                 T m41, T m42, T m43, T m44)
           : this(new(m11, m12, m13, m14),
                  new(m21, m22, m23, m24),
                  new(m31, m32, m33, m34),
                  new(m41, m42, m43, m44))
    { }

    public static Mat44<T> Identity { get; } = new
    (
        Vec4<T>.UnitX,
        Vec4<T>.UnitY,
        Vec4<T>.UnitZ,
        Vec4<T>.UnitW
    );

    public readonly bool IsIdentity =>
           X == Vec4<T>.UnitX
        && Y == Vec4<T>.UnitY
        && Z == Vec4<T>.UnitZ
        && W == Vec4<T>.UnitW;

    public readonly T TransX => W.X;

    public readonly T TransY => W.Y;

    public readonly T TransZ => W.Z;

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Add(Mat44<T> left, Mat44<T> right) => left + right;

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Subtract(Mat44<T> left, Mat44<T> right) => left - right;

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Multiply(Mat44<T> left, Mat44<T> right) => left * right;

    /* Wait for Vector4<T>.Lerp...
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Matrix44<T> Lerp(Matrix44<T> mat1, Matrix44<T> mat2, T amount) => new
    (
        Vector4<T>.Lerp(mat1.Row0, mat2.Row0, amount),
        Vector4<T>.Lerp(mat1.Row1, mat2.Row1, amount),
        Vector4<T>.Lerp(mat1.Row2, mat2.Row2, amount),
        Vector4<T>.Lerp(mat1.Row3, mat2.Row3, amount)
    );
    */

    [Obsolete("TODO")]
    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> Transpose(Mat44<T> mat) => new
    (
        mat.X.X, mat.Y.X, mat.Z.X, mat.W.X,
        mat.X.Y, mat.Y.Y, mat.Z.Y, mat.W.Y,
        mat.X.Z, mat.Y.Z, mat.Z.Z, mat.W.Z,
        mat.X.W, mat.Y.W, mat.Z.W, mat.W.W
    );

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator +(Mat44<T> left, Mat44<T> right) => new
    (
        left.X + right.X,
        left.Y + right.Y,
        left.Z + right.Z,
        left.W + right.W
    );

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator -(Mat44<T> left, Mat44<T> right) => new
    (
        left.X - right.X,
        left.Y - right.Y,
        left.Z - right.Z,
        left.W - right.W
    );

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator *(Mat44<T> mat, T value) => new
    (
        mat.X * value,
        mat.Y * value,
        mat.Z * value,
        mat.W * value
    );

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator *(Mat44<T> left, Mat44<T> right) => new
    (
        left.X.Transform(right),
        left.Y.Transform(right),
        left.Z.Transform(right),
        left.W.Transform(right)
    );

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Mat44<T> left, Mat44<T> right) => left.X == right.X
                                                                  && left.Y == right.Y
                                                                  && left.Z == right.Z
                                                                  && left.W == right.W;
    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Mat44<T> left, Mat44<T> right) => left.X != right.X
                                                                  || left.Y != right.Y
                                                                  || left.Z != right.Z
                                                                  || left.W != right.W;

    public override readonly bool Equals(object? obj) => (obj is Mat44<T> mat) && mat == this;

    public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

    public readonly bool Equals(Mat44<T> other) => other == this;
}
