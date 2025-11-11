using System.Runtime.CompilerServices;

namespace System.Numerics;

public partial struct Matrix44<T>(Vector4<T> row1, Vector4<T> row2, Vector4<T> row3, Vector4<T> row4)
    where T : unmanaged, IBinaryNumber<T>
{
    public Vector4<T> Row1 = row1, Row2 = row2, Row3 = row3, Row4 = row4;

    public Matrix44(T m11, T m12, T m13, T m14,
                 T m21, T m22, T m23, T m24,
                 T m31, T m32, T m33, T m34,
                 T m41, T m42, T m43, T m44)
           : this(new(m11, m12, m13, m14),
                  new(m21, m22, m23, m24),
                  new(m31, m32, m33, m34),
                  new(m41, m42, m43, m44))
    { }

    public static Matrix44<T> Identity => new
    (
        Vector4<T>.UnitX,
        Vector4<T>.UnitY,
        Vector4<T>.UnitZ,
        Vector4<T>.UnitW
    );

    public readonly bool IsIdentity =>
           Row1 == Vector4<T>.UnitX
        && Row2 == Vector4<T>.UnitY
        && Row3 == Vector4<T>.UnitZ
        && Row4 == Vector4<T>.UnitW;

    public readonly T TranslationX => Row4.X;

    public readonly T TranslationY => Row4.Y;

    public readonly T TranslationZ => Row4.Z;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Matrix44<T> Add(Matrix44<T> mat1, Matrix44<T> mat2) => mat1 + mat2;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Matrix44<T> Subtract(Matrix44<T> mat1, Matrix44<T> mat2) => mat1 - mat2;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Matrix44<T> Multiply(Matrix44<T> mat1, Matrix44<T> mat2) => mat1 * mat2;

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
    public static Matrix44<T> Transpose(Matrix44<T> mat) => new
    (
        mat.Row1.X, mat.Row2.X, mat.Row3.X, mat.Row4.X,
        mat.Row1.Y, mat.Row2.Y, mat.Row3.Y, mat.Row4.Y,
        mat.Row1.Z, mat.Row2.Z, mat.Row3.Z, mat.Row4.Z,
        mat.Row1.W, mat.Row2.W, mat.Row3.W, mat.Row4.W
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Matrix44<T> operator +(Matrix44<T> left, Matrix44<T> right) => new
    (
        left.Row1 + right.Row1,
        left.Row2 + right.Row2,
        left.Row3 + right.Row3,
        left.Row4 + right.Row4
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Matrix44<T> operator -(Matrix44<T> left, Matrix44<T> right) => new
    (
        left.Row1 - right.Row1,
        left.Row2 - right.Row2,
        left.Row3 - right.Row3,
        left.Row4 - right.Row4
    );

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Matrix44<T> operator *(Matrix44<T> mat1, Matrix44<T> mat2)
    {
        var row0 = mat2.Row1 * mat1.Row1.X;
        row0 += mat2.Row2 * mat1.Row1.Y;
        row0 += mat2.Row3 * mat1.Row1.Z;
        row0 += mat2.Row4 * mat1.Row1.W;

        var row1 = mat2.Row1 * mat1.Row2.X;
        row1 += mat2.Row2 * mat1.Row2.Y;
        row1 += mat2.Row3 * mat1.Row2.Z;
        row1 += mat2.Row4 * mat1.Row2.W;

        var row2 = mat2.Row1 * mat1.Row3.X;
        row2 += mat2.Row2 * mat1.Row3.Y;
        row2 += mat2.Row3 * mat1.Row3.Z;
        row2 += mat2.Row4 * mat1.Row3.W;

        var row3 = mat2.Row1 * mat1.Row4.X;
        row3 += mat2.Row2 * mat1.Row4.Y;
        row3 += mat2.Row3 * mat1.Row4.Z;
        row3 += mat2.Row4 * mat1.Row4.W;

        return new(row0, row1, row2, row3);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(Matrix44<T> mat1, Matrix44<T> mat2) => mat1.Row1 == mat2.Row1
                                                                       && mat1.Row2 == mat2.Row2
                                                                       && mat1.Row3 == mat2.Row3
                                                                       && mat1.Row4 == mat2.Row4;
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(Matrix44<T> mat1, Matrix44<T> mat2) => mat1.Row1 != mat2.Row1
                                                                       || mat1.Row2 != mat2.Row2
                                                                       || mat1.Row3 != mat2.Row3
                                                                       || mat1.Row4 != mat2.Row4;

    public override readonly bool Equals(object? obj) => (obj is Matrix44<T> matrix) && matrix == this;

    public override readonly int GetHashCode() => HashCode.Combine(Row1, Row2, Row3, Row4);

    public readonly bool Equals(Matrix44<T> other) => other == this;
}
