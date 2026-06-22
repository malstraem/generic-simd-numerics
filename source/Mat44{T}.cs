namespace System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public partial struct Mat44<T>(Vec4<T> x, Vec4<T> y, Vec4<T> z, Vec4<T> w) :
    IMultiplyOperators<Mat44<T>, Mat44<T>, Mat44<T>>,

    IAdditionOperators<Mat44<T>, Mat44<T>, Mat44<T>>,
    ISubtractionOperators<Mat44<T>, Mat44<T>, Mat44<T>>,

    IEqualityOperators<Mat44<T>, Mat44<T>, bool>
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

    public static Mat44<T> Identity { get; } = new(Vec4<T>.UnitX,
                                                   Vec4<T>.UnitY,
                                                   Vec4<T>.UnitZ,
                                                   Vec4<T>.UnitW);

    public readonly bool IsIdentity => this == Identity;

    #region Operators
    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Mat44<T> a, Mat44<T> b) => Mat44.Equal(a, b);

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Mat44<T> a, Mat44<T> b) => Mat44.NotEqual(a, b);

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator *(Mat44<T> m, T n) => Mat44.Multiply(m, n);

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator +(Mat44<T> a, Mat44<T> b) => Mat44.Add(a, b);

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator -(Mat44<T> a, Mat44<T> b) => Mat44.Subtract(a, b);

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator *(Mat44<T> a, Mat44<T> b) => Mat44.Multiply(a, b);
    #endregion

    [MethodImpl(AggressiveInlining)]
    public readonly Mat44<T> Transpose() => Mat44.Transpose(this);

    public readonly Mat44<TOther> As<TOther>()
        where TOther : unmanaged, INumber<TOther>
            => Mat44.As<T, TOther>(this);

    public readonly bool Equals(Mat44<T> other) => this == other;

    public override readonly bool Equals(object? obj) => (obj is Mat44<T> other) && this == other;

    public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

    // for tests readability
    public override readonly string ToString() => $"\n{X} \n{Y} \n{Z} \n{W}";
}
