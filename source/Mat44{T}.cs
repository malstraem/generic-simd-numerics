using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public partial struct Mat44<T>(Vec4<T> x, Vec4<T> y, Vec4<T> z, Vec4<T> w)
    where T : unmanaged, INumber<T>
{
    public Vec4<T> X = x, Y = y, Z = z, W = w;

    public Mat44(T m11, T m12, T m13, T m14,
                 T m21, T m22, T m23, T m24,
                 T m31, T m32, T m33, T m34,
                 T m41, T m42, T m43, T m44) : this(new(m11, m12, m13, m14),
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

    public readonly bool IsIdentity => X == Vec4<T>.UnitX
                                    && Y == Vec4<T>.UnitY
                                    && Z == Vec4<T>.UnitZ
                                    && W == Vec4<T>.UnitW;
    public readonly T TransX => W.X;

    public readonly T TransY => W.Y;

    public readonly T TransZ => W.Z;

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> operator +(Mat44<T> left, Mat44<T> right)
    {
        if (typeof(T) != typeof(float))
        {
            return new(left.X + right.X,
                       left.Y + right.Y,
                       left.Z + right.Z,
                       left.W + right.W);
        }

        var l = Unsafe.BitCast<Mat44<T>, Vector512<T>>(left);
        var r = Unsafe.BitCast<Mat44<T>, Vector512<T>>(right);

        return Unsafe.BitCast<Vector512<T>, Mat44<T>>(l + r);

        /*return new(Vec4<T>.From128(add.GetLower().GetLower()),
                   Vec4<T>.From128(add.GetLower().GetUpper()),
                   Vec4<T>.From128(add.GetUpper().GetLower()),
                   Vec4<T>.From128(add.GetUpper().GetUpper()));*/
    }

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator -(Mat44<T> left, Mat44<T> right) => new
    (
        left.X - right.X,
        left.Y - right.Y,
        left.Z - right.Z,
        left.W - right.W
    );

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator *(Mat44<T> mat, T num) => new
    (
        mat.X * num,
        mat.Y * num,
        mat.Z * num,
        mat.W * num
    );

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator *(Mat44<T> left, Mat44<T> right)
    {
        if (typeof(T) != typeof(float))
        {
            return new(left.X.Transform(right),
                       left.Y.Transform(right),
                       left.Z.Transform(right),
                       left.W.Transform(right));
        }

        var result = Vector256.Create((right.X * left.X.X).As128F(), (right.X * left.Y.X).As128F());

        result = Vector256.MultiplyAddEstimate(
            Vector256.Create(right.Y.As128F(), right.Y.As128F()),
            Vector256.Create(Vector128.Create((float)(object)left.X.Y), Vector128.Create((float)(object)left.Y.Y)),
            result);

        result = Vector256.MultiplyAddEstimate(
            Vector256.Create(right.Z.As128F(), right.Z.As128F()),
            Vector256.Create(Vector128.Create((float)(object)left.X.Z), Vector128.Create((float)(object)left.Y.Z)),
            result);

        result = Vector256.MultiplyAddEstimate(
            Vector256.Create(right.W.As128F(), right.W.As128F()),
            Vector256.Create(Vector128.Create((float)(object)left.X.W), Vector128.Create((float)(object)left.Y.W)),
            result);

        var result2 = Vector256.Create((right.X * left.Z.X).As128F(), (right.X * left.W.X).As128F());

        result2 = Vector256.MultiplyAddEstimate(
            Vector256.Create(right.Y.As128F(), right.Y.As128F()),
            Vector256.Create(Vector128.Create((float)(object)left.Z.Y), Vector128.Create((float)(object)left.W.Y)),
            result2);

        result2 = Vector256.MultiplyAddEstimate(
            Vector256.Create(right.Z.As128F(), right.Z.As128F()),
            Vector256.Create(Vector128.Create((float)(object)left.Z.Z), Vector128.Create((float)(object)left.W.Z)),
            result2);

        result2 = Vector256.MultiplyAddEstimate(
            Vector256.Create(right.W.As128F(), right.W.As128F()),
            Vector256.Create(Vector128.Create((float)(object)left.Z.W), Vector128.Create((float)(object)left.W.W)),
            result2);

        return new Mat44<T>(Vec4<T>.From128(result.GetLower()),
                            Vec4<T>.From128(result.GetUpper()),
                            Vec4<T>.From128(result2.GetLower()),
                            Vec4<T>.From128(result2.GetUpper()));
    }

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
    public Mat44<T> Transpose() => new
    (
        X.X, Y.X, Z.X, W.X,
        X.Y, Y.Y, Z.Y, W.Y,
        X.Z, Y.Z, Z.Z, W.Z,
        X.W, Y.W, Z.W, W.W
    );

    public override readonly bool Equals(object? obj) => (obj is Mat44<T> mat) && mat == this;

    public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

    public readonly bool Equals(Mat44<T> other) => other == this;
}
