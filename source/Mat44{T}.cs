using System.Runtime.CompilerServices;

namespace System.Numerics;

public partial struct Mat44<T>
    where T : unmanaged, IBinaryNumber<T>
{
    public Vec4<T> X, Y, Z, W;

    public Mat44(Vec4<T> x, Vec4<T> y, Vec4<T> z, Vec4<T> w)
    {
        Unsafe.SkipInit(out this);

        X = x; Y = y; Z = z; W = w;
    }

    public Mat44(T m11, T m12, T m13, T m14,
                 T m21, T m22, T m23, T m24,
                 T m31, T m32, T m33, T m34,
                 T m41, T m42, T m43, T m44)
           : this(new(m11, m12, m13, m14),
                  new(m21, m22, m23, m24),
                  new(m31, m32, m33, m34),
                  new(m41, m42, m43, m44))
    { }

    public static Mat44<T> Identity => new
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

    public readonly T TranslationX => W.X;

    public readonly T TranslationY => W.Y;

    public readonly T TranslationZ => W.Z;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Mat44<T> Add(Mat44<T> left, Mat44<T> right) => left + right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Mat44<T> Subtract(Mat44<T> left, Mat44<T> right) => left - right;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Mat44<T> Transpose(Mat44<T> mat) => new
    (
        mat.X.X, mat.Y.X, mat.Z.X, mat.W.X,
        mat.X.Y, mat.Y.Y, mat.Z.Y, mat.W.Y,
        mat.X.Z, mat.Y.Z, mat.Z.Z, mat.W.Z,
        mat.X.W, mat.Y.W, mat.Z.W, mat.W.W
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Mat44<T> operator +(Mat44<T> left, Mat44<T> right) => new
    (
        left.X + right.X,
        left.Y + right.Y,
        left.Z + right.Z,
        left.W + right.W
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Mat44<T> operator -(Mat44<T> left, Mat44<T> right) => new
    (
        left.X - right.X,
        left.Y - right.Y,
        left.Z - right.Z,
        left.W - right.W
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Mat44<T> operator *(Mat44<T> mat, T value)
    {
        Mat44<T> mul;

        mul.X = mat.X * value;
        mul.Y = mat.Y * value;
        mul.Z = mat.Z * value;
        mul.W = mat.W * value;

        return mul;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Mat44<T> operator *(Mat44<T> left, Mat44<T> right) => new
    (
        Vec4<T>.Transform(left.X, right),
        Vec4<T>.Transform(left.Y, right),
        Vec4<T>.Transform(left.Z, right),
        Vec4<T>.Transform(left.W, right)
    );

    /*[MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Mat44<T> operator *(Mat44<T> left, Mat44<T> right)
    {
        var x = right.X * left.X.X;
        x += right.Y * left.X.Y;
        x += right.Z * left.X.Z;
        x += right.W * left.X.W;

        var y = right.X * left.Y.X;
        y += right.Y * left.Y.Y;
        y += right.Z * left.Y.Z;
        y += right.W * left.Y.W;

        var z = right.X * left.Z.X;
        z += right.Y * left.Z.Y;
        z += right.Z * left.Z.Z;
        z += right.W * left.Z.W;

        var w = right.X * left.W.X;
        w += right.Y * left.W.Y;
        w += right.Z * left.W.Z;
        w += right.W * left.W.W;

        return new(x, y, z, w);
    }*/

    /*[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Mat44<T> operator *(Mat44<T> left, Mat44<T> right) => new
    (
        right.X * left.X.X + right.Y * left.X.Y + right.Z * left.X.Z + right.W * left.X.W,

        right.X * left.Y.X + right.Y * left.Y.Y + right.Z * left.Y.Z + right.W * left.Y.W,

        right.X * left.Z.X + right.Y * left.Z.Y + right.Z * left.Z.Z + right.W * left.Z.W,

        right.X * left.W.X + right.Y * left.W.Y + right.Z * left.W.Z + right.W * left.W.W
    );*/

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Mat44<T> left, Mat44<T> right) => left.X == right.X
                                                                  && left.Y == right.Y
                                                                  && left.Z == right.Z
                                                                  && left.W == right.W;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Mat44<T> left, Mat44<T> right) => left.X != right.X
                                                                  || left.Y != right.Y
                                                                  || left.Z != right.Z
                                                                  || left.W != right.W;

    public override readonly bool Equals(object? obj) => (obj is Mat44<T> mat) && mat == this;

    public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

    public readonly bool Equals(Mat44<T> other) => other == this;
}
