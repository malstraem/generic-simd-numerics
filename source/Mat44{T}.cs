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

    public static Mat44<T> Identity { get; } = new(Vec4<T>.UnitX,
                                                   Vec4<T>.UnitY,
                                                   Vec4<T>.UnitZ,
                                                   Vec4<T>.UnitW);

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator *(Mat44<T> m, T n)
    {
        if (SizeOf<T>() == 2 && Vector256<T>.IsSupported)
            return From256(m.As256() * Vector256.Create(n));

        if (SizeOf<T>() == 4 && Vector512<T>.IsSupported)
            return From512(m.As512() * Vector512.Create(n));

        return new(m.X * n, m.Y * n, m.Z * n, m.W * n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator +(Mat44<T> a, Mat44<T> b)
    {
        if (SizeOf<T>() == 2 && Vector256<T>.IsSupported)
            return From256(a.As256() + b.As256());

        if (SizeOf<T>() == 4 && Vector512<T>.IsSupported)
            return From512(a.As512() + b.As512());

        return new(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator -(Mat44<T> a, Mat44<T> b)
    {
        if (SizeOf<T>() == 2 && Vector256<T>.IsSupported)
            return From256(a.As256() - b.As256());

        if (SizeOf<T>() == 4 && Vector512<T>.IsSupported)
            return From512(a.As512() - b.As512());

        return new(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator *(Mat44<T> a, Mat44<T> b)
    {
        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return MultiplySize4(a, b);

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return MultiplySize8(a, b);

        return new(a.X.Transform(b),
                   a.Y.Transform(b),
                   a.Z.Transform(b),
                   a.W.Transform(b));
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Mat44<T> a, Mat44<T> b)
    {
        if (SizeOf<T>() == 2 && Vector256<T>.IsSupported)
            return a.As256() == b.As256();

        if (SizeOf<T>() == 4 && Vector512<T>.IsSupported)
            return a.As512() == b.As512();

        return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
    }

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Mat44<T> a, Mat44<T> b)
    {
        if (SizeOf<T>() == 2 && Vector256<T>.IsSupported)
            return a.As256() != b.As256();

        if (SizeOf<T>() == 4 && Vector512<T>.IsSupported)
            return a.As512() != b.As512();

        return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
    }

    [Obsolete("vectorize?")]
    [MethodImpl(AggressiveInlining)]
    public Mat44<T> Transpose() => new
    (
        X.X, Y.X, Z.X, W.X,
        X.Y, Y.Y, Z.Y, W.Y,
        X.Z, Y.Z, Z.Z, W.Z,
        X.W, Y.W, Z.W, W.W
    );

    // for tests readability
    public override readonly string ToString() => $"{X} \n{Y} \n{Z} \n{W}";

    public override readonly bool Equals(object? obj) => (obj is Mat44<T> mat) && mat == this;

    public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

    public readonly bool Equals(Mat44<T> other) => other == this;
}
