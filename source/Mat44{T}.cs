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

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator *(Mat44<T> m, T n)
    {
        if (SizeOf<T>() == 2 && Vector256<T>.IsSupported)
            return (m.As256() * n).Mat44();

        if (Vector512<T>.IsSupported)
        {
            if (SizeOf<T>() == 4)
                return (m.As512() * n).Mat44();

            if (SizeOf<T>() == 8)
            {
                m.As512(out var xy, out var zw);
                xy *= n;
                zw *= n;
                return xy.Mat44(zw);
            }
        }
        return new(m.X * n, m.Y * n, m.Z * n, m.W * n);
    }

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator +(Mat44<T> a, Mat44<T> b)
    {
        if (SizeOf<T>() == 2 && Vector256<T>.IsSupported)
            return (a.As256() + b.As256()).Mat44();

        if (Vector512<T>.IsSupported)
        {
            if (SizeOf<T>() == 4)
                return (a.As512() + b.As512()).Mat44();

            if (SizeOf<T>() == 8)
            {
                a.As512(out var axy, out var azw);
                b.As512(out var bxy, out var bzw);
                axy += bxy;
                azw += bzw;
                return axy.Mat44(azw);
            }
        }
        return new(a.X + b.X, a.Y + b.Y, a.Z + b.Z, a.W + b.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator -(Mat44<T> a, Mat44<T> b)
    {
        if (SizeOf<T>() == 2 && Vector256<T>.IsSupported)
            return (a.As256() - b.As256()).Mat44();

        if (Vector512<T>.IsSupported)
        {
            if (SizeOf<T>() == 4)
                return (a.As512() - b.As512()).Mat44();

            if (SizeOf<T>() == 8)
            {
                a.As512(out var axy, out var azw);
                b.As512(out var bxy, out var bzw);
                axy -= bxy;
                azw -= bzw;
                return axy.Mat44(azw);
            }
        }
        return new(a.X - b.X, a.Y - b.Y, a.Z - b.Z, a.W - b.W);
    }

    [MethodImpl(AggressiveInlining)]
    public static Mat44<T> operator *(Mat44<T> a, Mat44<T> b)
    {
        // both "hand" and "transform" vectorized ways are non-optimal now
        // asm is dummy different from System.Numerics - performance is close, but should be better

        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
            return Multiply128(a, b);

        if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
            return Multiply256(a, b);

        Mat44<T> m;

        m.X = a.X.Transform(b);
        m.Y = a.Y.Transform(b);
        m.Z = a.Z.Transform(b);
        m.W = a.W.Transform(b);

        return m;
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

    [Obsolete("vectorize")]
    [MethodImpl(AggressiveInlining)]
    public Mat44<T> Transpose() => new
    (
        X.X, Y.X, Z.X, W.X,
        X.Y, Y.Y, Z.Y, W.Y,
        X.Z, Y.Z, Z.Z, W.Z,
        X.W, Y.W, Z.W, W.W
    );

    public readonly bool Equals(Mat44<T> other) => other == this;

    public override readonly bool Equals(object? obj) => (obj is Mat44<T> mat) && mat == this;

    public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

    // for tests readability
    public override readonly string ToString() => $"\n{X} \n{Y} \n{Z} \n{W}";
}
